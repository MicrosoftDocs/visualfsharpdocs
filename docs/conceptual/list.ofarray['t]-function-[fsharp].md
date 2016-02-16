# List.ofArray<'T> Function (F#)

Creates a list from the given array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.ofArray : 'T [] -> 'T list

// Usage:
List.ofArray array

```



#### Parameters
*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The list of elements from the array.**
## Remarks
This function is named **OfArray** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use List.ofArray.**
[!code-fsharp[Main](snippets/fslists/snippet59.fs)]
**F# Interactive Output**
**val list1 : int list = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

