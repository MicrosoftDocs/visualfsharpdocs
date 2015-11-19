# Patterns.TryWith Active Pattern (F#)

Recognizes expressions that represent a try...with construct for exception filtering and catching.

**Namespace/Module Path:** Microsoft.FSharp.Quotations.Patterns

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
( |TryWith|_| ) : (input:Expr) -> (Expr * Var * Expr * Var * Expr) option
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Expr &#42; Var &#42; Expr &#42; Var &#42; Expr) option. The option indicates whether a successful match is made. In a pattern matching expression, upon a successful match, the input expression is decomposed into a tuple of five elements. The first element is an expression that represents the body of the try...with expression. The second element is the filter value, which is the value that is used to compare against the patterns. The third element is an expression that represents the filtering and assignment of any values set in the pattern matching (for example, by using the as keyword). The fourth element is the catch value, which is usually the same as the filter value and is used to determine which branch is taken. The final element is the catch expression, which includes the branching code. The tuple elements correspond to the arguments of the [Expr.TryWith](http://msdn.microsoft.com/en-us/library/bb6a4a9f-0a49-4fe5-b4fd-b2167bda74e1) method.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **TryWithPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+28%F%2329%.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+28%F%2329%.md)

