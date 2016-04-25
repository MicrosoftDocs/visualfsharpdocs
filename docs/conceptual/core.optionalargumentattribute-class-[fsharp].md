# Core.OptionalArgumentAttribute Class (F#)

This attribute is added automatically for all optional arguments.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




[<AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)>]
[<Sealed>]
type OptionalArgumentAttribute =
class
new OptionalArgumentAttribute : unit -> OptionalArgumentAttribute
end


```





## Remarks
You can apply this attribute to a parameter that is an option type to make it an optional parameter. This is the equivalent of applying a ? to the parameter name in the parameter list. Optional parameters should not be followed by non-optional parameters in the parameter list.

You can also use the short form of the name, **OptionalArgument**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/0ddc8248-933f-4cab-9e39-88c8cf864f9e)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

