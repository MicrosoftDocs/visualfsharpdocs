# Core.AllowNullLiteralAttribute Class (F#)

Adding this attribute to a type lets the **null** literal be used for the type within F# code. This attribute may only be added to F#-defined class or interface types.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
[<Sealed>]
type AllowNullLiteralAttribute =
class
new AllowNullLiteralAttribute : unit -> AllowNullLiteralAttribute
end


```





## Remarks
You can also use the short form of the name, **AllowNullLiteral**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/41a113fc-1d45-4a72-8249-f440668b44f3)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

