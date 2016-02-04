# Seq.forall2<'T1,'T2> Function (F#)

Tests whether all the pairs of elements drawn from the two sequences satisfy the given predicate. If one sequence is shorter than the other then the remaining elements of the longer sequence are ignored.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Seq.forall2 : ('T1 -> 'T2 -> bool) -> seq<'T1> -> seq<'T2> -> bool

// Usage:
Seq.forall2 predicate source1 source2


```



#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T1 -&gt; 'T2 -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function to test pairs of elements from the input sequences.


*source1*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T1&gt;**


The first input sequence.


*source2*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T2&gt;**


The second input sequence.



**exceptions tag is not supported!!!!**
**true if all element pairs in the sequences satisfy the given predicate. Otherwise, returns false.**
## CAPS_REMARKS_MD
This function is named **ForAll2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.forall2.**


```



    // This function can be used on any sequence, so the same function
    // works with both lists and arrays.
    let allEqual coll = Seq.forall2 (fun elem1 elem2 -> elem1 = elem2) coll
    printfn "%A" (allEqual [| 1; 2 |] [| 1; 2 |])
    printfn "%A" (allEqual [ 1; 2 ] [ 2; 1 ])


```



**Output**
**true**
**false**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

