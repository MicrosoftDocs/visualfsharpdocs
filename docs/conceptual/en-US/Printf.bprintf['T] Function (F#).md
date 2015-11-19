# Printf.bprintf<'T> Function (F#)

Prints to a **T:System.Text.StringBuilder**.

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
bprintf : StringBuilder -> BuilderFormat<'T> -> 'T

// Usage:
bprintf builder format
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*builder*
Type: **T:System.Text.StringBuilder**


The StringBuilder object to print to.


*format*
Type: [BuilderFormat](http://msdn.microsoft.com/en-us/library/e6479548-d3ad-4522-baa5-987d52d7ce4a)**&lt;'T&gt;**


The input formatter.



**The return type and arguments of the formatter.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **PrintFormatToStringBuilder** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

