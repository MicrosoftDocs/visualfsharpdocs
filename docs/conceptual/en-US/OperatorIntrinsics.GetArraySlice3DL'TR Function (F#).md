# OperatorIntrinsics.GetArraySlice3D<'T> Function (F#)

Gets a slice of an array.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
GetArraySlice3D : 'T [,,] -> int option -> int option -> int option -> int option -> int option -> int option -> 'T [,,]

// Usage:
GetArraySlice3D source start1 finish1 start2 finish2 start3 finish3


```



#### CAPS_PARAMETERS_MD
*source*
Type: **'T**[[,,]](http://msdn.microsoft.com/en-us/library/b4e5b35b-dc83-4b50-94aa-85fcf3ccb2b0)


The source array.


*start1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The start index of the first dimension.


*finish1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The end index of the first dimension.


*start2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The start index of the second dimension.


*finish2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The end index of the second dimension.


*start3*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The start index of the third dimension.


*finish3*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The end index of the third dimension.



**The three dimensional sub array from the given indices.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable, Portable




## See Also
[Operators.OperatorIntrinsics Module &#40;F&#35;&#41;](Operators.OperatorIntrinsics+Module+%28F%23%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

