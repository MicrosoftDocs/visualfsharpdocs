# Expr.PropertyGet Method (F#)

Creates an expression that represents reading a static property

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signatures:
static member PropertyGet : PropertyInfo * ?Expr list -> Expr
static member PropertyGet : Expr * PropertyInfo * ?Expr list -> Expr

// Usage:
Expr.PropertyGet (property)
Expr.PropertyGet (property, indexerArgs = indexerArgs)
Expr.PropertyGet (obj, property)
Expr.PropertyGet (obj, property, indexerArgs = indexerArgs)


```



#### CAPS_PARAMETERS_MD
*property*
Type: **T:System.Reflection.PropertyInfo**


The description of the property.


*indexerArgs*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


List of indices for the property if it is an indexed property.


*obj*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The object instance, if applicable.



**The resulting expression.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr+Class+%28F%23%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28F%23%29.md)

