---
title: Printf.failwithf<'T,'Result> Function (F#)
description: Printf.failwithf<'T,'Result> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 4c14d023-ae7b-482b-a79d-113eaf8d05e7
---

# Printf.failwithf<'T,'Result> Function (F#)

Prints to a string buffer and raises an exception with the given result. Helper printers must return strings.

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
failwithf : StringFormat<'T,'Result> -> 'T

// Usage:
failwithf format
```

#### Parameters
*format*
Type: [StringFormat](https://msdn.microsoft.com/library/d69a911f-3a25-42fa-bd51-a9c9c1102fa8)**&lt;'T,'Result&gt;**


The input formatter.

## Return Value

The arguments of the formatter.

## Remarks
This function is named `PrintFormatToStringThenFail` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.

## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)
