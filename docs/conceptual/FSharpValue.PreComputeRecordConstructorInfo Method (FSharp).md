# FSharpValue.PreComputeRecordConstructorInfo Method (F#)

Gets a **T:System.Reflection.ConstructorInfo** object for a record type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member PreComputeRecordConstructorInfo : Type * ?BindingFlags -> ConstructorInfo
static member PreComputeRecordConstructorInfo : Type * ?bool -> ConstructorInfo

// Usage:
FSharpValue.PreComputeRecordConstructorInfo (recordType)
FSharpValue.PreComputeRecordConstructorInfo (recordType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeRecordConstructorInfo (recordType, allowAccessToPrivateRepresentation = false)
```

#### Parameters
*recordType*
Type: **T:System.Type**


The record type.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**A T:System.Reflection.ConstructorInfo object for the given record type.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28FSharp%29.md)

