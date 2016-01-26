# FSharpValue.PreComputeUnionTagMemberInfo Method (F#)

Generates a property or static method for reading an integer representing the case tag of a union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member PreComputeUnionTagMemberInfo : Type * ?BindingFlags -> MemberInfo
static member PreComputeUnionTagMemberInfo : Type * ?bool -> MemberInfo

// Usage:
FSharpValue.PreComputeUnionTagMemberInfo (unionType)
FSharpValue.PreComputeUnionTagMemberInfo (unionType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeUnionTagMemberInfo (unionType, allowAccessToPrivateRepresentation = false)
```

#### CAPS_PARAMETERS_MD
*unionType*
Type: **T:System.Type**


The type of union to read.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**The description of the union case reader as a T:System.Reflection.MemberInfo object.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28F%23%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

