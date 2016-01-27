# Set.IsSubsetOf<'T> Method (F#)

Evaluates to **true** if all elements of the first set are in the second.

**Namespace/Module Path**: Microsoft.FSharp.Collections

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.IsSubsetOf : Set<'T> -> bool (requires comparison)

// Usage:
set.IsSubsetOf (otherSet)
```

#### CAPS_PARAMETERS_MD
*otherSet*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The set to test against.



**true if this set is a subset of otherSet. Otherwise, returns false.**
## CAPS_REMARKS_MD
**The following code illustrates the use of the IsSubsetOf method.**
```

    let set1 = Set.ofList [ 1 .. 6 ]
    let set2 = Set.ofList [ 1 .. 5 ]
    let set3 = Set.ofList [ 1 .. 6 ]
    let set4 = Set.ofList [ 5 .. 10 ]
    printfn "%A is a subset of %A: %b" set2 set1 (set2.IsSubsetOf set1)
    printfn "%A is a subset of %A: %b" set3 set1 (set3.IsSubsetOf set1) 
    printfn "%A is a subset of %A: %b" set4 set1 (set4.IsSubsetOf set1) 
```

**Output**
**set [1; 2; 3; 4; 5] is a subset of set [1; 2; 3; 4; 5; 6]: trueset [1; 2; 3; 4; 5; 6] is a subset of set [1; 2; 3; 4; 5; 6]: trueset [5; 6; 7; 8; 9; 10] is a subset of set [1; 2; 3; 4; 5; 6]: true**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set&#60;'T&#62; Class &#40;F&#35;&#41;](Collections.Set+%27T+Class+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

