# Core.StructuredFormatDisplayAttribute Class (F#)

This attribute is used to mark how a type is displayed by default when using **%A**[printf](http://msdn.microsoft.com/en-us/library/ea074733-6b5d-498c-ac88-7e4e0f8ded25) formatting patterns and other two-dimensional text-based display layouts. In this version of F# the only valid values are of the form **PreText {PropertyName} PostText**. The property name indicates a property to evaluate and to display instead of the object itself.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Interface ||| AttributeTargets.Struct ||| AttributeTargets.Delegate ||| AttributeTargets.Enum, AllowMultiple = false)>]
[<Sealed>]
type StructuredFormatDisplayAttribute =
class
new StructuredFormatDisplayAttribute : string -> StructuredFormatDisplayAttribute
member this.Value :  string
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
You can also use the short form of the name, **StructuredFormatDisplay**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/d6578534-f7cd-40b7-9219-9b71fe35f270)|Creates an instance of the attribute|

## Instance Members


|Member|Description|
|------|-----------|
|[Value](http://msdn.microsoft.com/en-us/library/71375b98-a109-4697-937f-1d906d72842d)|Indicates the text to display by default when objects of this type are displayed using **%A**[printf](http://msdn.microsoft.com/en-us/library/ea074733-6b5d-498c-ac88-7e4e0f8ded25) formatting patterns and other two-dimensional text-based display layouts.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

