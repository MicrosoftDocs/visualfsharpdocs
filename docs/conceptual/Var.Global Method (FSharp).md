# Var.Global Method (F#)

Fetches or creates a new variable with the given name and type from a global pool of shared variables indexed by name and type.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member Global : string * Type -> Var

// Usage:
Var.Global (name, typ)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*name*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The name of the variable.


*typ*
Type: **T:System.Type**


The type associated with the variable.



**The retrieved or created variable.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Var Class &#40;F&#35;&#41;](Quotations.Var+Class+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

