---
title: Operators.min<'T> Function (F#)
description: Operators.min<'T> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: a2e42e61-60bd-4311-acfa-ebed88c9e0ef
---

# Operators.min<'T> Function (F#)

Minimum based on generic comparison.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
min : 'T -> 'T -> 'T (requires comparison)

// Usage:
min e1 e2
```

#### Parameters
*e1*
Type: **'T**


The first value.


*e2*
Type: **'T**


The second value.

## Return Value

The minimum value.

## Remarks
This function is named `Min` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)
