---
title: HashCompare.FastCompareTuple4<'T1,'T2,'T3,'T4> Function (F#)
description: HashCompare.FastCompareTuple4<'T1,'T2,'T3,'T4> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 906b2607-98fd-4cfc-b999-b724a0f65de9 
---

# HashCompare.FastCompareTuple4<'T1,'T2,'T3,'T4> Function (F#)

A primitive entry point used by the F# compiler for optimization purposes.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
FastCompareTuple4 : IComparer -> 'T1 * 'T2 * 'T3 * 'T4 -> 'T1 * 'T2 * 'T3 * 'T4 -> int

// Usage:
FastCompareTuple4 comparer tuple1 tuple2
```

#### Parameters
*comparer*
Type: **System.Collections.IComparer**


The comparer object.


*tuple1*
Type: **'T1 &#42; 'T2 &#42; 'T3 &#42; 'T4**


The first tuple of four elements.


*tuple2*
Type: **'T1 &#42; 'T2 &#42; 'T3 &#42; 'T4**


The second tuple of four elements.


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