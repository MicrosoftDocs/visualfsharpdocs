# Expr.Substitute Method (F#)

Substitutes through the given expression using the given functions to map variables to new values. The functions must give consistent results at each application. Variable renaming may occur on the target expression if variable capture occurs.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
member this.Substitute : (Var -> Expr option) -> Expr

// Usage:
expr.Substitute (substitution)

```



#### Parameters
*substitution*
Type: [Var](http://msdn.microsoft.com/en-us/library/2b1237f9-d897-4bcf-872a-4a297db3f7b5)**-&gt;**[Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The function to map variables into expressions.



**The expression with the given substitutions.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr-Class-%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%28FSharp%29.md)

