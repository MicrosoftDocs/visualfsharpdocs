# do Bindings (F#)

A **do** binding is used to execute code without defining a function or value. Also, do bindings can be used in classes, see [do Bindings in Classes &#40;F&#35;&#41;](do+Bindings+in+Classes+28%F%2329%.md).


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[ attributes ]
[ do ]expression
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
Use a **do** binding when you want to execute code independently of a function or value definition. The expression in a **do** binding must return **unit**. Code in a top-level **do** binding is executed when the module is initialized. The keyword **do** is optional.

Attributes can be applied to a top-level **do** binding. For example, if your program uses COM interop, you might want to apply the **STAThread** attribute to your program. You can do this by using an attribute on a **do** binding, as shown in the following code.

[!CODE [FsLangRef1#201](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/dobindings.fs#201)]
    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Functions &#40;F&#35;&#41;](Functions+28%F%2329%.md)

