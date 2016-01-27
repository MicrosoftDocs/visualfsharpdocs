# Explicit Fields: The val Keyword (F#)

The **val** keyword is used to declare a location to store a value in a class or structure type, without initializing it. Storage locations declared in this manner are called *explicit fields*. Another use of the **val** keyword is in conjunction with the **member** keyword to declare an auto-implemented property. For more information on auto-implemented properties, see [Properties &#40;F&#35;&#41;](Properties+%28F%23%29.md).


## CAPS_SYNTAX_MD

```
val [ mutable ] [ access-modifier ] field-name : type-name
```

## CAPS_REMARKS_MD
The usual way to define fields in a class or structure type is to use a **let** binding. However, **let** bindings must be initialized as part of the class constructor, which is not always possible, necessary, or desirable. You can use the **val** keyword when you want a field that is uninitialized.

Explicit fields can be static or non-static. The *access-modifier* can be **public**, **private**, or **internal**. By default, explicit fields are public. This differs from **let** bindings in classes, which are always private.

The [DefaultValue](http://msdn.microsoft.com/en-us/library/a3a3307b-8c05-441e-b109-245511614d58) attribute is required on explicit fields in class types that have a primary constructor. This attribute specifies that the field is initialized to zero. The type of the field must support zero-initialization. A type supports zero-initialization if it is one of the following:


- A primitive type that has a zero value.
<br />

- A type that supports a null value, either as a normal value, as an abnormal value, or as a representation of a value. This includes classes, tuples, records, functions, interfaces, .NET reference types, the **unit** type, and discriminated union types.
<br />

- A .NET value type.
<br />

- A structure whose fields all support a default zero value.
<br />

For example, an immutable field called **someField** has a backing field in the .NET compiled representation with the name **someField@**, and you access the stored value using a property named **someField**.

For a mutable field, the .NET compiled representation is a .NET field.


>[!WARNING] {**Note** The .NET Framework namespace **N:System.ComponentModel** contains an attribute that has the same name. For information about this attribute, see **T:System.ComponentModel.DefaultValueAttribute**.

}
The following code shows the use of explicit fields and, for comparison, a **let** binding in a class that has a primary constructor. Note that the **let**-bound field **myInt1** is private. When the **let**-bound field **myInt1** is referenced from a member method, the self identifier **this** is not required. But when you are referencing the explicit fields **myInt2** and **myString**, the self identifier is required.

```

type MyType() =
    let mutable myInt1 = 10
    [<DefaultValue>] val mutable myInt2 : int
    [<DefaultValue>] val mutable myString : string
    member this.SetValsAndPrint( i: int, str: string) =
       myInt1 <- i
       this.myInt2 <- i + 1
       this.myString <- str
       printfn "%d %d %s" myInt1 (this.myInt2) (this.myString)

let myObject = new MyType()
myObject.SetValsAndPrint(11, "abc")
// The following line is not allowed because let bindings are private.
// myObject.myInt1 <- 20
myObject.myInt2 <- 30
myObject.myString <- "def"

printfn "%d %s" (myObject.myInt2) (myObject.myString)
```

    The output is as follows:

**11 12 abc**

**30 def**

The following code shows the use of explicit fields in a class that does not have a primary constructor. In this case, the **DefaultValue** attribute is not required, but all the fields must be initialized in the constructors that are defined for the type.

```

type MyClass =
    val a : int
    val b : int
    // The following version of the constructor is an error
    // because b is not initialized.
    // new (a0, b0) = { a = a0; }
    // The following version is acceptable because all fields are initialized.
    new(a0, b0) = { a = a0; b = b0; }

let myClassObj = new MyClass(35, 22)
printfn "%d %d" (myClassObj.a) (myClassObj.b)
```

    The output is **35 22**.

The following code shows the use of explicit fields in a structure. Because a structure is a value type, it automatically has a default constructor that sets the values of its fields to zero. Therefore, the **DefaultValue** attribute is not required.

```

type MyStruct =
    struct
        val mutable myInt : int
        val mutable myString : string
    end

let mutable myStructObj = new MyStruct()
myStructObj.myInt <- 11
myStructObj.myString <- "xyz"

printfn "%d %s" (myStructObj.myInt) (myStructObj.myString)
```

    The output is **11 xyz**.

Explicit fields are not intended for routine use. In general, when possible you should use a **let** binding in a class instead of an explicit field. Explicit fields are useful in certain interoperability scenarios, such as when you need to define a structure that will be used in a platform invoke call to a native API, or in COM interop scenarios. For more information, see [External Functions &#40;F&#35;&#41;](External+Functions+%28F%23%29.md). Another situation in which an explicit field might be necessary is when you are working with an F# code generator which emits classes without a primary constructor. Explicit fields are also useful for thread-static variables or similar constructs. For more information, see **T:System.ThreadStaticAttribute**.

When the keywords **member val** appear together in a type definition, it is a definition of an automatically implemented property. For more information, see [Properties &#40;F&#35;&#41;](Properties+%28F%23%29.md).


## See Also
[Properties &#40;F&#35;&#41;](Properties+%28F%23%29.md)

[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

[let Bindings in Classes &#40;F&#35;&#41;](let+Bindings+in+Classes+%28F%23%29.md)

