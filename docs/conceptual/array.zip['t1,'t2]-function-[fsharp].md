---
title: Array.zip<'T1,'T2> Function (F#)
description: Array.zip<'T1,'T2> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 0463857c-1ba9-4f07-9094-3bd26758bd2e 
---

# Array.zip<'T1,'T2> Function (F#)

Combines the two arrays into an array of tuples with two elements. The two arrays must have equal lengths, otherwise **T:System.ArgumentException** is raised.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
Array.zip : 'T1 [] -> 'T2 [] -> ('T1 * 'T2) []

// Usage:
Array.zip array1 array2


```





#### Parameters
*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.



**exceptions tag is not supported!!!!**
**The array of tupled elements.**
## Remarks
This function is named **Zip** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Array.zip.**
[!code-fsharp[Main](snippets/fsarrays/snippet72.fs)]
**Output**
**[|(1, -1); (2, -2); (3, -3)|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

