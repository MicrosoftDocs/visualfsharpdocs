# OperatorIntrinsics.SetArraySlice2DFixed1 Function (F#)

Sets a vector slice of a 2D array. The index of the first dimension is fixed.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
SetArraySlice2DFixed1 : 'T [,] -> int -> int option -> int option -> 'T [] -> unit

// Usage:
SetArraySlice2DFixed1 target index1 start2 finish2 source

```



#### Parameters
*target*
Type: **'T**[[,]](http://msdn.microsoft.com/en-us/library/077252f3-e6ce-441c-9d5b-a6030eaef7cd)


The target array.


*index1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The start index of the first dimension.


*start2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The start index of the second dimension.


*finish2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The end index of the second dimension.


*source*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/077252f3-e6ce-441c-9d5b-a6030eaef7cd)


The source array.




## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Arrays &#40;F&#35;&#41;](Arrays-%28FSharp%29.md)

[Operators.OperatorIntrinsics Module &#40;F&#35;&#41;](Operators.OperatorIntrinsics-Module-%28FSharp%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%28FSharp%29.md)

