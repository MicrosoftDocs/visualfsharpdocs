# Core.CompilationRepresentationAttribute Class (F#)

This attribute is used to adjust the runtime representation for a type. For example, it may be used to note that the **null** representation may be used for a type. This affects how some constructs are compiled.

**Namespace/Module Path**: Microsoft.FSharp.Core

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.All, AllowMultiple = false)>]
[<Sealed>]
type CompilationRepresentationAttribute =
class
new CompilationRepresentationAttribute : CompilationRepresentationFlags -> CompilationRepresentationAttribute
member this.Flags :  CompilationRepresentationFlags
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, CompilationRepresentation.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/d7a5352e-f198-40c3-a999-4d4782fa2ee8)|Creates an instance of the attribute|

## Instance Members


|Member|Description|
|------|-----------|
|[Flags](http://msdn.microsoft.com/en-us/library/9ac4bd35-a1d8-4053-b9c6-6a4b16c30729)|Indicates one or more adjustments to the compiled representation of an F# type or member|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

