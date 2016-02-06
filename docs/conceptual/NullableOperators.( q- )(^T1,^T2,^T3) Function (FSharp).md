# NullableOperators.( ?- )<^T1,^T2,^T3> Function (F#)

The subtraction operator where a nullable value appears on the left.

**Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( ?- ) : Nullable<^T1> -> ^T2 -> Nullable<^T3> when ^T1 with static member (-) and ^T1 : (new : unit ->  ^T1) and ^T1 : struct and ^T1 :> ValueType and ^T2 with static member (-) and ^T3 : (new : unit ->  ^T3) and ^T3 : struct and ^T3 :> ValueType

// Usage:
nullableValue ?- value
```

#### Parameters
*nullableValue*
Type: **T:System.Nullable&#96;1**&lt;^T1&gt;


The first input value, as a nullable value.


*value*
Type: ^T2


The second input value.




## Return Value
The result of the subtraction, as a nullable value.


## Remarks
If the first value is null, then the result is null, as a nullable value.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.02.0, 4.0, Portable




## See Also
[Linq.NullableOperators Module &#40;F&#35;&#41;](Linq.NullableOperators+Module+%28FSharp%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28FSharp%29.md)

