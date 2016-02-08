# Operators.pown<^T> Function (F#)

Overloaded power operator. If **n &gt; 0** then equivalent to **x&#42;...&#42;x** for **n** occurrences of **x**.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
pown : ^T -> int -> ^T (requires ^T with static member One and ^T with static member op_Multiply and ^T with static member (/))

// Usage:
pown x n

```



#### Parameters
*x*
Type: **^T**


The input base.


*n*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The input exponent.



**The base raised to the exponent.**
## Remarks
This function is named **PowInteger** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%28FSharp%29.md)

