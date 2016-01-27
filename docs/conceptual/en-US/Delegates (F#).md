# Delegates (F#)

A delegate represents a function call as an object. In F#, you ordinarily should use function values to represent functions as first-class values; however, delegates are used in the .NET Framework and so are needed when you interoperate with APIs that expect them. They may also be used when authoring libraries designed for use from other .NET Framework languages.


## CAPS_SYNTAX_MD

```
type delegate-typename = delegate of type1 -> type2
```

## CAPS_REMARKS_MD
In the previous syntax, *type1* represents the argument type or types and *type2* represents the return type. The argument types that are represented by *type1* are automatically curried. This suggests that for this type you use a tuple form if the arguments of the target function are curried, and a parenthesized tuple for arguments that are already in the tuple form. The automatic currying removes a set of parentheses, leaving a tuple argument that matches the target method. Refer to the code example for the syntax you should use in each case.

Delegates can be attached to F# function values, and static or instance methods. F# function values can be passed directly as arguments to delegate constructors. For a static method, you construct the delegate by using the name of the class and the method. For an instance method, you provide the object instance and method in one argument. In both cases, the member access operator (**.**) is used.

The **Invoke** method on the delegate type calls the encapsulated function. Also, delegates can be passed as function values by referencing the Invoke method name without the parentheses.

The following code shows the syntax for creating delegates that represent various methods in a class. Depending on whether the method is a static method or an instance method, and whether it has arguments in the tuple form or the curried form, the syntax for declaring and assigning the delegate is a little different.

```

type Test1() =
  static member add(a : int, b : int) =
     a + b
  static member add2 (a : int) (b : int) =
     a + b

  member x.Add(a : int, b : int) =
     a + b
  member x.Add2 (a : int) (b : int) =
     a + b


// Delegate1 works with tuple arguments.
type Delegate1 = delegate of (int * int) -> int
// Delegate2 works with curried arguments.
type Delegate2 = delegate of int * int -> int

let InvokeDelegate1 (dlg : Delegate1) (a : int) (b: int) =
   dlg.Invoke(a, b)
let InvokeDelegate2 (dlg : Delegate2) (a : int) (b: int) =
   dlg.Invoke(a, b)

// For static methods, use the class name, the dot operator, and the
// name of the static method.
let del1 : Delegate1 = new Delegate1( Test1.add )
let del2 : Delegate2 = new Delegate2( Test1.add2 )

let testObject = Test1()

// For instance methods, use the instance value name, the dot operator, and the instance method name.
let del3 : Delegate1 = new Delegate1( testObject.Add )
let del4 : Delegate2 = new Delegate2( testObject.Add2 )

for (a, b) in [ (100, 200); (10, 20) ] do
  printfn "%d + %d = %d" a b (InvokeDelegate1 del1 a b)
  printfn "%d + %d = %d" a b (InvokeDelegate2 del2 a b)
  printfn "%d + %d = %d" a b (InvokeDelegate1 del3 a b)
  printfn "%d + %d = %d" a b (InvokeDelegate2 del4 a b)
```

    The following code shows some of the different ways you can work with delegates.

```

    type Delegate1 = delegate of int * char -> string

    let replicate n c = String.replicate n (string c)

    // An F# function value constructed from an unapplied let-bound function 
    let function1 = replicate

    // A delegate object constructed from an F# function value
    let delObject = new Delegate1(function1)

    // An F# function value constructed from an unapplied .NET member
    let functionValue = delObject.Invoke

    List.map (fun c -> functionValue(5,c)) ['a'; 'b'; 'c']
    |> List.iter (printfn "%s")

    // Or if you want to get back the same curried signature
    let replicate' n c =  delObject.Invoke(n,c)

    // You can pass a lambda expression as an argument to a function expecting a compatible delegate type
    // System.Array.ConvertAll takes an array and a converter delegate that transforms an element from
    // one type to another according to a specified function.
    let stringArray = System.Array.ConvertAll([|'a';'b'|], fun c -> replicate' 3 c)
    printfn "%A" stringArray
```

    The output of the previous code example is as follows.


```
aaaaa
bbbbb
ccccc
[|"aaa"; "bbb"|]
```

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Parameters and Arguments &#40;F&#35;&#41;](Parameters+and+Arguments+%28F%23%29.md)

[Events &#40;F&#35;&#41;](Events+%28F%23%29.md)

