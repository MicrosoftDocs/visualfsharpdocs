# Core.CompiledNameAttribute Class (F#)

Adding this attribute to a value or function definition in an F# module changes the name used for the value in compiled Common Language Infrastructure (CLI) code.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
[<AttributeUsage(AttributeTargets.Method ||| AttributeTargets.Class ||| AttributeTargets.Field ||| AttributeTargets.Interface ||| AttributeTargets.Struct ||| AttributeTargets.Delegate ||| AttributeTargets.Enum ||| AttributeTargets.Property, AllowMultiple = false)>]
[<Sealed>]
type CompiledNameAttribute =
class
new CompiledNameAttribute : string -> CompiledNameAttribute
member this.CompiledName :  string
end
```

## CAPS_REMARKS_MD
You can also use the short form of the name, **CompiledName**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/3806f495-1fbb-4d76-a2d2-1b605381d305)|Creates an instance of the attribute.|

## Instance Members


|Member|Description|
|------|-----------|
|[CompiledName](http://msdn.microsoft.com/en-us/library/6071b806-c46d-4680-b3ce-ed7e0251b6b4)|The name of the value as it appears in compiled code.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

