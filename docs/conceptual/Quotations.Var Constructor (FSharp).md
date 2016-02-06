# Quotations.Var Constructor (F#)

Creates a new variable with the given name, type and mutability.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
new Var : string * Type * ?bool -> Var

// Usage:
new Var (name, typ)
new Var (name, typ, isMutable = isMutable)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*name*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The declared name of the variable.


*typ*
Type: **T:System.Type**


The type associated with the variable.


*isMutable*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Indicates if the variable represents a mutable storage location. The default value is **false**.



**The created variable.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Var Class &#40;F&#35;&#41;](Quotations.Var+Class+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

