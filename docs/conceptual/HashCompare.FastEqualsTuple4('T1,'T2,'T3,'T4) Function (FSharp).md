# HashCompare.FastEqualsTuple4<'T1,'T2,'T3,'T4> Function (F#)

A primitive entry point used by the F# compiler for optimization purposes.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
FastEqualsTuple4 : IEqualityComparer -> 'T1 * 'T2 * 'T3 * 'T4 -> 'T1 * 'T2 * 'T3 * 'T4 -> bool

// Usage:
FastEqualsTuple4 comparer tuple1 tuple2
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*comparer*
Type: **T:System.Collections.IEqualityComparer**


The comparer object.


*tuple1*
Type: **'T1 &#42; 'T2 &#42; 'T3 &#42; 'T4**


The first tuple of four elements.


*tuple2*
Type: **'T1 &#42; 'T2 &#42; 'T3 &#42; 'T4**


The second tuple of four elements.



**true if the tuples are equal; otherwise, false.**
## Remarks
This function is for use by compiled F# code and should not be used directly.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[LanguagePrimitives.HashCompare Module &#40;F&#35;&#41;](LanguagePrimitives.HashCompare+Module+%28FSharp%29.md)

[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives+Module+%28FSharp%29.md)

