# do Bindings (F#)

A **do** binding is used to execute code without defining a function or value. Also, do bindings can be used in classes, see [do Bindings in Classes &#40;F&#35;&#41;](do-Bindings-in-Classes-%5BFSharp%5D.md).


## Syntax


```


[ attributes ]
[ do ]expression

```



## Remarks
Use a **do** binding when you want to execute code independently of a function or value definition. The expression in a **do** binding must return **unit**. Code in a top-level **do** binding is executed when the module is initialized. The keyword **do** is optional.

Attributes can be applied to a top-level **do** binding. For example, if your program uses COM interop, you might want to apply the **STAThread** attribute to your program. You can do this by using an attribute on a **do** binding, as shown in the following code.

[!code-fsharp[Main](snippets/fslangref1/snippet201.fs)]
    
## See Also
[F&#35; Language Reference](FSharp-Language-Reference.md)

[Functions &#40;F&#35;&#41;](Functions-%5BFSharp%5D.md)

