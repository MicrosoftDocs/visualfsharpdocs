# OperatorIntrinsics.RangeGeneric<'T> Function (F#)

Generates a range of values using the given zero, add, start, step and stop values.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
RangeGeneric : 'T -> ('T -> 'T -> 'T) -> 'T -> 'T -> seq<'T>

// Usage:
RangeGeneric one add start stop
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*one*
Type: **'T**


The value representing 1 for the type parameter.


*add*
Type: **'T -&gt; 'T -&gt; 'T**


A function that performs addition to the type parameter.


*start*
Type: **'T**


The start of the range.


*stop*
Type: **'T**


The end of the range.



**An enumerable sequence representing a range of values.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is for use by compiled F# code and should not be used directly.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable, Portable




## See Also
[Operators.OperatorIntrinsics Module &#40;F&#35;&#41;](Operators.OperatorIntrinsics+Module+28%F%2329%.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+28%F%2329%.md)

