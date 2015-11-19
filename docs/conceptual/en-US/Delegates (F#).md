# Delegates (F#)

A delegate represents a function call as an object. In F#, you ordinarily should use function values to represent functions as first-class values; however, delegates are used in the .NET Framework and so are needed when you interoperate with APIs that expect them. They may also be used when authoring libraries designed for use from other .NET Framework languages.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
type delegate-typename = delegate of type1 -> type2
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
In the previous syntax, *type1* represents the argument type or types and *type2* represents the return type. The argument types that are represented by *type1* are automatically curried. This suggests that for this type you use a tuple form if the arguments of the target function are curried, and a parenthesized tuple for arguments that are already in the tuple form. The automatic currying removes a set of parentheses, leaving a tuple argument that matches the target method. Refer to the code example for the syntax you should use in each case.

Delegates can be attached to F# function values, and static or instance methods. F# function values can be passed directly as arguments to delegate constructors. For a static method, you construct the delegate by using the name of the class and the method. For an instance method, you provide the object instance and method in one argument. In both cases, the member access operator (**.**) is used.

The **Invoke** method on the delegate type calls the encapsulated function. Also, delegates can be passed as function values by referencing the Invoke method name without the parentheses.

The following code shows the syntax for creating delegates that represent various methods in a class. Depending on whether the method is a static method or an instance method, and whether it has arguments in the tuple form or the curried form, the syntax for declaring and assigning the delegate is a little different.

[!CODE [FsLangRef2#4201](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/delegates.fs#4201)]
    The following code shows some of the different ways you can work with delegates.

[!CODE [FsLangRef2#4202](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/delegates.fs#4202)]
    The output of the previous code example is as follows.


```
aaaaa
bbbbb
ccccc
[|"aaa"; "bbb"|]
```

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Parameters and Arguments &#40;F&#35;&#41;](Parameters+and+Arguments+28%F%2329%.md)

[Events &#40;F&#35;&#41;](Events+28%F%2329%.md)

