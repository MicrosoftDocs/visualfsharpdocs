# Reflection.UnionCaseInfo Class (F#)

Represents a case of a discriminated union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
[<Sealed>]
type UnionCaseInfo =
class
member this.GetCustomAttributes : Type -> obj []
member this.GetCustomAttributes : unit -> obj []  member this.GetCustomAttributesData : unit -> IList<CustomAttributeData>
member this.GetFields : unit -> PropertyInfo []
member this.DeclaringType :  Type
member this.Name :  string
member this.Tag :  int
end
```

## CAPS_REMARKS_MD

## Instance Members


|Member|Description|
|------|-----------|
|[DeclaringType](http://msdn.microsoft.com/en-us/library/c96263e9-4b74-4e3b-bda1-23831f3527a6)|The type in which the case occurs.|
|[GetCustomAttributes](http://msdn.microsoft.com/en-us/library/ce087bae-8d3b-4d64-b9a5-0b37e6af2b64)|Returns the custom attributes associated with the case matching the given attribute type.|
|[GetCustomAttributesData](http://msdn.microsoft.com/en-us/library/8d3748a9-50fd-4bf0-bcfd-d7481658102c)|Returns the custom attributes data associated with the case.|
|[GetFields](http://msdn.microsoft.com/en-us/library/4536b002-c238-4bb4-9bb0-39caaaa76c96)|The fields associated with the case, represented by a **T:System.Reflection.PropertyInfo**.|
|[Name](http://msdn.microsoft.com/en-us/library/cf541d4b-18d6-4d87-ae3b-10512c9b2252)|The name of the case.|
|[Tag](http://msdn.microsoft.com/en-us/library/d3bafe1e-8dd4-40c8-9d72-43ebcf9e1e45)|The integer tag for the case.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

