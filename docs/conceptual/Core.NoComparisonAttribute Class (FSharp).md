# Core.NoComparisonAttribute Class (F#)

Adding this attribute to a type indicates it is a type where comparison is an abnormal operation. This means that the type does not satisfy the F# comparison constraint. Within the bounds of the F# type system, this helps ensure that the F# generic comparison function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Interface ||| AttributeTargets.Delegate ||| AttributeTargets.Struct ||| AttributeTargets.Enum, AllowMultiple = false)>]
[<Sealed>]
type NoComparisonAttribute =
class
new NoComparisonAttribute : unit -> NoComparisonAttribute
end
```

## Remarks
You can also use the short form of the name, **NoComparison**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/fbd91a3d-82a0-41df-9940-df3dee515714)|Creates an instance of the attribute.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

