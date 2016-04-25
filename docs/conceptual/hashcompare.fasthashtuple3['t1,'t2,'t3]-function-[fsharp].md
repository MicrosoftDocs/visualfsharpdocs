# HashCompare.FastHashTuple3<'T1,'T2,'T3> Function (F#)

A primitive entry point used by the F# compiler for optimization purposes.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
FastHashTuple3 : IEqualityComparer -> 'T1 * 'T2 * 'T3 -> int

// Usage:
FastHashTuple3 comparer tuple


```





#### Parameters
*comparer*
Type: **T:System.Collections.IEqualityComparer**


The comparer object.


*tuple*
Type: **'T1 &#42; 'T2 &#42; 'T3**


A tuple of three elements.



**The computed hash.**
## Remarks
This function is for use by compiled F# code and should not be used directly.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[LanguagePrimitives.HashCompare Module &#40;F&#35;&#41;](LanguagePrimitives.HashCompare-Module-%5BFSharp%5D.md)

[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives-Module-%5BFSharp%5D.md)

