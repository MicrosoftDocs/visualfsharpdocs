# Core.AutoSerializableAttribute Class (F#)

Adding this attribute to a type with value **false** disables the behavior where F# makes the type serializable by default.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
[<Sealed>]
type AutoSerializableAttribute =
class
new AutoSerializableAttribute : bool -> AutoSerializableAttribute
member this.Value :  bool
end

```



## Remarks
You can also use the short form of the name, **AutoSerializable**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/e65517ad-2c75-45c2-8fa3-e5bde1d4d11c)|Creates an instance of the attribute.|

## Instance Members


|Member|Description|
|------|-----------|
|[Value](http://msdn.microsoft.com/en-us/library/d19bbae4-b44e-4f87-83cf-a03ecb37ad92)|The value of the attribute, indicating whether the type is automatically marked serializable or not.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

