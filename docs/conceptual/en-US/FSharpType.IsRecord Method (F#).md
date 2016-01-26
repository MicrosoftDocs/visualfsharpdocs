# FSharpType.IsRecord Method (F#)

Returns **true** if the specified type is a representation of an F# record type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member IsRecord : Type * ?BindingFlags -> bool
static member IsRecord : Type * ?bool -> bool

// Usage:
FSharpType.IsRecord (typ)
FSharpType.IsRecord (typ, bindingFlags = bindingFlags)
open FSharpReflectionExtensions
FSharpType.IsRecord (type, allowAccessToPrivateRepresentation = false)
```

#### CAPS_PARAMETERS_MD
*typ*
Type: **T:System.Type**


The type to check.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**Returns true if the type check succeeds.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpType Class &#40;F&#35;&#41;](Reflection.FSharpType+Class+%28F%23%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

