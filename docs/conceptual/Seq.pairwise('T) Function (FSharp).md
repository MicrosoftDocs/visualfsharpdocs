# Seq.pairwise<'T> Function (F#)

Returns a sequence of each element in the input sequence and its predecessor, with the exception of the first element which is only returned as the predecessor of the second element.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Seq.pairwise : seq<'T> -> seq<'T * 'T>

// Usage:
Seq.pairwise source

```



#### Parameters
*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
This function is named **Pairwise** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.pairwise. The initial sequence is a sequence of squares up to 100. The Seq.pairwise function generates a sequence of tuples of consecutive squares, { (1, 4), (4, 9), (9, 16) ... }. The second part of the example produces a list of the differences in each pair of squares.**
[!code-fsharp[Main](snippets/fssequences/snippet18.fs)]
**(1, 4) (4, 9) (9, 16) (16, 25) (25, 36) (36, 49) (49, 64) (64, 81) (81, 100)**
**3 5 7 9 11 13 15 17 19**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

