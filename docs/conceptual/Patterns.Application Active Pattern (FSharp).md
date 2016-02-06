# Patterns.Application Active Pattern (F#)

Recognizes expressions that represent applications of first-class function values.

**Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( |Application|_| ) : (input:Expr) -> (Expr * Expr) option
```

#### Parameters
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Expr &#42; Expr) option. The option indicates whether a match exists. When you use the active pattern in a match expression, you use the tuple of two expressions directly to decompose the pattern.**
**The tuple contains two expressions that result from the decomposition of a curried function application expression. If there is one curried argument, the first expression represents the function name and the second expression represents the argument. If there are multiple curried arguments, the first expression is itself a function application that contains all the curried arguments except the last, and the second expression represents the last curried argument. The first expression can be recursively processed to decompose the next curried argument of the function.**
## Remarks
This function is named **ApplicationPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

