# Core.StructuralComparisonAttribute Class (F#)

Adding this attribute to a record, union, exception, or structure type confirms the automatic generation of implementations for **T:System.IComparable** for the type.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
[<Sealed>]
type StructuralComparisonAttribute =
class
new StructuralComparisonAttribute : unit -> StructuralComparisonAttribute
end
```

## CAPS_REMARKS_MD
You can also use the short form of the name, **StructuralComparison**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/a50dbe83-811a-486f-987e-236e4fd18cda)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

