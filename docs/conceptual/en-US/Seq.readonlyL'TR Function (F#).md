# Seq.readonly<'T> Function (F#)

Creates a new sequence object that delegates to the given sequence object. This ensures the original sequence cannot be rediscovered and mutated by a type cast. For example, if given an array the returned sequence will return the elements of the array, but you cannot cast the returned sequence object to an array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.readonly : seq<'T> -> seq<'T>

// Usage:
Seq.readonly source
```

#### CAPS_PARAMETERS_MD
*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This function is named **ReadOnly** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code uses Seq.readonly to create an immutable view of a mutable array.**
```

type ArrayContainer(start, finish) =
    let internalArray = [| start .. finish |]
    member this.RangeSeq = Seq.readonly internalArray
    member this.RangeArray = internalArray

let newArray = new ArrayContainer(1, 10)
let rangeSeq = newArray.RangeSeq
let rangeArray = newArray.RangeArray
// These lines produce an error: 
//let myArray = rangeSeq :> int array
//myArray.[0] <- 0
// The following line does not produce an error. 
// It does not preserve encapsulation.
rangeArray.[0] <- 0
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

