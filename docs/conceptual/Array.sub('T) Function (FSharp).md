# Array.sub<'T> Function (F#)

Builds a new array that contains the given subrange specified by starting index and length.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.sub : 'T [] -> int -> int -> 'T []

// Usage:
Array.sub array startIndex count
```

#### Parameters
*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.


*startIndex*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index of the first element of the subarray.


*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the subarray.



**The created subarray.**
## Remarks
This function is named **GetSubArray** in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.

**The following example shows the use of Array.sub to specify a subarray. The output shows that the subarray starts at a zero-based index of 5 and has 10 elements.**
[!code-fsharp[Main](snippets/fsarrays/snippet12.fs)]
**[|5; 6; 7; 8; 9; 10; 11; 12; 13; 14|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

