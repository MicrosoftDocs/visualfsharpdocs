---
title: Seq.foldBack<'T,'State> Function (F#)
description: Seq.foldBack<'T,'State> Function (F#)
keywords: visual f#, f#, functional programming
author: liboz
manager: danielfe
ms.date: 7/23/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: c6e15860-02bd-4663-aca9-407d5f51de32
---

# Seq.foldBack<'T,'State> Function (F#)

Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is `f` and the elements are `i0...iN`, then this function computes `f i0 (...(f iN s))`.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)

## Syntax

```fsharp
// Signature:
Seq.foldBack : ('T -> 'State -> 'State) -> seq<'T> -> 'State -> 'State

// Usage:
Seq.foldBack folder sequence state
```

#### Parameters
*folder*
Type: **'T -&gt; 'State -&gt; 'State**

The function to update the state given the input elements.

*sequence*
Type: [seq](https://msdn.microsoft.com/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**

The input sequence.

*state*
Type: **'State**

The initial state.

## Exceptions

|Exception|Condition|
|----|----|
|[ArgumentNullException](https://msdn.microsoft.com/library/system.argumentnullexception.aspx)|Thrown when the input sequence is null.|

## Return Value

The final state value.

## Remarks
This function is named `FoldBack` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Example

[!code-fsharp[Main](snippets/fssequences/snippet51.fs)]

**Output**

```
6
5
5
-5
5
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable

## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)
