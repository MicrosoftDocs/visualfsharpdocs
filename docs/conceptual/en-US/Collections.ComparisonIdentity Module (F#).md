# Collections.ComparisonIdentity Module (F#)

Common notions of comparison identity used with sorted data structures.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
module ComparisonIdentity
```

## CAPS_REMARKS_MD

## Values


|Value|Description|
|-----|-----------|
|[FromFunction](http://msdn.microsoft.com/en-us/library/96d24027-4779-4f73-a611-91cbaca2ff9c)<br />**: ('T -&gt; 'T -&gt; int) -&gt; IComparer&lt;'T&gt;**|Compare using the given comparer function.|
|[Structural](http://msdn.microsoft.com/en-us/library/af092340-5ab2-478f-b873-1c88d97a0365)<br />**: IComparer&lt;'T&gt;**|Structural comparison. Compare using [Operators.compare](http://msdn.microsoft.com/en-us/library/295e1320-0955-4c3d-ac31-288fa80a658c).|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

