# Expr.NewRecord Method (F#)

Builds record-construction expressions.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member NewRecord : Type * Expr list -> Expr

// Usage:
Expr.NewRecord (recordType, elements)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*recordType*
Type: **T:System.Type**


The type of record.


*elements*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The list of elements of the record.



**The resulting expression.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr+Class+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

