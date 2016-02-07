# Checked.uint32<^T> Function (F#)

Converts the argument to **uint32**. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using **M:System.UInt32.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
uint32 : ^T -> uint32 (requires ^T with static member op_Explicit)

// Usage:
uint32 value

```



#### Parameters
*value*
Type: **^T**


The input value.



**The converted uint32.**
## Remarks
This function is named **ToUInt32** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Operators.Checked Module &#40;F&#35;&#41;](Operators.Checked+Module+%28FSharp%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28FSharp%29.md)

