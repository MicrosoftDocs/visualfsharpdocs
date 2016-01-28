# Exception Types (F#)

There are two categories of exceptions in F#: .NET exception types and F# exception types. This topic describes how to define and use F# exception types.


## CAPS_SYNTAX_MD

```
exception exception-type of argument-type
```

## CAPS_REMARKS_MD
In the previous syntax, *exception-type* is the name of a new F# exception type, and *argument-type* represents the type of an argument that can be supplied when you raise an exception of this type. You can specify multiple arguments by using a tuple type for *argument-type*.

A typical definition for an F# exception resembles the following.

```

exception MyError of string
```

    You can generate an exception of this type by using the **raise** function, as follows.

```

raise (MyError("Error message"))
```

    You can use an F# exception type directly in the filters in a **try...with** expression, as shown in the following example.

```

exception Error1 of string
// Using a tuple type as the argument type.
exception Error2 of string * int

let function1 x y =
   try
      if x = y then raise (Error1("x"))
      else raise (Error2("x", 10))
   with
      | Error1(str) -> printfn "Error1 %s" str
      | Error2(str, i) -> printfn "Error2 %s %d" str i
 
function1 10 10
function1 9 2
```

    The exception type that you define with the **exception** keyword in F# is a new type that inherits from **T:System.Exception**.


## See Also
[Exception Handling &#40;F&#35;&#41;](Exception+Handling+%28F%23%29.md)

[Exceptions: the raise Function &#40;F&#35;&#41;](Exceptions+-+the+raise+Function+%28F%23%29.md)

[Exception Hierarchy](https://msdn.microsoft.com/en-us/library/z4c5tckx.aspx)

