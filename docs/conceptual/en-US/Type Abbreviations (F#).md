# Type Abbreviations (F#)

A *type abbreviation* is an alias or alternate name for a type.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
type type-abbreviation = type-name
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
You can use type abbreviations to give a type a more meaningful name, in order to make code easier to read. You can also use them to create an easy to use name for a type that is otherwise cumbersome to write out. Additionally, you can use type abbreviations to make it easier to change an underlying type without changing all the code that uses the type. The following is a simple type abbreviation.

[!CODE [FsLangRef1#2301](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/typeabbreviations.fs#2301)]
    Type abbreviations can include generic parameters, as in the following code.

[!CODE [FsLangRef1#2302](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/typeabbreviations.fs#2302)]
    In the previous code, **transform** is a type abbreviation that represents a function that takes a single argument of any type and that returns a single value of that same type.

Type abbreviations are not preserved in the .NET Framework MSIL code. Therefore, when you use an F# assembly from another .NET Framework language, you must use the underlying type name for a type abbreviation.

Type abbreviations can also be used on units of measure. For more information, see [Units of Measure &#40;F&#35;&#41;](Units+of+Measure+28%F%2329%.md).


## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

