# Exception Types (F#)

There are two categories of exceptions in F#: .NET exception types and F# exception types. This topic describes how to define and use F# exception types.


## CAPS_SYNTAX_MD

```
exception exception-type of argument-type
```

## CAPS_REMARKS_MD
In the previous syntax, *exception-type* is the name of a new F# exception type, and *argument-type* represents the type of an argument that can be supplied when you raise an exception of this type. You can specify multiple arguments by using a tuple type for *argument-type*.

A typical definition for an F# exception resembles the following.

[!CODE [FsLangRef2#5501](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/exceptiontypes.fs#5501)]
    You can generate an exception of this type by using the **raise** function, as follows.

[!CODE [FsLangRef2#5502](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/exceptiontypes.fs#5502)]
    You can use an F# exception type directly in the filters in a **try...with** expression, as shown in the following example.

[!CODE [FsLangRef2#5503](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/exceptiontypes.fs#5503)]
    The exception type that you define with the **exception** keyword in F# is a new type that inherits from **T:System.Exception**.


## See Also
[Exception Handling &#40;F&#35;&#41;](Exception+Handling+%28F%23%29.md)

[Exceptions: the raise Function &#40;F&#35;&#41;](Exceptions%3A+the+raise+Function+%28F%23%29.md)

[Exception Hierarchy](Exception+Hierarchy.md)

