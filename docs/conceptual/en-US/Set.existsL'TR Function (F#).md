# Set.exists<'T> Function (F#)

Tests if any element of the collection satisfies the given predicate. If the input function is *predicate* and the elements are **i0...iN**, then this function computes **p i0 or ... or p iN**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Set

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Set.exists : ('T -> bool) -> Set<'T> -> bool (requires comparison)

// Usage:
Set.exists predicate set
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test set elements.


*set*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The input set.



**True if any element of set satisfies predicate.**
## CAPS_REMARKS_MD
This function is named **Exists** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

