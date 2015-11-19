# CompilerServices.TypeProviderAssemblyAttribute Class (F#)

Places an attribute on a runtime assembly to indicate that a corresponding design-time assembly contains a type provider. The runtime and the designer assembly may be the same.

**Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AttributeUsage(1, AllowMultiple = false)>]
type [TypeProviderAssemblyAttribute](http://msdn.microsoft.com/en-us/library/4a6027e2-f894-49d1-bff1-f96e82f0a8f0) =
class
new TypeProviderAssemblyAttribute : string -> TypeProviderAssemblyAttribute
new TypeProviderAssemblyAttribute : unit -> TypeProviderAssemblyAttribute
member this.AssemblyName : string
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
You can also use the short form of the name, **TypeProviderAssembly**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/ae7daf6f-4c71-4032-9046-ffceeb8f408a)|Creates an instance of the attribute|

## Instance Members


|Member|Description|
|------|-----------|
|[AssemblyName](http://msdn.microsoft.com/en-us/library/0a6c14d2-8566-4796-9f96-a8d6dc541016) : [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)|Specifies the name of the design-time assembly for this type provider.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices+Namespace+28%F%2329%.md)

