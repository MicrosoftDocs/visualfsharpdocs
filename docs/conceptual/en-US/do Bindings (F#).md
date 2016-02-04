# do Bindings (F#)

A **do** binding is used to execute code without defining a function or value. Also, do bindings can be used in classes, see [do Bindings in Classes &#40;F&#35;&#41;](do+Bindings+in+Classes+%28F%23%29.md).


## CAPS_SYNTAX_MD



```


[ attributes ]
[ do ]expression


```



## CAPS_REMARKS_MD
Use a **do** binding when you want to execute code independently of a function or value definition. The expression in a **do** binding must return **unit**. Code in a top-level **do** binding is executed when the module is initialized. The keyword **do** is optional.

Attributes can be applied to a top-level **do** binding. For example, if your program uses COM interop, you might want to apply the **STAThread** attribute to your program. You can do this by using an attribute on a **do** binding, as shown in the following code.



```



open System
open System.Windows.Forms

let form1 = new Form()
form1.Text <- "XYZ"

[<STAThread>]
do
   Application.Run(form1)


```



    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Functions &#40;F&#35;&#41;](Functions+%28F%23%29.md)

