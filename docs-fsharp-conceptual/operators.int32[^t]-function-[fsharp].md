---
title: Operators.int32<^T> Function (F#)
description: Operators.int32<^T> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 5ac7db48-a62a-4b1c-be5d-47d67c232878
---

# Operators.int32<^T> Function (F#)

Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using `System.Int32.Parse(System.String)` with `System.Globalization.CultureInfo.InvariantCulture` settings. Otherwise the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
int32 : ^T -> int32 (requires ^T with static member op_Explicit)

// Usage:
int32 value
```

#### Parameters
*value*
Type: **^T**


The input value.

## Return Value

The converted `int32` value.

## Remarks
This function is named `ToInt32` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)
