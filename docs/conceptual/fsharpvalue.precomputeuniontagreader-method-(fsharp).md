# FSharpValue.PreComputeUnionTagReader Method (F#)

Generates a function to read the tags of a union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member PreComputeUnionTagReader : Type * ?BindingFlags -> obj -> int
static member PreComputeUnionTagReader : Type * ?bool -> obj -> int

// Usage:
FSharpValue.PreComputeUnionTagReader (unionType)
FSharpValue.PreComputeUnionTagReader (unionType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeUnionTagReader (unionType, allowAccessToPrivateRepresentation = false)

```



#### Parameters
*unionType*
Type: **T:System.Type**


The type of union to optimize reading.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



<b>An optimized function to read the tags of the given union type.</b>
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%28FSharp%29.md)

