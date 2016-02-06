# Seq.ofArray<'T> Function (F#)

Views the given array as a sequence.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Seq.ofArray : 'T array -> seq<'T>

// Usage:
Seq.ofArray source
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: **'T array**


The input array.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
This function is named **OfArray** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.ofArray.**
[!code-fsharp[Main](snippets/fssequences/snippet60.fs)]
**F# Interactive Output**
**val seq1 : seq&lt;string&gt;**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

