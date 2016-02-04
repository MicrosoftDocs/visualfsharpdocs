# Seq.countBy<'T,'Key> Function (F#)

Applies a key-generating function to each element of a sequence and return a sequence yielding unique keys and their number of occurrences in the original sequence.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Seq.countBy : ('T -> 'Key) -> seq<'T> -> seq<'Key * int> (requires equality)

// Usage:
Seq.countBy projection source


```



#### CAPS_PARAMETERS_MD
*projection*
Type: **'T -&gt; 'Key**


A function transforming each item of input sequence into a key to be compared against the others.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**A sequence of unique keys and their number of occurrences in the original sequence.**
## CAPS_REMARKS_MD
Note that this function returns a sequence that traverses the whole initial sequence as soon as that sequence is iterated. As a result this function should not be used with large or infinite sequences. The function makes no assumption on the ordering of the original sequence.

This function is named **CountBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.countBy to determine the number of elements in a sequence that are odd or even.**


```



    let mySeq1 = seq { 1.. 100 }
    let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""
    let seqResult = Seq.countBy (fun elem ->
        if (elem % 2 = 0) then 0 else 1) mySeq1

    printSeq seqResult


```



**(1, 50) (0, 50)**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

