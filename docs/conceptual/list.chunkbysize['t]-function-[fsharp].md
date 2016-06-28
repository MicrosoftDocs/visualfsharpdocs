---
title: List.chunkBySize<'T> Function (F#)
description: List.chunkBySize<'T> Function (F#)
keywords: visual f#, f#, functional programming
author: banashek
---

# List.chunkBySize<'T> Function (F#)

Divides the input list into chunks of size at most chunkSize.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
List.chunkBySize : int -> 'T list -> 'T list list

// Usage:
List.chunkBySize chunkSize list
```

#### Parameters
*chunkSize*
Type: [int](https://msdn.microsoft.com/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The maximum size of each chunk.


*list*
Type: **'T** [list](https://msdn.microsoft.com/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.

## Exceptions

|Exception|Condition|
|----|----|
|[ArgumentException](https://msdn.microsoft.com/library/system.argumentexception.aspx)|Thrown when chunkSize is not positive.|

## Return Value

The input list divided into chunks.

## Remarks
This function is named `ChunkBySize` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Example

The following code shows how to use List.contains.
[!code-fsharp[Main](snippets/fslists/snippet69.fs)]

## Output

```
[[1; 2]; [3; 4]; [5; 6]; [7; 8]; [9; 10]]
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)


