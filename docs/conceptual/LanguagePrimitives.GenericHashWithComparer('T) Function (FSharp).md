# LanguagePrimitives.GenericHashWithComparer<'T> Function (F#)

Recursively hash a part of a value according to its structure.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
GenericHashWithComparer : IEqualityComparer -> 'T -> int

// Usage:
GenericHashWithComparer comparer obj
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*comparer*
Type: **T:System.Collections.IEqualityComparer**


The comparison function.


*obj*
Type: **'T**


The input object.



**The hashed value.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

