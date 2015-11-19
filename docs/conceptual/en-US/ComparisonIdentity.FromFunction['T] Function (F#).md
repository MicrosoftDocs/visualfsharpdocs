# ComparisonIdentity.FromFunction<'T> Function (F#)

Compare using the given comparer function.

**Namespace/Module Path:** Microsoft.FSharp.Collections.ComparisonIdentity

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
FromFunction : ('T -> 'T -> int) -> IComparer<'T>

// Usage:
FromFunction comparer
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*comparer*
Type: **'T -&gt; 'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


A function to compare two values.



**An object implementing T:System.Collections.IComparer using the supplied comparer.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.ComparisonIdentity Module &#40;F&#35;&#41;](Collections.ComparisonIdentity+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

