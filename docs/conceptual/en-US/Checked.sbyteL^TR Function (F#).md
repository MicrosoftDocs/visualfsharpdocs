# Checked.sbyte<^T> Function (F#)

Converts the argument to **sbyte**. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using **M:System.SByte.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
sbyte : ^T -> sbyte (requires ^T with static member op_Explicit)

// Usage:
sbyte value


```



#### CAPS_PARAMETERS_MD
*value*
Type: **^T**


The input value.



**The converted sbyte.**
## CAPS_REMARKS_MD
This function is named **ToSByte** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Operators.Checked Module &#40;F&#35;&#41;](Operators.Checked+Module+%28F%23%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

