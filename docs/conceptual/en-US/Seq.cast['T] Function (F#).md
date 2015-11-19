# Seq.cast<'T> Function (F#)

Wraps a weakly typed **N:System.Collections** sequence as a typed sequence.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Seq.cast : IEnumerable -> seq<'T>

// Usage:
Seq.cast source
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: **T:System.Collections.IEnumerable**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The use of this function usually requires a type annotation. An incorrect type annotation may result in runtime type errors. Individual **T:System.Collections.Generic.IEnumerator&#96;1** values generated from the returned sequence should not be accessed concurrently.

This function is named **Cast** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code demonstrates the use of Seq.cast to convert a weakly typed T:System.Collections.ArrayList, where the element type is just T:System.Object, into a sequence of int.**
**[!CODE [FsSequences#12](../CodeSnippet/VS_Snippets_Fsharp/fssequences/FSharp/fs/program.fs#12)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

