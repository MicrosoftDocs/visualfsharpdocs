---
title: QueryBuilder.SumBy<'T,'Q,^Value> Method (F#)
description: QueryBuilder.SumBy<'T,'Q,^Value> Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 9cde4e05-23ba-42eb-b7fd-56d72c868cba
---

# QueryBuilder.SumBy<'T,'Q,^Value> Method (F#)

A query operator that selects a value for each element selected so far and returns the sum of these values.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
member this.SumBy : QuerySource<'T,'Q> * ('T -> ^Value) -> ^Value when ^Value with static member (+) and ^Value with static member Zero

// Usage:
queryBuilder.SumBy (source, projection)
```

#### Parameters
*source*
Type: [QuerySource](https://msdn.microsoft.com/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'T,'Q&gt;


The input query.


*projection*
Type: 'T -&gt; ^Value


A function to compute the values to sum.

## Return Value
The resulting sum.


## Remarks
For more information and examples, see [Query Expressions (F#)](https://msdn.microsoft.com/library/ff72235c-3ad8-4215-8679-2754484823db).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable

## See Also
[Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%5BFSharp%5D.md)

[Query Expressions (F#)](https://msdn.microsoft.com/library/ff72235c-3ad8-4215-8679-2754484823db)
