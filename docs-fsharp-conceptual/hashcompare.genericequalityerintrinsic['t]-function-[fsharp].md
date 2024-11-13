---
title: HashCompare.GenericEqualityERIntrinsic<'T> Function (F#)
description: HashCompare.GenericEqualityERIntrinsic<'T> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 875ebed2-6025-4e76-893c-c18903917f01 
---

# HashCompare.GenericEqualityERIntrinsic<'T> Function (F#)

A primitive entry point used by the F# compiler for optimization purposes.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
GenericEqualityERIntrinsic : 'T -> 'T -> bool

// Usage:
GenericEqualityERIntrinsic x y
```

#### Parameters
*x*
Type: **'T**


The first object to compare.


*y*
Type: **'T**


The second object to compare.


## Return Value

The result of the comparison.

## Remarks
This function is for use by compiled F# code and should not be used directly.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[LanguagePrimitives.HashCompare Module &#40;F&#35;&#41;](LanguagePrimitives.HashCompare-Module-%5BFSharp%5D.md)

[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives-Module-%5BFSharp%5D.md)