# Seq.exists2<'T1,'T2> Function (F#)

Tests if any pair of corresponding elements of the input sequences satisfies the given predicate.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Seq.exists2 : ('T1 -> 'T2 -> bool) -> seq<'T1> -> seq<'T2> -> bool

// Usage:
Seq.exists2 predicate source1 source2

```



#### Parameters
*predicate*
Type: **'T1 -&gt; 'T2 -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function to test each pair of items from the input sequences.


*source1*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T1&gt;**


The first input sequence.


*source2*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T2&gt;**


The second input sequence.



**exceptions tag is not supported!!!!**
**The predicate is applied to matching elements in the two sequences up to the lesser of the two lengths of the collections. If any application returns true then the overall result is true and no further elements are tested. Otherwise, false is returned.**
## Remarks
If one sequence is shorter than the other then the remaining elements of the longer sequence are ignored.

This function is named **Exists2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use Seq.exists2.**
<b>codeReference tag is not supported!!!!</b>
**Output**
**Sequences seq [1; 2; 3; 4; ...] and seq [5; 4; 3; 2; ...] have at least one equal element at the same position.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

