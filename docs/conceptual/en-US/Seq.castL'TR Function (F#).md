# Seq.cast<'T> Function (F#)

Wraps a weakly typed **N:System.Collections** sequence as a typed sequence.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.cast : IEnumerable -> seq<'T>

// Usage:
Seq.cast source
```

#### CAPS_PARAMETERS_MD
*source*
Type: **T:System.Collections.IEnumerable**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
The use of this function usually requires a type annotation. An incorrect type annotation may result in runtime type errors. Individual **T:System.Collections.Generic.IEnumerator&#96;1** values generated from the returned sequence should not be accessed concurrently.

This function is named **Cast** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code demonstrates the use of Seq.cast to convert a weakly typed T:System.Collections.ArrayList, where the element type is just T:System.Object, into a sequence of int.**
```

open System
let mutable arrayList1 = new System.Collections.ArrayList(10)
for i in 1 .. 10 do arrayList1.Add(10) |> ignore
let seqCast : seq<int> = Seq.cast arrayList1
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

