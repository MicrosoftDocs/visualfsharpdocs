# Seq.cast<'T> Function (F#)

Wraps a weakly typed **N:System.Collections** sequence as a typed sequence.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Seq.cast : IEnumerable -> seq<'T>

// Usage:
Seq.cast source
```

#### Parameters
*source*
Type: **T:System.Collections.IEnumerable**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
The use of this function usually requires a type annotation. An incorrect type annotation may result in runtime type errors. Individual **T:System.Collections.Generic.IEnumerator&#96;1** values generated from the returned sequence should not be accessed concurrently.

This function is named **Cast** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code demonstrates the use of Seq.cast to convert a weakly typed T:System.Collections.ArrayList, where the element type is just T:System.Object, into a sequence of int.**
[!code-fsharp[Main](snippets/fssequences/snippet12.fs)]
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

