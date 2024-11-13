---
title: QueryBuilder.ThenBy<'T,'Q,'Key> Method (F#)
description: QueryBuilder.ThenBy<'T,'Q,'Key> Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 65088bf0-6c39-4334-8b07-06b475fd9c6f
---

# QueryBuilder.ThenBy<'T,'Q,'Key> Method (F#)

A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
member this.ThenBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q> when 'Key : (IComparable)

// Usage:
queryBuilder.ThenBy (source, keySelector)
```

#### Parameters
*source*
Type: [QuerySource](https://msdn.microsoft.com/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'T,'Q&gt;


The input query.


*keySelector*
Type: 'T -&gt; 'Key


Specifies the field to sort by.

## Return Value
The sorted query.


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
