# Patterns.NewRecord Active Pattern (F#)

Recognizes expressions that represent the construction of record values.

**Namespace/Module Path**: Microsoft.FSharp.Quotations.Patterns

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
( |NewRecord|_| ) : (input:Expr) -> (Type * Expr list) option

```



#### Parameters
*input*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The input expression to match against.



**The formal return type is (Type &#42; Expr list) option. The option indicates whether the input results in a match. In a pattern matching expression, the input is decomposed, upon a successful match, into a tuple that has two elements. The first element is a T:System.Type object that represents the record type that is being constructed, and the second element is a list of expressions that represent the constructor arguments.**
## Remarks
This function is named **NewRecordPattern** in the .NET Framework assembly. If you are accessing the member from a .NET Framework language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Patterns Module &#40;F&#35;&#41;](Quotations.Patterns+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

