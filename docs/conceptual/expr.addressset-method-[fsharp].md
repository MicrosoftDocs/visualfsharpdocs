---
title: Expr.AddressSet Method (F#)
description: Expr.AddressSet Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 9036eed5-5076-4f1c-8b18-97c0bfb191ad 
---

# Expr.AddressSet Method (F#)

Creates an expression that represents setting the value held at a particular address.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
static member AddressSet : Expr * Expr -> Expr

// Usage:
Expr.AddressSet (target, value)


```





#### Parameters
*target*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The target expression.


*value*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The value to set at the address.



**The resulting expression.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%5BFSharp%5D.md)

