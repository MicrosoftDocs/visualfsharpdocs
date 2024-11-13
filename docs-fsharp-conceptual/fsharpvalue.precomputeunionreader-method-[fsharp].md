---
title: FSharpValue.PreComputeUnionReader Method (F#)
description: FSharpValue.PreComputeUnionReader Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: fced1d04-dfd0-4152-b63d-7ad8104be3b2 
---

# FSharpValue.PreComputeUnionReader Method (F#)

Generates a function for reading all the fields for a particular discriminator case of a union type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
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
Type: [UnionCaseInfo](https://msdn.microsoft.com/library/d97eb038-9521-4e20-89b4-dd0cd92d7221)


The description of the union case to read.


*bindingFlags*
Type: **System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](https://msdn.microsoft.com/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.

## Return Value

A function to for reading the fields of the given union case.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)