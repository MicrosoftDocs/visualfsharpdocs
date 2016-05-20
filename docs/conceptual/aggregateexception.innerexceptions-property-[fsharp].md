---
title: AggregateException.InnerExceptions Property (F#)
description: AggregateException.InnerExceptions Property (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 0d4c0450-e019-406d-a314-4930de459a1d 
---

# AggregateException.InnerExceptions Property (F#)

Gets a read-only collection of the **Exception** instances that caused the current exception.

**Namespace/Module Path**: System

**Assembly**: FSharp.Core (in FSharp.Core.dll)

## Syntax

```fsharp
// Signature:
member this.InnerExceptions :  ReadOnlyCollection<exn>

// Usage:
aggregateException.InnerExceptions

```

**A System.Collections.ObjectModel.ReadOnlyCollection&lt;Exception&gt; that contains the inner exceptions.**
## Remarks
This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, **System.AggregateException.InnerExceptions**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0


## See Also
[System.AggregateException Class &#40;F&#35;&#41;](System.AggregateException-Class-%5BFSharp%5D.md)

[System Namespace &#40;F&#35;&#41;](System-Namespace-%5BFSharp%5D.md)

