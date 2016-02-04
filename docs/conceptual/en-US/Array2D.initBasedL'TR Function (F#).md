# Array2D.initBased<'T> Function (F#)

Creates a based array given the dimensions and a generator function to compute the elements.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array2D

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array2D.initBased : int -> int -> int -> int -> (int -> int -> 'T) -> 'T [,]

// Usage:
Array2D.initBased base1 base2 length1 length2 initializer


```



#### CAPS_PARAMETERS_MD
*base1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The base for the first dimension of the array.


*base2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The base for the second dimension of the array.


*length1*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the first dimension of the array.


*length2*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the second dimension of the array.


*initializer*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T**


A function to produce elements of the array given the two indices.



**exceptions tag is not supported!!!!**
**The created array.**
## CAPS_REMARKS_MD
This function is named **InitializeBased** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0


## See Also
[Collections.Array2D Module &#40;F&#35;&#41;](Collections.Array2D+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

