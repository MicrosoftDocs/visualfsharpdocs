# Expr.PropertySet Method (F#)

Creates an expression that represents writing to a static property

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signatures:
static member PropertySet : PropertyInfo * Expr * ?Expr list -> Expr
static member PropertySet : Expr * PropertyInfo * Expr * ?Expr list -> Expr

// Usage:
Expr.PropertySet (property, value)
Expr.PropertySet (property, value, indexerArgs = indexerArgs)
Expr.PropertySet (obj, property, value)
Expr.PropertySet (obj, property, value, indexerArgs = indexerArgs)

```



#### Parameters
*property*
Type: **T:System.Reflection.PropertyInfo**


The description of the property.


*value*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The value to set.


*indexerArgs*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


List of indices for the property if it is an indexed property.


*obj*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)


The object instance, if applicable.



**The resulting expression.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr-Class-%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%28FSharp%29.md)

