# Core.ExperimentalAttribute Class (F#)

This attribute is used to tag values that are part of an experimental library feature.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.All, AllowMultiple = false)>]
[<Sealed>]
type ExperimentalAttribute =
class
new ExperimentalAttribute : string -> ExperimentalAttribute
member this.Message :  string
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, **Experimental**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/a5e39013-4d7d-43fa-ba96-74c9f4d7b3f7)|Creates an instance of the attribute|

## Instance Members


|Member|Description|
|------|-----------|
|[Message](http://msdn.microsoft.com/en-us/library/b804ac7a-5d25-440e-9038-b80634d0f1ef)|Indicates the warning message to be emitted when F# source code uses this construct.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

