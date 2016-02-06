# DerivedPatterns.Applications Active Pattern (F#)

Recognizes expressions that represent the application of a (possibly curried or tupled) first-class function value

**Namespace/Module Path**: Microsoft.FSharp.Quotations.DerivedPatterns

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( |Applications|_| ) : (input:Expr) -> (Expr * Expr list list) option
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return value is (Expr &#42; Expr list list) option. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple of two elements. The first element is an expression that represents the function. The second element is a list of lists of expressions that represent the curried and tuple arguments of the function.**
## Remarks
This function is named **ApplicationsPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.DerivedPatterns Module &#40;F&#35;&#41;](Quotations.DerivedPatterns+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

