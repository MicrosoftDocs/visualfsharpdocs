---
title: Expr.LetRecursive Method (F#)
description: Expr.LetRecursive Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: b4c44bd2-e0a0-4d77-95b5-10fe7d8d0e76 
---

# Expr.LetRecursive Method (F#)

Builds recursives expressions associated with `let rec` constructs.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
static member LetRecursive : Var * Expr list * Expr -> Expr

// Usage:
Expr.LetRecursive (bindings, body)
```

#### Parameters
*bindings*
Type: [Var](https://msdn.microsoft.com/library/2b1237f9-d897-4bcf-872a-4a297db3f7b5)**&#42;**[Expr](https://msdn.microsoft.com/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)[list](https://msdn.microsoft.com/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The list of bindings for the let expression.


*body*
Type: [Expr](https://msdn.microsoft.com/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The sub-expression where the bindings are in scope.

## Return Value

The resulting expression.

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%5BFSharp%5D.md)