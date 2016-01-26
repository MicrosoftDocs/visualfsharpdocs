# FSharpType.GetFunctionElements Method (F#)

Gets the domain and range types from an F# function type or from the runtime type of a closure implementing an F# type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member GetFunctionElements : Type -> Type * Type

// Usage:
FSharpType.GetFunctionElements (functionType)
```

#### CAPS_PARAMETERS_MD
*functionType*
Type: **T:System.Type**


The input function type.



**A tuple of the domain and range types of the input function.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpType Class &#40;F&#35;&#41;](Reflection.FSharpType+Class+%28F%23%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

