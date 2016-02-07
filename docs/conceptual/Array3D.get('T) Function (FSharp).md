# Array3D.get<'T> Function (F#)

Fetches an element from a 3D array.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array3D

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array3D.get : 'T [,,] -> int -> int -> int -> 'T

// Usage:
Array3D.get array index1 index2 index3

```



#### Parameters
*array*
Type: **'T**[[,,]](http://msdn.microsoft.com/en-us/library/b4e5b35b-dc83-4b50-94aa-85fcf3ccb2b0)


The input array.


*index1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the first dimension.


*index2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the second dimension.


*index3*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the third dimension.



**The value at the given index.**
## Remarks
You can also use the syntax **array.[index1,index2,index3]**.

This function is named **Get** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Collections.Array3D Module &#40;F&#35;&#41;](Collections.Array3D+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

