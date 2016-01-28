# List.forall2<'T1,'T2> Function (F#)

Tests if all corresponding elements of the collection satisfy the given predicate pairwise.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.forall2 : ('T1 -> 'T2 -> bool) -> 'T1 list -> 'T2 list -> bool

// Usage:
List.forall2 predicate list1 list2
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T1 -&gt; 'T2 -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**exceptions tag is not supported!!!!**
**true if all of the pairs of elements satisfy the predicate. Otherwise, returns false.**
## CAPS_REMARKS_MD
The predicate is applied to matching elements in the two collections. If any application returns **false** then the overall result is **false** and no further elements are tested. Otherwise, if one collection is longer than the other then the **T:System.ArgumentException** exception is raised. Otherwise, **true** is returned.

This function is named **ForAll2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.forall2.**
```

let listEqual list1 list2 = List.forall2 (fun elem1 elem2 -> elem1 = elem2) list1 list2
printfn "%b" (listEqual [0; 1; 2] [0; 1; 2])
printfn "%b" (listEqual [0; 0; 0] [0; 1; 0])
```

**Output**
**true**
**false**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

