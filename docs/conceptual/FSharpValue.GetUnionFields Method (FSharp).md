# FSharpValue.GetUnionFields Method (F#)

Identify the union case and its fields for an object.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member GetUnionFields : obj * Type * ?BindingFlags -> UnionCaseInfo * obj []
static member GetUnionFields : obj * Type * ?bool -> UnionCaseInfo * obj []

// Usage:
FSharpValue.GetUnionFields (value, unionType)
FSharpValue.GetUnionFields (value, unionType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.GetUnionFields (value, unionType, allowAccessToPrivateRepresentation = false)
```

#### Parameters
*value*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The input union case.


*unionType*
Type: **T:System.Type**


The union type containing the value.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**The description of the union case (as a [UnionCaseInfo](http://msdn.microsoft.com/en-us/library/d97eb038-9521-4e20-89b4-dd0cd92d7221)object) and its fields.**
## Remarks
If the type is not given, then the runtime type of the input object is used to identify the relevant union type. The type should always be given if the input object may be **null**. For example, option values may be represented using the **null**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28FSharp%29.md)

