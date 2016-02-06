# Expr.UnionCaseTest Method (F#)

Creates an expression that represents a test of a value is of a particular union case.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member UnionCaseTest : Expr * UnionCaseInfo -> Expr

// Usage:
Expr.UnionCaseTest (source, unionCase)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The expression to test.


*unionCase*
Type: [UnionCaseInfo](http://msdn.microsoft.com/en-us/library/d97eb038-9521-4e20-89b4-dd0cd92d7221)


The description of the union case.



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

