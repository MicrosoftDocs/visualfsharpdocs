# Set.Add<'T> Method (F#)

A useful shortcut for [Set.add](http://msdn.microsoft.com/en-us/library/d06ab305-1183-487c-8dc0-9076ed0b4c28). Note this operation produces a new set and does not mutate the original set. The new set will share many storage nodes with the original. See the [Set module](http://msdn.microsoft.com/en-us/library/61efa732-d55d-4c32-993f-628e2f98e6a0) for further operations on sets.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
member this.Add : 'T -> Set<'T> (requires comparison)

// Usage:
set.Add (value)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*value*
Type: **'T**


The value to add to the set.



**The result set.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set&#60;'T&#62; Class &#40;F&#35;&#41;](Collections.Set%3C%27T%3E+Class+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

