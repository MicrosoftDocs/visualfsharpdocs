# QueryBuilder.ThenByNullable<'T,'Q,'Key> Method (F#)

A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given nullable sorting key. This operator may only be used immediately after a **sortBy**, **sortByDescending**, **thenBy** or **thenByDescending**, or their nullable variants.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.ThenByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q> when 'Key : (IComparable) and 'Key : (new : unit ->  'Key) and 'Key : struct and 'Key :> ValueType

// Usage:
queryBuilder.ThenByNullable (source, keySelector)
```

#### CAPS_PARAMETERS_MD
*source*
Type: [QuerySource](http://msdn.microsoft.com/en-us/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'T,'Q&gt;


The input query


*keySelector*
Type: 'T -&gt;
**T:System.Nullable&#96;1**&lt;'Key&gt;


Specifies the field to sort by.




## Return Value
The sorted query.


## CAPS_REMARKS_MD
For more information and examples, see [Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder+Class+%28F%23%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28F%23%29.md)

[Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db)

