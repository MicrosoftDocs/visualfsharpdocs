# List.map2<'T1,'T2,'U> Function (F#)

Creates a new collection whose elements are the results of applying the given function to the corresponding elements of the two collections pairwise.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.map2 : ('T1 -> 'T2 -> 'U) -> 'T1 list -> 'T2 list -> 'U list

// Usage:
List.map2 mapping list1 list2
```

#### CAPS_PARAMETERS_MD
*mapping*
Type: **'T1 -&gt; 'T2 -&gt; 'U**


The function to transform pairs of elements from the input lists.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**The list of resulting elements.**
## CAPS_REMARKS_MD
This function is named **Map2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.map2.**
```

    let list1 = [1; 2; 3]
    let list2 = [4; 5; 6]
    let sumList = List.map2 (fun x y -> x + y) list1 list2
    printfn "%A" sumList
```

**Output**
**[5; 7; 9]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

