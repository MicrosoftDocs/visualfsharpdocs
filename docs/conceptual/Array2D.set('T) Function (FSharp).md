# Array2D.set<'T> Function (F#)

Sets the value of an element in an array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array2D

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array2D.set : 'T [,] -> int -> int -> 'T -> unit

// Usage:
Array2D.set array index1 index2 value

```



#### Parameters
*array*
Type: **'T**[[,]](http://msdn.microsoft.com/en-us/library/077252f3-e6ce-441c-9d5b-a6030eaef7cd)


The input array.


*index1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the first dimension.


*index2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the second dimension.


*value*
Type: **'T**


The value to set in the array.



**exceptions tag is not supported!!!!**

## Remarks
You can also use the syntax **array.[index1,index2] &lt;- value**.

This function is named **Set** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array2D Module &#40;F&#35;&#41;](Collections.Array2D+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

