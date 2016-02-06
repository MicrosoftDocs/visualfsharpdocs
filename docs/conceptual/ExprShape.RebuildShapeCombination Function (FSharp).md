# ExprShape.RebuildShapeCombination Function (F#)

Re-build combination expressions. The first parameter should be an object returned by the **ShapeCombination** case of the active pattern in this module.

**Namespace/Module Path:** Microsoft.FSharp.Quotations.ExprShape

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
RebuildShapeCombination : obj * Expr list -> Expr

// Usage:
RebuildShapeCombination (shape, arguments)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*shape*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The input shape.


*arguments*
Type: [Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The list of arguments.



**The rebuilt expression.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.ExprShape Module &#40;F&#35;&#41;](Quotations.ExprShape+Module+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

