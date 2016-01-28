# Set.Remove<'T> Method (F#)

A useful shortcut for [Set.remove](http://msdn.microsoft.com/en-us/library/812a6d19-c1f0-4c57-9cbe-15d141d64ddb). Note this operation produces a new set and does not mutate the original set. The new set will share many storage nodes with the original. See the [Set module](http://msdn.microsoft.com/en-us/library/61efa732-d55d-4c32-993f-628e2f98e6a0) for further operations on sets.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.Remove : 'T -> Set<'T> (requires comparison)

// Usage:
set.Remove (value)
```

#### CAPS_PARAMETERS_MD
*value*
Type: **'T**


The value to remove from the set.



**The result set.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set&#60;'T&#62; Class &#40;F&#35;&#41;](Collections.SetL%27TR+Class+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

