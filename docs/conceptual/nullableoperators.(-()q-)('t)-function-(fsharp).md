# NullableOperators.( <>? )<'T> Function (F#)

The **&lt;&gt;** operator where a nullable value appears on the right.

**Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
( <>? ) : 'T -> Nullable<'T> -> bool when 'T : (IComparable) and 'T : (new : unit ->  'T) and 'T : struct and 'T :> ValueType

// Usage:
value <>? nullableValue

```



#### Parameters
*value*
Type: **T:System.Nullable&#96;1**&lt;'T&gt;


The first input value.


*nullableValue*
Type: 'T


The second input value, as a nullable value.




## Return Value
**true** if the two input values are not numerically equal; otherwise, **false**.


## Remarks
If the second value is null, the result is **false**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.NullableOperators Module &#40;F&#35;&#41;](Linq.NullableOperators-Module-%28FSharp%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%28FSharp%29.md)

