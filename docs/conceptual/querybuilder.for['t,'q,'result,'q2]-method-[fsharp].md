# QueryBuilder.For<'T,'Q,'Result,'Q2> Method (F#)

A method used to support the F# query syntax. Projects each element of a sequence to another sequence and combines the resulting sequences into one sequence.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
member this.For : QuerySource<'T,'Q> * ('T -> QuerySource<'Result,'Q2>) -> QuerySource<'Result,'Q>

// Usage:
queryBuilder.For (source, body)

```



#### Parameters
*source*
Type: [QuerySource](http://msdn.microsoft.com/en-us/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'T,'Q&gt;


The input query.


*body*
Type: 'T -&gt;
[QuerySource](http://msdn.microsoft.com/en-us/library/873589c1-c5dc-47d9-8abf-fee7258dfb00)&lt;'Result,'Q2&gt;


A function that represents the body of the for loop in a query expression.




## Return Value
The result sequence.


## Remarks
This method implements the for loop syntax for query expressions.

For more information and examples, see [Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%5BFSharp%5D.md)

[Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db)

