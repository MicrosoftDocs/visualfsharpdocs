# Array3D.mapi<'T,'U> Function (F#)

Builds a new array whose elements are the results of applying the given function to each of the elements of the array. The integer indices passed to the function indicates the element being transformed.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array3D

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array3D.mapi : (int -> int -> int -> 'T -> 'U) -> 'T [,,] -> 'U [,,]

// Usage:
Array3D.mapi mapping array

```



#### Parameters
*mapping*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T -&gt; 'U**


The function to transform the elements at each index in the array.


*array*
Type: **'T**[[,,]](http://msdn.microsoft.com/en-us/library/b4e5b35b-dc83-4b50-94aa-85fcf3ccb2b0)


The input array.



**The array created from the transformed elements.**
## Remarks
For non-zero-based arrays the basing on an input array will be propagated to the output array.

This function is named **MapIndexed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array3D Module &#40;F&#35;&#41;](Collections.Array3D-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

