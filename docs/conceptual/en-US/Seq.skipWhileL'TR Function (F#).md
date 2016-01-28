# Seq.skipWhile<'T> Function (F#)

Returns a sequence that, when iterated, skips elements of the underlying sequence while the given predicate returns **true**, and then yields the remaining elements of the sequence.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.skipWhile : ('T -> bool) -> seq<'T> -> seq<'T>

// Usage:
Seq.skipWhile predicate source
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function that evaluates an element of the sequence to a Boolean value.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This function is named **SkipWhile** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.skipWhile. The resulting sequences contains only elements that are greater than 10.**
```

    let mySeq = seq { for i in 1 .. 10 -> i*i }
    let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""
    let mySeqSkipWhileLessThan10 = Seq.skipWhile (fun elem -> elem < 10) mySeq
    mySeqSkipWhileLessThan10 |> printSeq
```

**16 25 36 49 64 81 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

