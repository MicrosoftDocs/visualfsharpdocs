# Set.unionMany<'T> Function (F#)

Computes the union of a sequence of sets.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Set

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Set.unionMany : seq<Set<'T>> -> Set<'T> (requires comparison)

// Usage:
Set.unionMany sets


```



#### CAPS_PARAMETERS_MD
*sets*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;**[Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;&gt;**


The sequence of sets to union.



**The union of the input sets.**
## CAPS_REMARKS_MD
This function is named **UnionMany** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of the Set.unionMany function.**


```



    let seqOfSets =
        seq { for i in 2 .. 5 do yield Set.ofList [ i .. i .. 40 ] }  
    let setResult = Set.unionMany seqOfSets
    printfn "Numbers up to 40 that are multiples of numbers from 2 to 5:"
    Set.iter (fun elem -> printf "%d " elem) setResult



```



**Output**
**Numbers up to 40 that are multiples of numbers from 2 to 5:**
**2 3 4 5 6 8 9 10 12 14 15 16 18 20 21 22 24 25 26 27 28 30 32 33 34 35 36 38 39 40**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

