# Seq.reduce<'T> Function (F#)

Applies a function to each element of the sequence, threading an accumulator argument through the computation. This function begins by applying the function to the first two elements. It then passes this result into the function along with the third element and so on. The function returns the final result.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Seq.reduce : ('T -> 'T -> 'T) -> seq<'T> -> 'T

// Usage:
Seq.reduce reduction source
```

#### Parameters
*reduction*
Type: **'T -&gt; 'T -&gt; 'T**


A function that takes in the current accumulated result and the next element of the sequence to produce the next accumulated result.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result of the computation.**
## Remarks
This function is named **Reduce** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

