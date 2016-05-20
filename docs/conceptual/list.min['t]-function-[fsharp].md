---
title: List.min<'T> Function (F#)
description: List.min<'T> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 7dca9e3b-b835-4668-8e4e-0ad6264207f8 
---

# List.min<'T> Function (F#)

Returns the lowest of all elements of the list, compared by using [Operators.min](http://msdn.microsoft.com/en-us/library/adea4fd7-bfad-4834-989c-7878aca81fed).

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
List.min : 'T list -> 'T (requires comparison)

// Usage:
List.min list
```

#### Parameters
*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The minimum value.**
## Remarks
This function is named **Min** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use List.min.**
[!code-fsharp[Main](snippets/fslists/snippet57.fs)]
**Output**
**-4**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

