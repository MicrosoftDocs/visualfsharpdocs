# Printf.kbprintf<'Result,'T> Function (F#)

Like [bprintf](http://msdn.microsoft.com/en-us/library/5448c060-a61d-4f3d-a9ec-e0cc998b4d87), but calls the specified function to generate the result. See [kprintf](http://msdn.microsoft.com/en-us/library/fa31f68e-f039-4406-b9e1-688945430124).

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
kbprintf : (unit -> 'Result) -> StringBuilder -> BuilderFormat<'T,'Result> -> 'T

// Usage:
kbprintf continutation builder format
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*continutation*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt; 'Result**


The function called after formatting to generate the format result.


*builder*
Type: **T:System.Text.StringBuilder**


The input StringBuilder.


*format*
Type: [BuilderFormat](http://msdn.microsoft.com/en-us/library/79f817c8-9d0c-440c-9174-d6ef1eabcaa0)**&lt;'T,'Result&gt;**


The input formatter.



**The arguments of the formatter.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **PrintFormatToStringBuilderThen** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

