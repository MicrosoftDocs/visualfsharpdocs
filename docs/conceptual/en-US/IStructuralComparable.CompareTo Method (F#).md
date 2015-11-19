# IStructuralComparable.CompareTo Method (F#)

Determines whether the current object precedes, occurs in the same position as, or follows another object in the sort order.

**Namespace/Module Path**: System.Collections

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
abstract this.CompareTo : obj * IComparer -> int

// Usage:
iStructuralComparable.CompareTo (obj, comparer)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*obj*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The object to compare with the current instance.


*comparer*
Type: **T:System.Collections.IComparer**


An object that performs comparisons.



**An integer that indicates the relationship of the current object to the target object.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, **M:System.Collections.IStructuralComparable.CompareTo(System.Object,System.Collections.IComparer)**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Collections.IStructuralComparable Interface &#40;F&#35;&#41;](Collections.IStructuralComparable+Interface+28%F%2329%.md)

[System.Collections Namespace &#40;F&#35;&#41;](System.Collections+Namespace+28%F%2329%.md)

