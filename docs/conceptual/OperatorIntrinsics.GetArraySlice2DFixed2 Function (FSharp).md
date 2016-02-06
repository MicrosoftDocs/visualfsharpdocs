# OperatorIntrinsics.GetArraySlice2DFixed2 Function (F#)

Gets a vector slice of a 2D array. The index of the second dimension is fixed.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
GetArraySlice2DFixed2 : 'T [,] -> int option -> int option -> int -> 'T []

// Usage:
GetArraySlice2DFixed2 source start1 finish1 index2
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: **'T**[[,]](http://msdn.microsoft.com/en-us/library/077252f3-e6ce-441c-9d5b-a6030eaef7cd)


The source array.


*start1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The start index of the first dimension.


*finish1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The end index of the first dimension.


*index2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The fixed index of the second dimension.



**The sub array from the input indices.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Arrays (F#)](http://msdn.microsoft.com/en-us/library/70ad71f0-f4bf-42d7-b1a9-44a2f4bd2c6f)

[Operators.OperatorIntrinsics Module &#40;F&#35;&#41;](Operators.OperatorIntrinsics+Module+%28FSharp%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28FSharp%29.md)

