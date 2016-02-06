# Printf.ksprintf<'Result,'T> Function (F#)

Like [sprintf](http://msdn.microsoft.com/en-us/library/d66bc456-582f-48ec-8054-ca48d99d6ffd), but calls the specified function to generate the result. See [kprintf](http://msdn.microsoft.com/en-us/library/fa31f68e-f039-4406-b9e1-688945430124).

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
ksprintf : (string -> 'Result) -> StringFormat<'T,'Result> -> 'T

// Usage:
ksprintf continutation format
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*continutation*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)**-&gt; 'Result**


The function called to generate a result from the formatted string.


*format*
Type: [StringFormat](http://msdn.microsoft.com/en-us/library/d69a911f-3a25-42fa-bd51-a9c9c1102fa8)**&lt;'T,'Result&gt;**


The input formatter.



**The arguments of the formatter.**
## Remarks
This function is named **PrintFormatToStringThen** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

