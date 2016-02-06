# Array.find<'T> Function (F#)

Returns the first element for which the given function returns **true**. Raise **T:System.Collections.Generic.KeyNotFoundException** if no such element exists.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.find : ('T -> bool) -> 'T [] -> 'T

// Usage:
Array.find predicate array
```

#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**exceptions tag is not supported!!!!**
**The first element for which predicate returns true.**
## Remarks
This function is named **Find** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Array.find and Array.findIndex to identify the first integer greater than 1 that is both a square and a cube.**
[!code-fsharp[Main](snippets/fsarrays/snippet25.fs)]
**The first element that is both a square and a cube is 64 and its index is 62.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

[Array.findIndex&#60;'T&#62; Function &#40;F&#35;&#41;](Array.findIndex%3C%27T%3E+Function+%28FSharp%29.md)

