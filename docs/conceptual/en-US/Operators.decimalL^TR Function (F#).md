# Operators.decimal<^T> Function (F#)

Converts the argument to **T:System.Decimal** using a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.UInt64.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
decimal : ^T -> decimal (requires ^T with static member op_Explicit)

// Usage:
decimal value
```

#### CAPS_PARAMETERS_MD
*value*
Type: **^T**


The input value.



**The converted decimal.**
## CAPS_REMARKS_MD
This function is named **ToDecimal** in the assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

