# Core.SealedAttribute Class (F#)

Adding this attribute to class definition makes it sealed, which means it may not be extended or implemented.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
type SealedAttribute =
class
new SealedAttribute : bool -> SealedAttribute
new SealedAttribute : unit -> SealedAttribute
member this.Value :  bool
end

```



## Remarks
You can also use the short form of the name, **Sealed**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/66f6b40c-09b0-492d-8ed8-167263d1778a)|Creates an instance of the attribute|

## Instance Members


|Member|Description|
|------|-----------|
|[Value](http://msdn.microsoft.com/en-us/library/d80cc203-6a09-441a-812e-e78d17e121f9)|The value of the attribute, indicating whether the type is sealed or not.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%28FSharp%29.md)

