# Expr.NewDelegate Method (F#)

Creates an expression that represents the creation of a delegate value for the given type.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member NewDelegate : Type * Var list * Expr -> Expr

// Usage:
Expr.NewDelegate (delegateType, parameters, body)
```

#### Parameters
*delegateType*
Type: **T:System.Type**


The type of delegate.


*parameters*
Type: [Var](http://msdn.microsoft.com/en-us/library/2b1237f9-d897-4bcf-872a-4a297db3f7b5)[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The parameters for the delegate.


*body*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The body of the function.



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

