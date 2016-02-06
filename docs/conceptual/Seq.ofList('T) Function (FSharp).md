# Seq.ofList<'T> Function (F#)

Views the given list as a sequence.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Seq.ofList : 'T list -> seq<'T>

// Usage:
Seq.ofList source
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The result sequence.**
## Remarks
This function is named **OfList** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.ofList.**
[!code-fsharp[Main](snippets/fssequences/snippet61.fs)]
**F# Interactive Output**
**val seq1 : seq&lt;string&gt; = ["0"; "1"; "2"; "3"; "4"; "5"; "6"; "7"; "8"; "9"]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

