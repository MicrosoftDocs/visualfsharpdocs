# Seq.distinctBy<'T,'Key> Function (F#)

Returns a sequence that contains no duplicate entries according to the generic hash and equality comparisons on the keys returned by the given key-generating function. If an element occurs multiple times in the sequence then the later occurrences are discarded.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Seq.distinctBy : ('T -> 'Key) -> seq<'T> -> seq<'T> (requires equality)

// Usage:
Seq.distinctBy projection source

```



#### Parameters
*projection*
Type: **'T -&gt; 'Key**


A function that transforms the sequence items into comparable keys.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
This function is named **DistinctBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.distinctBy to keep only the elements in a sequence that have a distinct absolute value. The first element with a given result is retained in the new sequence, so the positive numbers from 1 to 5 are dropped in the sequence from -5 to +10.**
[!code-fsharp[Main](snippets/fssequences/snippet23.fs)]
**Original sequence:**
**-5 -4 -3 -2 -1 0 1 2 3 4 5 6 7 8 9 10**
**Sequence with distinct absolute values:**
**-5 -4 -3 -2 -1 0 6 7 8 9 10**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

