# Patterns.PropertyGet Active Pattern (F#)

Recognizes expressions that represent the reading of a static or instance property, or of a non-function value declared in a module.

**Namespace/Module Path:** Microsoft.FSharp.Quotations.Patterns

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( |PropertyGet|_| ) : (input:Expr) -> (Expr option * PropertyInfo * Expr list) option
```

#### CAPS_PARAMETERS_MD
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Expr option &#42; PropertyInfo &#42; Expr list) option. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple that has three elements. The first element is an optional expression that represents the instance. For a static property, this option is None. The second element is a T:System.Reflection.PropertyInfo object that represents the property. The third element is a list that contains the arguments of the get accessor, which is used for indexed properties.**
## CAPS_REMARKS_MD
This function is named **PropertyGetPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+%28F%23%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28F%23%29.md)

