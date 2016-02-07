# Seq.compareWith<'T> Function (F#)

Compares two sequences using the given comparison function, element by element.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Seq.compareWith : ('T -> 'T -> int) -> seq<'T> -> seq<'T> -> int

// Usage:
Seq.compareWith comparer source1 source2

```



#### Parameters
*comparer*
Type: **'T -&gt; 'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


A function that takes an element from each sequence and returns an int. If it evaluates to a non-zero value iteration is stopped and that value is returned.


*source1*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The first input sequence.


*source2*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The second input sequence.



**exceptions tag is not supported!!!!**
**Returns the first non-zero result from the comparison function. If the end of a sequence is reached it returns a -1 if the first sequence is shorter and a 1 if the second sequence is shorter.**
## Remarks
This function is named **CompareWith** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.compareWith to compare two sequences using a custom comparison function.**
[!code-fsharp[Main](snippets/fssequences/snippet19.fs)]
**Sequence1 is less than sequence2.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

