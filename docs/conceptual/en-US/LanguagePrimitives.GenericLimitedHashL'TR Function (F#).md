# LanguagePrimitives.GenericLimitedHash<'T> Function (F#)

Hash a value according to its structure. Use the given limit to restrict the hash when hashing F# records, lists and union types.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
GenericLimitedHash : int -> 'T -> int

// Usage:
GenericLimitedHash limit obj
```

#### CAPS_PARAMETERS_MD
*limit*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The limit on the number of nodes.


*obj*
Type: **'T**


The input object.



**The hashed value.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

