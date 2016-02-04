# Core.VolatileFieldAttribute Class (F#)

Adding this attribute to an F# mutable binding causes the **volatile** prefix to be used for all accesses to the field.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.Field, AllowMultiple = false)>]
[<Sealed>]
type VolatileFieldAttribute =
class
new VolatileFieldAttribute : unit -> VolatileFieldAttribute
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, **VolatileField**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/de9cffb9-6a8a-4052-b47e-b7ef4fec46b5)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

