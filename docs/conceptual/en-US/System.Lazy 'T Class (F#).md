# System.Lazy<'T> Class (F#)

Encapsulates a lazily computed value.

**Namespace/Module Path**: System

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
[<AllowNullLiteral>]
type Lazy<'T> =
class
member this.IsValueCreated :  bool
member this.Value :  'T
end
```

## CAPS_REMARKS_MD
This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, **T:System.Lazy&#96;1**.


## Instance Members


|Member|Description|
|------|-----------|
|[IsValueCreated](http://msdn.microsoft.com/en-us/library/1e192d02-b3ad-4903-9d5b-e6af1d884c70)|Is true if the value is ready to be accessed.|
|[Value](http://msdn.microsoft.com/en-us/library/3ce0a337-a960-4464-bc19-7e70bf37d4db)|The value contained in the Lazy.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[System Namespace &#40;F&#35;&#41;](System+Namespace+%28F%23%29.md)

