# Quotations.ExprShape Module (F#)

Active patterns for traversing, visiting, rebuilding and transforming expressions in a generic way

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
module ExprShape
```

## Remarks

## Values


|Value|Description|
|-----|-----------|
|[RebuildShapeCombination](http://msdn.microsoft.com/en-us/library/38c3f403-b3ed-4ddf-a69c-53a21339aa2f)<br />**: obj &#42; Expr list -&gt; Expr**|Rebuild combination expressions. The first parameter should be an object returned by the [ShapeCombination](http://msdn.microsoft.com/en-us/library/e090818c-3353-4f28-96ed-1eb04d71139c) case of the active pattern in this module.|

## Active Patterns


|Active Pattern|Description|
|--------------|-----------|
|[( &#124;ShapeVar&#124;ShapeLambda&#124;ShapeCombination&#124; )](http://msdn.microsoft.com/en-us/library/e090818c-3353-4f28-96ed-1eb04d71139c)|An active pattern that performs a complete decomposition viewing the expression tree as a binding structure|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

