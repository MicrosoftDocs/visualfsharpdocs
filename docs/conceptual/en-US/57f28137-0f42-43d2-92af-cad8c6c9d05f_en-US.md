# NullableOperators.( ?+? )<^T1,^T2,^T3> Function (F#)

The addition operator where a nullable value appears on both left and right sides.

**Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( ?+? ) : Nullable<^T1> -> Nullable<^T2> -> Nullable<^T3> when ^T1 with static member (+) and ^T1 : (new : unit ->  ^T1) and ^T1 : struct and ^T1 :> ValueType and ^T2 with static member (+) and ^T2 : (new : unit ->  ^T2) and ^T2 : struct and ^T2 :> ValueType and ^T3 : (new : unit ->  ^T3) and ^T3 : struct and ^T3 :> ValueType

// Usage:
nullableValue1 ?+? nullableValue2
```

#### CAPS_PARAMETERS_MD
*nullableValue1*
Type: **T:System.Nullable&#96;1**&lt;^T1&gt;


The first input value, as a nullable value.


*nullableValue2*
Type: **T:System.Nullable&#96;1**&lt;^T2&gt;


The second input value, as a nullable value.




## Return Value
The sum of the two input values, as a nullable value.


## CAPS_REMARKS_MD
If either of the values is null, the return value is null.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.NullableOperators Module &#40;F&#35;&#41;](Linq.NullableOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28F%23%29.md)

