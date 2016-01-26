# Patterns.TryFinally Active Pattern (F#)

Recognizes expressions that represent a **try...finally** construct.

**Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( |TryFinally|_| ) : (input:Expr) -> (Expr * Expr) option
```

#### CAPS_PARAMETERS_MD
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Expr &#42; Expr) option. The option type indicates whether the input expression results in a match. In a pattern matching expression, the input expression is decomposed, upon a successful match, into a tuple of two expressions. The first expression represents the code in the try block. The second expression represents the code in the finally block.**
## CAPS_REMARKS_MD
This function is named **TryFinallyPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+%28F%23%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28F%23%29.md)

