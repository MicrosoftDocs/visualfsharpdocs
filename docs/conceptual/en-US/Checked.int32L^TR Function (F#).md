# Checked.int32<^T> Function (F#)

Converts the argument to **int32**. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using **M:System.Int32.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
int32 : ^T -> int32 (requires ^T with static member op_Explicit)

// Usage:
int32 value
```

#### CAPS_PARAMETERS_MD
*value*
Type: **^T**


The input value.



**The converted int32.**
## CAPS_REMARKS_MD
This function is named **ToInt32** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Operators.Checked Module &#40;F&#35;&#41;](Operators.Checked+Module+%28F%23%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

