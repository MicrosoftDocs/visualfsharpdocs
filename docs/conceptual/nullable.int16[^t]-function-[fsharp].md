# Nullable.int16<^T> Function (F#)

Converts the argument to signed 16-bit integer ([int16](http://msdn.microsoft.com/en-us/library/608e612c-5a8e-40c4-912f-55788628cb9b)). This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.

**Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
int16 : Nullable<^T> -> Nullable<int16> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType

// Usage:
Nullable.int16 value


```





#### Parameters
*value*
Type: **T:System.Nullable&#96;1**&lt;^T&gt;


The input value.




## Return Value
The converted int16.


## Remarks
This function is named **ToInt16** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Linq.Nullable Module &#40;F&#35;&#41;](Linq.Nullable-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%5BFSharp%5D.md)

[Operators.int16&#60;^T&#62; Function &#40;F&#35;&#41;](Operators.int16%5B%5ET%5D-Function-%5BFSharp%5D.md)

