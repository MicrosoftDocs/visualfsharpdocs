# QueryBuilder.Source<'T,'Q> Method (F#)

A method used to support the F# query syntax. Inputs to queries are implicitly wrapped by a call to one of the overloads of this method.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
member this.Source : IQueryable<'T> -> QuerySource<'T,'Q>

// Usage:
queryBuilder.Source (source)


```



#### CAPS_PARAMETERS_MD
*source*
Type: **T:System.Linq.IQueryable&#96;1**&lt;'T&gt;


The input queryable collection.




## Return Value
A query in the form used by query expressions.


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

