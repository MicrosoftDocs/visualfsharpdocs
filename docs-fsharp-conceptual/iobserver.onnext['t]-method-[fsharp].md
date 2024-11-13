---
title: IObserver.OnNext<'T> Method (F#)
description: IObserver.OnNext<'T> Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: fcb54797-6ab1-491f-b5fd-1a24593986c4 
---

# IObserver.OnNext<'T> Method (F#)

Notify an observer of a new result

**Namespace/Module Path**: System

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
abstract this.OnNext : 'T -> unit

// Usage:
iObserver.OnNext (value)
```

#### Parameters
*value*
Type: **'T**


The value to notify observers.

## Remarks
This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, `System.IObserver.OnNext()`.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0

## See Also
[System.IObserver&#60;'T&#62; Interface &#40;F&#35;&#41;](System.IObserver%5B%27T%5D-Interface-%5BFSharp%5D.md)

[System Namespace &#40;F&#35;&#41;](System-Namespace-%5BFSharp%5D.md)