# Exceptions: the raise Function (F#)

The **raise** function is used to indicate that an error or exceptional condition has occurred. Information about the error is captured in an exception object.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
raise (expression)
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The **raise** function generates an exception object and initiates a stack unwinding process. The stack unwinding process is managed by the common language runtime (CLR), so the behavior of this process is the same as it is in any other .NET language. The stack unwinding process is a search for an exception handler that matches the generated exception. The search starts in the current **try...with** expression, if there is one. Each pattern in the **with** block is checked, in order. When a matching exception handler is found, the exception is considered handled; otherwise, the stack is unwound and **with** blocks up the call chain are checked until a matching handler is found. Any **finally** blocks that are encountered in the call chain are also executed in sequence as the stack unwinds.

The **raise** function is the equivalent of **throw** in C# or C++. Use **reraise** in a catch handler to propagate the same exception up the call chain.

The following code examples illustrate the use of the **raise** function to generate an exception.

[!CODE [FsLangRef2#5801](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/raise.fs#5801)]
    The **raise** function can also be used to raise .NET exceptions, as shown in the following example.

[!CODE [FsLangRef2#5802](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/raise.fs#5802)]
    
## See Also
[Exception Handling &#40;F&#35;&#41;](Exception+Handling+28%F%2329%.md)

[Exception Types &#40;F&#35;&#41;](Exception+Types+28%F%2329%.md)

[Exceptions: The try...with Expression &#40;F&#35;&#41;](Exceptions%3A+The+try...with+Expression+28%F%2329%.md)

[Exceptions: The try...finally Expression &#40;F&#35;&#41;](Exceptions%3A+The+try...finally+Expression+28%F%2329%.md)

[Exceptions: The failwith Function &#40;F&#35;&#41;](Exceptions%3A+The+failwith+Function+28%F%2329%.md)

[Exceptions: The invalidArg Function &#40;F&#35;&#41;](Exceptions%3A+The+invalidArg+Function+28%F%2329%.md)

