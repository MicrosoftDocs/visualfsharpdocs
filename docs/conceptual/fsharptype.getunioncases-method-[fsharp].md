# FSharpType.GetUnionCases Method (F#)

Gets the cases of a union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member GetUnionCases : Type * ?BindingFlags -> UnionCaseInfo []
static member GetUnionCases : Type * ?bool -> UnionCaseInfo []

// Usage:
FSharpType.GetUnionCases (unionType)
FSharpType.GetUnionCases (unionType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpType.GetUnionCases (unionType, allowAccessToPrivateRepresentation = false)

```



#### Parameters
*unionType*
Type: **T:System.Type**


The input union type.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**An array of descriptions of the cases ([UnionCaseInfo](http://msdn.microsoft.com/en-us/library/d97eb038-9521-4e20-89b4-dd0cd92d7221) objects) of the given union type.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpType Class &#40;F&#35;&#41;](Reflection.FSharpType-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)

