# Operators.limitedHash<'T> Function (F#)

A generic hash function. This function has the same behavior as [hash](http://msdn.microsoft.com/en-us/library/a83c0432-919e-407d-9ffc-8cf34fbc6daa), however the default structural hashing for F# union, record and tuple types stops when the given limit of nodes is reached. The exact behavior of the function can be adjusted on a type-by-type basis by implementing **M:System.Object.GetHashCode** for each type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
limitedHash : int -> 'T -> int (requires equality)

// Usage:
limitedHash limit obj

```



#### Parameters
*limit*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The limit of nodes.


*obj*
Type: **'T**


The input object.



**The computed hash.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

