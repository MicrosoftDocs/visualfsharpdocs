# Array4D.set<'T> Function (F#)

Sets the value of an element in an array.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array4D

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array4D.set : 'T [,,,] -> int -> int -> int -> int -> 'T -> unit

// Usage:
Array4D.set array index1 index2 index3 index4 value


```



#### CAPS_PARAMETERS_MD
*array*
Type: **'T**[[,,,]](http://msdn.microsoft.com/en-us/library/e957316d-b2e0-4f04-ac4c-426d4f38a968)


The input array.


*index1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the first dimension.


*index2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the second dimension.


*index3*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the third dimension.


*index4*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index along the fourth dimension.


*value*
Type: **'T**


The value to set.




## CAPS_REMARKS_MD
You can also use the syntax **array.[index1,index2,index3,index4] &lt;- value**.

This function is named **Set** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array4D Module &#40;F&#35;&#41;](Collections.Array4D+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

