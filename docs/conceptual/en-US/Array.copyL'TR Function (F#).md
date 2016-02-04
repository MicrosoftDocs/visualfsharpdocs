# Array.copy<'T> Function (F#)

Builds a new array that contains the elements of the given array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.copy : 'T [] -> 'T []

// Usage:
Array.copy array


```



#### CAPS_PARAMETERS_MD
*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**A copy of the input array.**
## CAPS_REMARKS_MD
This function is named **Copy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.copy.**


```



    let array1 = [| 1 .. 10 |]
    let array2 = Array.copy array1
    printfn "%A\n%A" array1 array2


```



**Output**
**[|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]**
**[|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

