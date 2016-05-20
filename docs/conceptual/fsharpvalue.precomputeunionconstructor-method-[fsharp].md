---
title: FSharpValue.PreComputeUnionConstructor Method (F#)
description: FSharpValue.PreComputeUnionConstructor Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: dd792527-6097-4fdf-8814-b51ecfd8598f 
---

# FSharpValue.PreComputeUnionConstructor Method (F#)

Generates a function for constructing a discriminated union value for a particular union case.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member PreComputeUnionConstructor : UnionCaseInfo * ?BindingFlags -> obj [] -> obj
static member PreComputeUnionConstructor : UnionCaseInfo * ?bool -> obj [] -> obj

// Usage:
FSharpValue.PreComputeUnionConstructor (unionCase)
FSharpValue.PreComputeUnionConstructor (unionCase, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeUnionConstructor (unionCase, allowAccessToPrivateRepresentation = false)
```

#### Parameters
*unionCase*
Type: [UnionCaseInfo](http://msdn.microsoft.com/en-us/library/d97eb038-9521-4e20-89b4-dd0cd92d7221)


The description of the union case.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**A function for constructing values of the given union case.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)

