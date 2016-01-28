# Seq.append<'T> Function (F#)

Wraps the two given enumerations as a single concatenated enumeration.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.append : seq<'T> -> seq<'T> -> seq<'T>

// Usage:
Seq.append source1 source2
```

#### CAPS_PARAMETERS_MD
*source1*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The first sequence.


*source2*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The second sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
The returned sequence may be passed between threads safely. However, individual **T:System.Collections.Generic.IEnumerator&#96;1** values generated from the returned sequence should not be accessed concurrently.

This function is named **Append** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example hows how to use Seq.append.**
```

    printfn "%A" (Seq.append [| 1; 2; 3|] [ 4; 5; 6])
```

**Output**
**seq [1; 2; 3; 4; ...]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

