# Seq.distinct<'T> Function (F#)

Returns a sequence that contains no duplicate entries according to generic hash and equality comparisons on the entries. If an element occurs multiple times in the sequence then the later occurrences are discarded.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.distinct : seq<'T> -> seq<'T> (requires equality)

// Usage:
Seq.distinct source
```

#### CAPS_PARAMETERS_MD
*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This function is named **Distinct** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.distinct. The example generates the binary representation of a number as a sequence. It then determines that the only unique numbers are 0 and 1.**
```

let binary n =
    let rec generateBinary n =
        if (n / 2 = 0) then [n]
        else (n % 2) :: generateBinary (n / 2)
    generateBinary n |> List.rev |> Seq.ofList

printfn "%A" (binary 1024)

let resultSequence = Seq.distinct (binary 1024)
printfn "%A" resultSequence
```

**[1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0]**
**seq [1; 0]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

