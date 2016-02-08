# FSharpValue.PreComputeUnionReader Method (F#)

Generates a function for reading all the fields for a particular discriminator case of a union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member PreComputeUnionReader : UnionCaseInfo * ?BindingFlags -> obj -> obj []
static member PreComputeUnionReader : UnionCaseInfo * ?bool -> obj -> obj []

// Usage:
FSharpValue.PreComputeUnionReader (unionCase)
FSharpValue.PreComputeUnionReader (unionCase, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeUnionReader (unionCase, allowAccessToPrivateRepresentation = false)

```



#### Parameters
*unionCase*
Type: [UnionCaseInfo](http://msdn.microsoft.com/en-us/library/d97eb038-9521-4e20-89b4-dd0cd92d7221)


The description of the union case to read.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**A function to for reading the fields of the given union case.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%28FSharp%29.md)

