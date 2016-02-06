# FSharpType.GetExceptionFields Method (F#)

Reads all the fields from an F# exception declaration, in declaration order.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member GetExceptionFields : Type * ?BindingFlags -> PropertyInfo []
static member GetExceptionFields : Type * ?bool -> PropertyInfo []

// Usage:
FSharpType.GetExceptionFields (exceptionType)
FSharpType.GetExceptionFields (exceptionType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpType.GetExceptionFields (exceptionType, allowAccessToPrivateRepresentation = false)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*exceptionType*
Type: **T:System.Type**


The exception type to read.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**An array containing the T:System.Reflection.PropertyInfo of each field in the exception.**
## Remarks
Assumes *exceptionType* is an exception representation type. If not, **T:System.ArgumentException** is raised.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Reflection.FSharpType Class &#40;F&#35;&#41;](Reflection.FSharpType+Class+%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28FSharp%29.md)

