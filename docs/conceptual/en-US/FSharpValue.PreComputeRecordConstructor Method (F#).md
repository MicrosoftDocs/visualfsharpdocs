# FSharpValue.PreComputeRecordConstructor Method (F#)

Generates a function for constructing a record value.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member PreComputeRecordConstructor : Type * ?BindingFlags -> obj [] -> obj
static member PreComputeRecordConstructor : Type * ?bool -> obj [] -> obj
// Usage:
FSharpValue.PreComputeRecordConstructor (recordType)
FSharpValue.PreComputeRecordConstructor (recordType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeRecordConstructor (recordType, allowAccessToPrivateRepresentation = false)
```

#### CAPS_PARAMETERS_MD
*recordType*
Type: **T:System.Type**


The type of record to construct.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**A function to construct records of the given type.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28F%23%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

