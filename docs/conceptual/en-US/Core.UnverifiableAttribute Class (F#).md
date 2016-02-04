# Core.UnverifiableAttribute Class (F#)

This attribute is used to tag values whose use will result in the generation of unverifiable code. These values are inevitably marked **inline** to ensure that the unverifiable constructs are not present in the actual code for the F# library, but are rather copied to the source code of the caller.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.Method ||| AttributeTargets.Property, AllowMultiple = false)>]
[<Sealed>]
type UnverifiableAttribute =
class
new UnverifiableAttribute : unit -> UnverifiableAttribute
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, **Unverifiable**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/f2a9ec1c-74b0-4d7d-a5ed-8ec1c13cccae)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

