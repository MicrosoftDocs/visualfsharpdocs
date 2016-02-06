# Patterns.FieldSet Active Pattern (F#)

Recognizes expressions that represent setting a static or instance field.

**Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( |FieldSet|_| ) : Expr -> (Expr option * FieldInfo * Expr) option
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Expr option &#42; FieldInfo &#42; Expr) option. The option determines whether the input results in a match. In a pattern matching expression, the input is decomposed into a tuple of three elements. The first is an option that can contain an expression that represents the instance. This element is None if the field is static. The second element is a T:System.Reflection.FieldInfo object, and the third element is an expression that represents the value to set the field to.**
## Remarks
This function is named **FieldSetPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable






## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

