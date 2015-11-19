# HashIdentity.Reference<'T> Type Function (F#)

Implements physical hashing, which means that it hashes on reference identity of objects, and the contents of value types.

**Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Reference<'T (requires reference type)> :  IEqualityComparer<'T> (requires reference type)

// Usage:
Reference
```
**An object that implements T:System.Collections.IEqualityComparer.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function hashes using [LanguagePrimitives.PhysicalEquality](http://msdn.microsoft.com/en-us/library/1783ed93-63f4-4936-832f-4bf0db6e3586) and [LanguagePrimitives.PhysicalHash](http://msdn.microsoft.com/en-us/library/8c93ad8b-70d2-4035-9961-ba0f84d9458b). That is, for value types uses **M:System.Object.GetHashCode** and **Overload:System.Object.Equals** (if no other optimization available), and for reference types uses **M:System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)** and reference equality.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Collections.HashIdentity Module &#40;F&#35;&#41;](Collections.HashIdentity+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

