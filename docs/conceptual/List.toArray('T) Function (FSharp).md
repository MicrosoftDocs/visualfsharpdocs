# List.toArray<'T> Function (F#)

Creates an array from the given list.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
List.toArray : 'T list -> 'T []

// Usage:
List.toArray list
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The array containing the elements of the list.**
## Remarks
This function is named **ToArray** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use List.toArray.**
[!code-fsharp[Main](snippets/fslists/snippet64.fs)]
**Output**
**[|-10; -2; 1; 3|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

