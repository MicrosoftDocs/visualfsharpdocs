# Array.zeroCreate<'T> Function (F#)

Creates an array where the entries are initially the default value [Unchecked.defaultof&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/9ff97f2a-1bd4-4f4c-afbe-5886a74ab977).

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.zeroCreate : int -> 'T []

// Usage:
Array.zeroCreate count


```



#### CAPS_PARAMETERS_MD
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the array to create.



**The created array.**
## CAPS_REMARKS_MD
This function is named **ZeroCreate** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Array.zeroCreate.**


```



let arrayOfTenZeroes : int array = Array.zeroCreate 10


```



## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

