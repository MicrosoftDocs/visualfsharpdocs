# Casting and Conversions (F#)

This topic describes support for type conversions in F#.


## Arithmetic Types
F# provides conversion operators for arithmetic conversions between various primitive types, such as between integer and floating point types. The integral and char conversion operators have checked and unchecked forms; the floating point operators and the **enum** conversion operator do not. The unchecked forms are defined in **Microsoft.FSharp.Core.Operators** and the checked forms are defined in **Microsoft.FSharp.Core.Operators.Checked**. The checked forms check for overflow and generate a runtime exception if the resulting value exceeds the limits of the target type.

Each of these operators has the same name as the name of the destination type. For example, in the following code, in which the types are explicitly annotated, **byte** appears with two different meanings. The first occurrence is the type and the second is the conversion operator.



```



let x : int = 5

let b : byte = byte x


```



    The following table shows conversion operators defined in F#.



|Operator|Description|
|--------|-----------|
|**byte**|Convert to byte, an 8-bit unsigned type.|
|**sbyte**|Convert to signed byte.|
|**int16**|Convert to a 16-bit signed integer.|
|**uint16**|Convert to a 16-bit unsigned integer.|
|**int32, int**|Convert to a 32-bit signed integer.|
|**uint32**|Convert to a 32-bit unsigned integer.|
|**int64**|Convert to a 64-bit signed integer.|
|**uint64**|Convert to a 64-bit unsigned integer.|
|**nativeint**|Convert to a native integer.|
|**unativeint**|Convert to an unsigned native integer.|
|**float, double**|Convert to a 64-bit double-precision IEEE floating point number.|
|**float32, single**|Convert to a 32-bit single-precision IEEE floating point number.|
|**decimal**|Convert to **System.Decimal**.|
|**char**|Convert to **System.Char**, a Unicode character.|
|**enum**|Convert to an enumerated type.|
In addition to built-in primitive types, you can use these operators with types that implement **op_Explicit** or **op_Implicit** methods with appropriate signatures. For example, the **int** conversion operator works with any type that provides a static method **op_Explicit** that takes the type as a parameter and returns **int**. As a special exception to the general rule that methods cannot be overloaded by return type, you can do this for**op_Explicit** and **op_Implicit**.


## Enumerated Types
The **enum** operator is a generic operator that takes one type parameter that represents the type of the **enum** to convert to. When it converts to an enumerated type, type inference attempts to determine the type of the **enum** that you want to convert to. In the following example, the variable **col1** is not explicitly annotated, but its type is inferred from the later equality test. Therefore, the compiler can deduce that you are converting to a **Color** enumeration. Alternatively, you can supply a type annotation, as with **col2** in the following example.



```



type Color =
    | Red = 1
    | Green = 2
    | Blue = 3

// The target type of the conversion is determined by type inference.
let col1 = enum 1
// The target type is supplied by a type annotation.
let col2 : Color = enum 2 
do
    if (col1 = Color.Red) then
       printfn "Red"


```



    
    You can also specify the target enumeration type explicitly as a type parameter, as in the following code:




```


let col3 = enum<Color> 3


```


Note that the enumeration casts work only if the underlying type of the enumeration is compatible with the type being converted. In the following code, the conversion fails to compile because of the mismatch between **int32** and **uint32**.




```


// Error: types are incompatible
let col4 : Color = enum 2u


```


For more information, see [Enumerations &#40;F&#35;&#41;](Enumerations+%28F%23%29.md).


## Casting Object Types
Conversion between types in an object hierarchy is fundamental to object-oriented programming. There are two basic types of conversions: casting up (upcasting) and casting down (downcasting). Casting up a hierarchy means casting from a derived object reference to a base object reference. Such a cast is guaranteed to work as long as the base class is in the inheritance hierarchy of the derived class. Casting down a hierarchy, from a base object reference to a derived object reference, succeeds only if the object actually is an instance of the correct destination (derived) type or a type derived from the destination type.

F# provides operators for these types of conversions. The **:&gt;** operator casts up the hierarchy, and the **:?&gt;** operator casts down the hierarchy.


### Upcasting
In many object-oriented languages, upcasting is implicit; in F#, the rules are slightly different. Upcasting is applied automatically when you pass arguments to methods on an object type. However, for let-bound functions in a module, upcasting is not automatic, unless the parameter type is declared as a flexible type. For more information, see [Flexible Types &#40;F&#35;&#41;](Flexible+Types+%28F%23%29.md).

The **:&gt;** operator performs a static cast, which means that the success of the cast is determined at compile time. If a cast that uses **:&gt;** compiles successfully, it is a valid cast and has no chance of failure at run time.

You can also use the **upcast** operator to perform such a conversion. The following expression specifies a conversion up the hierarchy.

**upcast***expression*

When you use the upcast operator, the compiler attempts to infer the type you are converting to from the context. If the compiler is unable to determine the target type, the compiler reports an error.


### Downcasting
The **:?&gt;** operator performs a dynamic cast, which means that the success of the cast is determined at run time. A cast that uses the **:?&gt;** operator is not checked at compile time; but at run time, an attempt is made to cast to the specified type. If the object is compatible with the target type, the cast succeeds. If the object is not compatible with the target type, the runtime raises an **InvalidCastException**.

You can also use the **downcast** operator to perform a dynamic type conversion. The following expression specifies a conversion down the hierarchy to a type that is inferred from program context.

**downcast***expression*

As for the upcast operator, if the compiler cannot infer a specific target type from the context, it reports an error.

The following code illustrates the use of the **:&gt;** and **:?&gt;** operators. The code illustrates that the **:?&gt;** operator is best used when you know that conversion will succeed, because it throws **InvalidCastException** if the conversion fails. If you do not know that a conversion will succeed, a type test that uses a **match** expression is better because it avoids the overhead of generating an exception.



```



type Base1() =
    abstract member F : unit -> unit
    default u.F() =
     printfn "F Base1"
  
type Derived1() =
    inherit Base1()
    override u.F() =
      printfn "F Derived1"
      
      
let d1 : Derived1 = Derived1()

// Upcast to Base1.
let base1 = d1 :> Base1

// This might throw an exception, unless
// you are sure that base1 is really a Derived1 object, as
// is the case here.
let derived1 = base1 :?> Derived1

// If you cannot be sure that b1 is a Derived1 object,
// use a type test, as follows:
let downcastBase1 (b1 : Base1) =
   match b1 with
   | :? Derived1 as derived1 -> derived1.F()
   | _ -> ()

downcastBase1 base1


```



    Because generic operators **downcast** and **upcast** rely on type inference to determine the argument and return type, in the above code, you can replace

**let base1 = d1 :&gt; Base1**

with

**base1 = upcast d1**

In the previous code, the argument type and return types are **Derived1** and **Base1**, respectively.

For more information about type tests, see [Match Expressions &#40;F&#35;&#41;](Match+Expressions+%28F%23%29.md).


## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

