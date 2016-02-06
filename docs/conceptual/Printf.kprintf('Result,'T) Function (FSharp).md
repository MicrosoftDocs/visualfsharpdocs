# Printf.kprintf<'Result,'T> Function (F#)

Like [printf](http://msdn.microsoft.com/en-us/library/f21a2219-5d06-4211-82a3-c4538fc47f34), but calls the specified function to generate the result. For example, these let the printing force a flush after all output has been entered onto the channel, but not before.

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
kprintf : (string -> 'Result) -> StringFormat<'T,'Result> -> 'T

// Usage:
kprintf continutation format
```

#### Parameters
*continutation*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)**-&gt; 'Result**


The function called after formatting to generate the format result.


*format*
Type: [StringFormat](http://msdn.microsoft.com/en-us/library/d69a911f-3a25-42fa-bd51-a9c9c1102fa8)**&lt;'T,'Result&gt;**


The input formatter.



**The arguments of the formatter.**
## Remarks
This function is named **PrintFormatThen** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

