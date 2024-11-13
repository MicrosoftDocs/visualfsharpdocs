---
title: Checked.( * )<^T1,^T2,^T3> Function (F#)
description: Checked.( * )<^T1,^T2,^T3> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: a2912336-171a-46ac-b66f-f1b0b03b0ded 
---

# Checked.( * )<^T1,^T2,^T3> Function (F#)

Overloaded multiplication operator (checks for overflow).

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
( * ) : ^T1 -> ^T2 -> ^T3 (requires ^T1 with static member op_Multiply and ^T2 with static member op_Multiply)

// Usage:
x * y
```

#### Parameters
*x*
Type: **^T1**


The first value.


*y*
Type: **^T2**


The second value.


## Return Value

The product of the two input values.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Operators.Checked Module &#40;F&#35;&#41;](Operators.Checked-Module-%5BFSharp%5D.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%5BFSharp%5D.md)