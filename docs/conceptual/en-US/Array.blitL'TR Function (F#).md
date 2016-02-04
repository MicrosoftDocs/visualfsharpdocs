# Array.blit<'T> Function (F#)

Reads a range of elements from the first array and writes them into the second.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.blit : 'T [] -> int -> 'T [] -> int -> int -> unit

// Usage:
Array.blit source sourceIndex target targetIndex count


```



#### CAPS_PARAMETERS_MD
*source*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The source array.


*sourceIndex*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The starting index of the source array.


*target*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The target array.


*targetIndex*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The starting index of the target array.


*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of elements to copy.




## CAPS_REMARKS_MD
This function is named **CopyTo** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of Array.blit.**


```



    let array1 = [| 1 .. 10 |]
    let array2 = Array.zeroCreate 20
    // Copy 4 elements from index 3 of array1 to index 5 of array2.
    Array.blit array1 3 array2 5 4
    printfn "%A" array2


```



**Output**
**[|0; 0; 0; 0; 0; 4; 5; 6; 7; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

