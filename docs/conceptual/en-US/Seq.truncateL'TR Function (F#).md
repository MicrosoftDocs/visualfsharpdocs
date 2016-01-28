# Seq.truncate<'T> Function (F#)

Returns a sequence that when enumerated returns at most N elements.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.truncate : int -> seq<'T> -> seq<'T>

// Usage:
Seq.truncate count source
```

#### CAPS_PARAMETERS_MD
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The maximum number of items to enumerate.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This function is named **Truncate** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.truncate and contrasts the behavior with Seq.take.**
```

let mySeq = seq { for i in 1 .. 10 -> i*i }
let truncatedSeq = Seq.truncate 5 mySeq
let takenSeq = Seq.take 5 mySeq

let truncatedSeq2 = Seq.truncate 20 mySeq
let takenSeq2 = Seq.take 20 mySeq

let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""

// Up to this point, the sequences are not evaluated.
// The following code causes the sequences to be evaluated.
truncatedSeq |> printSeq
truncatedSeq2 |> printSeq
takenSeq |> printSeq
// The following line produces a run-time error (in printSeq):
takenSeq2 |> printSeq
```

**1 4 9 16 25**
**1 4 9 16 25 36 49 64 81 100**
**1 4 9 16 25**
**1 4 9 16 25 36 49 64 81 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

