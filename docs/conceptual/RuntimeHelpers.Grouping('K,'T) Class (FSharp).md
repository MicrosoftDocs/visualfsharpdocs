# RuntimeHelpers.Grouping<'K,'T> Class (F#)

Reconstructs a grouping after applying a mutable to immutable mapping transformation on a result of a query. This type is used to implement **groupBy** and **groupValBy** for F# query expressions.

**Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
type [Grouping](http://msdn.microsoft.com/en-us/library/4a6ac4d6-5b30-44bb-b34d-c6773f86dedf)<'K,'T> =
class
inherit IEnumerable<'T>
inherit IEnumerable
inherit IGrouping<'K,'T>
new Grouping : 'K * seq<'T> -> Grouping<'K,'T>
end
```

## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/6372a867-5fcd-41e1-9616-8d3d094d5103)|Constructs a new instance of **Grouping**.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Linq.RuntimeHelpers Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq.RuntimeHelpers+Namespace+%28FSharp%29.md)

[Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db)

