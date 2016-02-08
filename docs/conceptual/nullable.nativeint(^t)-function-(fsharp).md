# Nullable.nativeint<^T> Function (F#)

Converts the argument to signed native integer ([nativeint](http://msdn.microsoft.com/en-us/library/f8478c3e-fff5-4f10-82cf-4bedfe305f7b)). This is a direct conversion for all primitive numeric types. Otherwise, the operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
nativeint : Nullable<^T> -> Nullable<nativeint> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType

// Usage:
Nullable.nativeint value

```



#### Parameters
*value*
Type: **T:System.Nullable&#96;1**&lt;^T&gt;


The input value.




## Return Value
The converted nativeint.


## Remarks
This function is named **ToIntPtr** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.Nullable Module &#40;F&#35;&#41;](Linq.Nullable-Module-%28FSharp%29.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%28FSharp%29.md)

[Operators.nativeint&#60;^T&#62; Function &#40;F&#35;&#41;](Operators.nativeint%28%5ET%29-Function-%28FSharp%29.md)

