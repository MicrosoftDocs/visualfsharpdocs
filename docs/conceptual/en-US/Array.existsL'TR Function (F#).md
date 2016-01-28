# Array.exists<'T> Function (F#)

Tests if any element of the array satisfies the given predicate.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.exists : ('T -> bool) -> 'T [] -> bool

// Usage:
Array.exists predicate array
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**true if any result from predicate is true. Otherwise, false.**
## CAPS_REMARKS_MD
The predicate is applied to the elements of the input array. If any application returns **true** then the overall result is **true** and no further elements are tested.

This function is named **Exists** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates how to test the elements of an array by using Array.exists.**
```

let allNegative = Array.exists (fun elem -> abs (elem) = elem) >> not
printfn "%A" (allNegative [| -1; -2; -3 |])
printfn "%A" (allNegative [| -10; -1; 5 |])
printfn "%A" (allNegative [| 0 |])
```

**true**
**false**
**false**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

