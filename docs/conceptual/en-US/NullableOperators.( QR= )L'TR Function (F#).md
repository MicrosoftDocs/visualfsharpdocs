# NullableOperators.( ?>= )<'T> Function (F#)

The **&gt;=** operator where a nullable value appears on the left.

**Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( ?>= ) : Nullable<'T> -> 'T -> bool when 'T : (IComparable) and 'T : (new : unit ->  'T) and 'T : struct and 'T :> ValueType

// Usage:
nullableValue ?>= value
```

#### CAPS_PARAMETERS_MD
*nullableValue*
Type: **T:System.Nullable&#96;1**&lt;'T&gt;


The first input value, as a nullable value.


*value*
Type: 'T


The second input value.




## Return Value
**true** if the first value is greater than or equal to the second.


## CAPS_REMARKS_MD
If the first input value is null, then the result is **false**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.NullableOperators Module &#40;F&#35;&#41;](Linq.NullableOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28F%23%29.md)

