# Core.AbstractClassAttribute Class (F#)

Adding this attribute to class definition makes it abstract, which means it need not implement all its methods. Instances of abstract classes may not be constructed directly.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
[<Sealed>]
type AbstractClassAttribute =
class
new AbstractClassAttribute : unit -> AbstractClassAttribute
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, **AbstractClass**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/03ec8ff5-d154-49c4-b798-c062a4bfd892)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

