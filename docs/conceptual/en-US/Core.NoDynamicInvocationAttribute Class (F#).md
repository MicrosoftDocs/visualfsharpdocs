# Core.NoDynamicInvocationAttribute Class (F#)

This attribute is used to tag values that may not be dynamically invoked at runtime. This is typically added to inline functions whose implementations include unverifiable code. It causes the method body emitted for the inline function to raise an exception if dynamically invoked, rather than including the unverifiable code in the generated assembly.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AttributeUsage(AttributeTargets.Method ||| AttributeTargets.Property, AllowMultiple = false)>]
[<Sealed>]
type NoDynamicInvocationAttribute =
class
new NoDynamicInvocationAttribute : unit -> NoDynamicInvocationAttribute
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
You can also use the short form of the name, **NoDynamicInvocation**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/9ac6fef9-028d-47f7-aef6-86ee3a13298d)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

