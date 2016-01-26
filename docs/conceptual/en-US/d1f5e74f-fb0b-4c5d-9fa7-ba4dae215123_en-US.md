# QueryBuilder.Run<'T> Extension Method (F#)

An extension method used to support the F# query syntax. Runs the given quotation as a query using LINQ IQueryable rules.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.Run : Expr<QuerySource<'T,IQueryable>> -> IQueryable<'T>

// Usage:
queryBuilder.Run (quotation)
```

#### CAPS_PARAMETERS_MD
*quotation*
Type: [Expr](http://msdn.microsoft.com/en-us/library/975ca4d3-ac2b-46db-9f01-23cf8b190c6e)&lt;[QuerySource](http://msdn.microsoft.com/en-us/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'T,
**T:System.Linq.IQueryable**&gt;&gt;


A quotation expression tree that represents a query.




## Return Value
The query as a queryable value.


## CAPS_REMARKS_MD
For more information and examples, see [Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0Supported in: 4.0, Portable




## See Also
[Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder+Class+%28F%23%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28F%23%29.md)

[Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db)

