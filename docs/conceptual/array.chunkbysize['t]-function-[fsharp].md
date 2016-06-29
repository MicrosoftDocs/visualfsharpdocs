---
title: Array.chunkBySize<'T> Function (F#)
description: Array.chunkBySize<'T> Function (F#)
keywords: visual f#, f#, functional programming
author: banashek
---

# Array.chunkBySize<'T> Function (F#)

Divides the input array into chunks consisting of chunkSize elements. The last chunk may contain fewer thank chunkSize elements.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)

## Syntax

```fsharp
// Signature:
Array.chunkBySize: chunkSize:int -> array:'T[] -> 'T[][]

// Usage:
Array.chunkBySize chunkSize array
```

#### Parameters

*chunkSize*
Type: [int](https://msdn.microsoft.com/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)

The maximum size of each chunk.

*array*
Type: **'T** [array](https://msdn.microsoft.com/visualfsharpdocs/conceptual/collections.array-module-%5bfsharp%5d)

The input array.

## Exceptions

|Exception|Condition|
|----|----|
|[ArgumentNullException](https://msdn.microsoft.com/library/system.argumentnullexception.aspx)|Thrown when the input array is null.|
|[ArgumentException](https://msdn.microsoft.com/library/system.argumentexception.aspx)|Thrown when `chunkSize` is not positive.|

## Return Value

The input array divided into chunks.

## Remarks

This function is named `ChunkBySize` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Example

The following code shows how to use Array.chunkBySize.
[!code-fsharp[Main](snippets/fsarrays/snippet74.fs)]

## Output

```
[|[|1; 2|]; [|3; 4|]; [|5; 6|]; [|7; 8|]; [|9; 10|]|]
```

## Platforms

Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information

**F# Core Library Versions**

Supported in: 4.0, Portable

## See Also

[Collections.Array Module &#40;F&#35;&#41;](Collections.Array-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)
