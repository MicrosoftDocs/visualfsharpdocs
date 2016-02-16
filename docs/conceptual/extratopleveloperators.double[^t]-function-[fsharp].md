# ExtraTopLevelOperators.double<^T> Function (F#)

Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.Double.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires and invokes a **ToDouble** method on the input type

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
double : ^T -> float (requires ^T with static member op_Explicit)

// Usage:
double value

```



#### Parameters
*value*
Type: **^T**


The value to convert.



**The converted value of type [float](http://msdn.microsoft.com/en-us/library/3fa76cae-e9b5-4672-8bdf-88ff6dbcf7b8).**
## Remarks
This function is named **ToDouble** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

