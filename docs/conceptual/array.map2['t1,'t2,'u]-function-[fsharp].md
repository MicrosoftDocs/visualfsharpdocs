# Array.map2<'T1,'T2,'U> Function (F#)

Builds a new collection whose elements are the results of applying the given function to the corresponding elements of the two collections pairwise. The two input arrays must have the same lengths, otherwise **T:System.ArgumentException** is raised.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array.map2 : ('T1 -> 'T2 -> 'U) -> 'T1 [] -> 'T2 [] -> 'U []

// Usage:
Array.map2 mapping array1 array2

```



#### Parameters
*mapping*
Type: **'T1 -&gt; 'T2 -&gt; 'U**


The function to transform the pairs of the input elements.


*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.



**exceptions tag is not supported!!!!**
**The array of transformed elements.**
## Remarks
This function is named **Map2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example shows the use of Array.map2.**
[!code-fsharp[Main](snippets/fsarrays/snippet52.fs)]
**Output**
**[|5; 7; 9|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

