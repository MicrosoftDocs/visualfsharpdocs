# Expr.FieldGet Method (F#)

Creates an expression that represents the access of a field of an object.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signatures:
static member FieldGet : Expr * FieldInfo -> Expr
static member FieldGet : FieldInfo -> Expr

// Usage:
Expr.FieldGet (obj, fieldInfo)
Expr.FieldGet (fieldInfo)
```

#### Parameters
*obj*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input object.


*fieldInfo*
Type: **T:System.Reflection.FieldInfo**


The description of the field to access.



**The resulting expression.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr+Class+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

