# Array.exists2<'T1,'T2> Function (F#)

Tests if any pair of corresponding elements of the arrays satisfies the given predicate.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.exists2 : ('T1 -> 'T2 -> bool) -> 'T1 [] -> 'T2 [] -> bool

// Usage:
Array.exists2 predicate array1 array2
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T1 -&gt; 'T2 -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.



**true if any result from predicate is true. Otherwise, false.**
## CAPS_REMARKS_MD
The predicate is applied to matching elements in the two collections up to the lesser of the two lengths of the collections. If any application returns **true** then the overall result is **true** and no further elements are tested. Otherwise, if one collection is longer than the other then the **T:System.ArgumentException** exception is raised. Otherwise, **false** is returned.

This function is named **Exists2** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.

**The following example shows the use Array.exists2 to test whether two arrays have at least one equal element.**
```

let haveEqualElement = Array.exists2 (fun elem1 elem2 -> elem1 = elem2)
printfn "%A" (haveEqualElement [| 1; 2; 3 |] [| 3; 2; 1|])
```

**true**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

