# OperatorIntrinsics.GetStringSlice Function (F#)

Gets a slice from a string.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
GetStringSlice : string -> int option -> int option -> string

// Usage:
GetStringSlice source start finish
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The source string.


*start*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The index of the first character of the slice.


*finish*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)[option](http://msdn.microsoft.com/en-us/library/e5b1450c-2779-4c65-ae28-e7f740c37871)


The index of the last character of the slice.



**The substring from the given indices.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable, Portable




## See Also
[Operators.OperatorIntrinsics Module &#40;F&#35;&#41;](Operators.OperatorIntrinsics+Module+%28FSharp%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28FSharp%29.md)

