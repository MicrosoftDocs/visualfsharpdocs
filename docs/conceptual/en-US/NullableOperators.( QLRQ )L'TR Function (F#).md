# NullableOperators.( ?<>? )<'T> Function (F#)

The **&lt;&gt;** operator where a nullable value appears on both left and right sides.

**Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( ?<>? ) : Nullable<'T> -> Nullable<'T> -> bool when 'T : equality and 'T : (new : unit ->  'T) and 'T : struct and 'T :> ValueType

// Usage:
nullableValue1 ?<>? nullableValue2
```

#### CAPS_PARAMETERS_MD
*nullableValue1*
Type: **T:System.Nullable&#96;1**&lt;'T&gt;


The first input value, as a nullable value.


*nullableValue2*
Type: **T:System.Nullable&#96;1**&lt;'T&gt;


The second input value, as a nullable value.




## Return Value
True if the two input values are not numerically equal.


## CAPS_REMARKS_MD
If either of the values is null, the result is **false**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.NullableOperators Module &#40;F&#35;&#41;](Linq.NullableOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28F%23%29.md)

