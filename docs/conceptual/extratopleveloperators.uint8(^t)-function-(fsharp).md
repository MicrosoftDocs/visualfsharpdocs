# ExtraTopLevelOperators.uint8<^T> Function (F#)

Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.Byte.Parse(System.String)** on strings and otherwise requires a **ToByte** method on the input type.

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
uint8 : ^T -> byte (requires ^T with static member op_Explicit)

// Usage:
uint8 value

```



#### Parameters
*value*
Type: **^T**


The value to convert.



**The converted value of type [byte](http://msdn.microsoft.com/en-us/library/17a98430-283a-4ff6-a475-e6999577179d).**
## Remarks
This function is named **ToByte** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators-Module-%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%28FSharp%29.md)

