# QueryBuilder.Quote<'T> Method (F#)

A method used to support the F# query syntax. Indicates that the query should be passed as a quotation to the [Run](http://msdn.microsoft.com/en-us/library/33bbcef1-2a4a-45cb-9105-01aa0082cfc9) method.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
member this.Quote : Expr<'T> -> Expr<'T>

// Usage:
queryBuilder.Quote ()


```



#### CAPS_PARAMETERS_MD
*source*
Type: [Expr](http://msdn.microsoft.com/en-us/library/975ca4d3-ac2b-46db-9f01-23cf8b190c6e)&lt;'T&gt;


The input query.




## Return Value
The query as an F# quotation.


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

