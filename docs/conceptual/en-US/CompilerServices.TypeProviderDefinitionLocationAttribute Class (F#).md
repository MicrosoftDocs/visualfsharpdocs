# CompilerServices.TypeProviderDefinitionLocationAttribute Class (F#)

Specifies the source location of a type provider definition, for use in error messages.

**Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AttributeUsage(32767, AllowMultiple = false)>]
type [TypeProviderDefinitionLocationAttribute](http://msdn.microsoft.com/en-us/library/ca51668f-8f81-43b5-95d7-aeeeb342ffc7) =
class
new TypeProviderDefinitionLocationAttribute : unit -> TypeProviderDefinitionLocationAttribute
member this.Column : int with get, set
member this.FilePath : string with get, set
member this.Line : int with get, set
member this.FilePath : string with get, set
member this.Line  : int with get, set
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
You can also use the short form of the name, TypeProviderDefinitionLocation.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/72c8003d-a6af-461b-b9f7-06e8ef6305de)|Creates an instance of the attribute.|

## Instance Members


|Member|Description|
|------|-----------|
|[Column](http://msdn.microsoft.com/en-us/library/8837cd15-ec5c-4909-9e17-17dca74b7575) : [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)|Specifies the column of the type provider definition.|
|[FilePath](http://msdn.microsoft.com/en-us/library/a5de9b81-b6da-4ffd-bd3e-8c11208483f2) : [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)|Specifies the file and path of the type provider definition.|
|[Line](http://msdn.microsoft.com/en-us/library/39ce0b74-81d2-470d-8554-76dc07d66fd4) : [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)|Specifies the line number of the type provider definition.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices+Namespace+28%F%2329%.md)

