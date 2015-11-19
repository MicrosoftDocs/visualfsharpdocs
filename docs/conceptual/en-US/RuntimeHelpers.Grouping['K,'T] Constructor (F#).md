# RuntimeHelpers.Grouping<'K,'T> Constructor (F#)

Constructs a new instance of a grouping for use in F# query expressions.

**Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
new Grouping : 'K * seq<'T> -> Grouping<'K,'T>

// Usage:
new Grouping (key, values)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*key*
Type: 'K


The grouping key.


*values*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)&lt;'T&gt;


The values to be grouped.




## Return Value
A collection that represents the grouped values.


## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[RuntimeHelpers.Grouping&#60;'K,'T&#62; Class &#40;F&#35;&#41;](RuntimeHelpers.Grouping%3C%27K%2C%27T%3E+Class+28%F%2329%.md)

[Microsoft.FSharp.Linq.RuntimeHelpers Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq.RuntimeHelpers+Namespace+28%F%2329%.md)

[Query Expressions (F#)](http://msdn.microsoft.com/en-us/library/ff72235c-3ad8-4215-8679-2754484823db)

