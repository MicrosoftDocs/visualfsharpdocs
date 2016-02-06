# Set.iter<'T> Function (F#)

Applies the given function to each element of the set, in order according to the comparison function.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Set

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Set.iter : ('T -> unit) -> Set<'T> -> unit (requires comparison)

// Usage:
Set.iter action set
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*action*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to apply to each element.


*set*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The input set.




## Remarks
This function is named **Iterate** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

