# Exception Types (F#)

There are two categories of exceptions in F#: .NET exception types and F# exception types. This topic describes how to define and use F# exception types.


## Syntax

```
exception exception-type of argument-type
```

## Remarks
In the previous syntax, *exception-type* is the name of a new F# exception type, and *argument-type* represents the type of an argument that can be supplied when you raise an exception of this type. You can specify multiple arguments by using a tuple type for *argument-type*.

A typical definition for an F# exception resembles the following.

[!code-fsharp[Main](snippets/fslangref2/snippet5501.fs)]
    You can generate an exception of this type by using the **raise** function, as follows.

[!code-fsharp[Main](snippets/fslangref2/snippet5502.fs)]
    You can use an F# exception type directly in the filters in a **try...with** expression, as shown in the following example.

[!code-fsharp[Main](snippets/fslangref2/snippet5503.fs)]
    The exception type that you define with the **exception** keyword in F# is a new type that inherits from **T:System.Exception**.


## See Also
[Exception Handling &#40;F&#35;&#41;](Exception+Handling+%28FSharp%29.md)

[Exceptions: the raise Function &#40;F&#35;&#41;](Exceptions%3A+the+raise+Function+%28FSharp%29.md)

[Exception Hierarchy](Exception+Hierarchy.md)

