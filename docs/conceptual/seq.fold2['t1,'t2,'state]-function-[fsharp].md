---
title: Seq.fold2<'T1,'T2,'State> Function (F#)
description: Seq.fold2<'T1,'T2,'State> Function (F#)
keywords: visual f#, f#, functional programming
author: liboz
manager: danielfe
ms.date: 7/23/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 9d61b748-82e4-463f-ae57-0c2801bb14c3
---

# Seq.fold2<'T1,'T2,'State> Function (F#)

Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The two sequences need not have equal lengths: when one sequence is exhausted any remaining elements in the other sequence are ignored. If the input function is `f` and the elements are `i0...iN` and `j0...jN` then computes `f (... (f s i0 j0)...) iN jN`.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)

## Syntax

```fsharp
// Signature:
Seq.fold2 : ('State -> 'T1 -> 'T2 -> 'State) -> 'State -> seq<'T1> -> seq<'T2> -> 'State

// Usage:
Seq.fold2 folder state sequence1 sequence2
```

#### Parameters
*folder*
Type: **'State -&gt; 'T1 -&gt; 'T2 -&gt; 'State**

The function to update the state given the input elements.

*state*
Type: **'State**

The initial state.

*sequence1*
Type: **'T1**[sequence](https://msdn.microsoft.com/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)

The first input sequence.

*sequence2*
Type: **'T2**[sequence](https://msdn.microsoft.com/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)

The second input sequence.

## Exceptions

|Exception|Condition|
|----|----|
|[ArgumentNullException](https://msdn.microsoft.com/library/system.argumentnullexception.aspx)|Thrown when the input sequence is null.|

## Return Value

The final state value.

## Remarks
This function is named `Fold2` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

## Example

[!code-fsharp[Main](snippets/fssequences/snippet49.fs)]

**Output**

```
The sum of the greater of each pair of elements in the two sequences is 8.
The sum of the greater of each pair of elements in the two sequences is 16.
```

The following code example illustrates the use of `Seq.fold2` to compute the ending balance in a bank account after a series of transactions. The two input sequences represent the transaction type (deposit or withdrawal) and the transaction amount.

[!code-fsharp[Main](snippets/fssequences/snippet50.fs)]

**Output**

```
1205.000000
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2

## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable

## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)
