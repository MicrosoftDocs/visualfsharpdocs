# Expr.GlobalVar<'T> Method (F#)

Fetches or creates a new variable with the given name and type from a global pool of shared variables indexed by name and type. The type is given by the expicit or inferred type parameter.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member GlobalVar : string -> Expr<'T>

// Usage:
Expr.GlobalVar (name)

```



#### Parameters
*name*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The variable name.



**The created of fetched typed global variable.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr-Class-%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%28FSharp%29.md)

