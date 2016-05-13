# Verbose Syntax (F#)

There are two forms of syntax available for many constructs in the F# language: *verbose syntax* and *lightweight syntax*. The verbose syntax is not as commonly used, but has the advantage of being less sensitive to indentation. The lightweight syntax is shorter and uses indentation to signal the beginning and end of constructs, rather than additional keywords like **begin**, **end**, **in**, and so on. The default syntax is the lightweight syntax. This topic describes the syntax for F# constructs when lightweight syntax is not enabled. Verbose syntax is always enabled, so even if you enable lightweight syntax, you can still use verbose syntax for some constructs. You can disable lightweight syntax by using the **#light "off"** directive.


## Table of Constructs
The following table shows the lightweight and verbose syntax for F# language constructs in contexts where there is a difference between the two forms. In this table, angle brackets (&lt;&gt;) enclose user-supplied syntax elements. Refer to the documentation for each language construct for more detailed information about the syntax used within these constructs.



|Language construct|Lightweight syntax|Verbose syntax|
|------------------|------------------|--------------|
|compound expressions|

```



<br /><expression1><br /><expression2><br />

```



|

```



<br /><expression1>; <expression2><br />

```



|
|nested **let** bindings|

```



<br />let f x =<br />let a = 1<br />let b = 2<br />x + a + b<br />

```



|

```



<br />let f x =<br />let a = 1 in<br />let b = 2 in<br />x + a + b<br />

```



|
|code block|

```



<br /><expression1><br /><expression2><br />...<br />

```



|

```



<br />begin<br /><expression1>;<br /><expression2>;<br />end<br />

```



|
|**for...do**|

```



<br />for counter = start to finish do<br />...<br />

```



|

```



<br />for counter = start .. finish do<br />...<br />done<br />

```



|
|**while...do**|

```



<br />while <condition> do<br />...<br />

```



|

```



<br />while <condition> do<br />...<br />done<br />

```



|
|**for...in**|

```



<br />for var in start .. finish do<br />...<br />

```



|

```



<br />for var in start .. finish do<br />...<br />done<br />

```



|
|**do**|

```



<br />do ...<br />

```



|

```



<br />do ... in<br />

```



|
|record|

```



<br />type <record-name> =<br />{<br /><field-declarations><br />}<br /><value-or-member-definitions><br />

```



|

```



<br />type <record-name> =<br />{<br /><field-declarations><br />}<br />with<br /><value-or-member-definitions><br />end<br />

```



|
|class|

```



<br />type <class-name>(<params>) =<br />...<br />

```



|

```



<br />type <class-name>(<params>) =<br />class<br />...<br />end<br />

```



|
|structure|

```



<br />[<StructAttribute>]<br />type <structure-name> =<br />...<br />

```



|

```



<br />type <structure-name> =<br />struct<br />...<br />end<br />

```



|
|discriminated union|

```



<br />type <union-name> =<br />&#124; ...<br />&#124; ...<br />...<br /><value-or-member definitions><br />

```



|

```



<br />type <union-name> =<br />&#124; ...<br />&#124; ...<br />...<br />with<br /><value-or-member-definitions><br />

```



<br />**end**|
|interface|

```



<br />type <interface-name> =<br />...<br />

```



|

```



<br />type <interface-name> =<br />interface<br />...<br />end<br />

```



|
|object expression|

```



<br />{ new <type-name><br />with<br /><value-or-member-definitions><br /><interface-implementations><br />}<br />

```



|

```



<br />{ new <type-name><br />with<br /><value-or-member-definitions><br />end<br /><interface-implementations><br />}<br />

```



|
|interface implementation|

```



<br />interface <interface-name><br />with<br /><value-or-member-definitions><br />

```



|

```



<br />interface <interface-name><br />with<br /><value-or-member-definitions><br />end<br />

```



|
|type extension|

```



<br />type <type-name><br />with<br /><value-or-member-definitions><br />

```



|

```



<br />type <type-name><br />with<br /><value-or-member-definitions><br />end<br />

```



|
|module|

```



<br />module <module-name> =<br />...<br />

```



|

```



<br />module <module-name> =<br />begin<br />...<br />end<br />

```



|

## See Also
[F&#35; Language Reference](FSharp-Language-Reference.md)

[Compiler Directives &#40;F&#35;&#41;](Compiler-Directives-%5BFSharp%5D.md)

[Code Formatting Guidelines &#40;F&#35;&#41;](Code-Formatting-Guidelines-%5BFSharp%5D.md)

