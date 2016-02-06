# Nullable.uint32<^T> Function (F#)

Converts the argument to unsigned 32-bit integer ([uint32](http://msdn.microsoft.com/en-us/library/02aea3e2-e400-453a-a681-3a657afe1825)). This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
uint32 : Nullable<^T> -> Nullable<uint32> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType

// Usage:
Nullable.uint32 value
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*value*
Type: **T:System.Nullable&#96;1**&lt;^T&gt;


The input value.




## Return Value
The converted uint32.


## Remarks
This function is named **ToUInt32** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.Nullable Module &#40;F&#35;&#41;](Linq.Nullable+Module+%28FSharp%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+%28FSharp%29.md)

[Operators.uint32&#60;^T&#62; Function &#40;F&#35;&#41;](Operators.uint32%3C%5ET%3E+Function+%28FSharp%29.md)

