---
title: String.replicate Function (F#)
description: String.replicate Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 1dd8af21-519f-45ff-a27b-4f50cc121c73 
---

# String.replicate Function (F#)

Returns a string by concatenating a specified number of instances of a string.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
String.replicate : int -> string -> string

// Usage:
String.replicate count str


```





#### Parameters
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of copies of the input string will be copied.


*str*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The input string.



**exceptions tag is not supported!!!!**
**The concatenated string.**
## Remarks
This function is named **Replicate** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use String.replicate.**
[!code-fsharp[Main](snippets/fsstrings/snippet11.fs)]
**Output**
**XOXOXOXOXOXOXOXOXOXO**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

