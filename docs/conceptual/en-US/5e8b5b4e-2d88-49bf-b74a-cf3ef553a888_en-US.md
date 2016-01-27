# Set.ofSeq<'T> Function (F#)

Creates a new collection from the given enumerable object.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Set

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Set.ofSeq : seq<'T> -> Set<'T> (requires comparison)

// Usage:
Set.ofSeq elements
```

#### CAPS_PARAMETERS_MD
*elements*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**The set containing elements.**
## CAPS_REMARKS_MD
This function is named **OfSeq** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates how to create a set from a sequence by using Set.ofSeq.**
```

    let data = "The quick brown fox jumps over the lazy dog" 
    let set = 
        data.ToCharArray()
        |> Set.ofSeq
    for c in set do 
        printf "'%c' " c 
    printfn ""
```

**' ' 'T' 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' 'q' 'r' 's' 't' 'u' 'v' 'w' 'x' 'y' 'z'**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

