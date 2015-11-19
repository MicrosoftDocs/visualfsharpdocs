# Core.FSharpTypeFunc Class (F#)

The .NET Framework type used to represent F# first-class type function values. This type is for use by compiled F# code.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AbstractClass>]
type FSharpTypeFunc =
class
new FSharpTypeFunc : unit -> FSharpTypeFunc
abstract this.Specialize : unit -> obj
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/4c7b22be-9988-4429-8a00-fa109cc92a5e)|Construct an instance of an F# first class type function value|

## Instance Members


|Member|Description|
|------|-----------|
|[Specialize](http://msdn.microsoft.com/en-us/library/f783f869-2202-429f-95c7-97dc074a688f)|Specialize the type function at a given type|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

