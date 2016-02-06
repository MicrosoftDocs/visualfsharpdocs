# Set.difference<'T> Function (F#)

Returns a new set with the elements of the second set removed from the first.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Set

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Set.difference : Set<'T> -> Set<'T> -> Set<'T> (requires comparison)

// Usage:
Set.difference set1 set2
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*set1*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The first input set.


*set2*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The set whose elements will be removed from **set1**.



**The set with the elements of set2 removed from set1.**
## Remarks
This function is named **Difference** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of the Set.difference function.**
[!code-fsharp[Main](snippets/fssets/snippet2.fs)]
**Output**
**Set.difference [2 .. 6] [1 .. 3] yields set [4; 5; 6]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

