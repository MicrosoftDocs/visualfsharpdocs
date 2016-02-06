# ExprShape.ShapeVar|ShapeLambda|ShapeCombination Active Pattern (F#)

An active pattern that performs a complete decomposition viewing the expression tree as a binding structure.

**Namespace/Module Path:** Microsoft.FSharp.Quotations.ExprShape

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( |ShapeVar|ShapeLambda|ShapeCombination| ) : (input:Expr) -> Choice<Var,(Var * Expr),(obj * Expr list)>
```

#### Parameters
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression.



**The decomposed [Var](http://msdn.microsoft.com/en-us/library/2b1237f9-d897-4bcf-872a-4a297db3f7b5), [Lambda](http://msdn.microsoft.com/en-us/library/783760ed-8dd5-407e-a752-19451d81bb97), or ConstApp.**
## Remarks
This function is named **ShapePattern** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.ExprShape Module &#40;F&#35;&#41;](Quotations.ExprShape+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

