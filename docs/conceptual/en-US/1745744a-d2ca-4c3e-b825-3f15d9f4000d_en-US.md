# Array.zip3<'T1,'T2,'T3> Function (F#)

Combines three arrays into an array of tuples with three elements. The three arrays must have equal lengths, otherwise an **T:System.ArgumentException** is raised.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.zip3 : 'T1 [] -> 'T2 [] -> 'T3 [] -> ('T1 * 'T2 * 'T3) []

// Usage:
Array.zip3 array1 array2 array3
```

#### CAPS_PARAMETERS_MD
*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.


*array3*
Type: **'T3**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The third input array.



**exceptions tag is not supported!!!!**
**The array of tupled elements.**
## CAPS_REMARKS_MD
This function is named **Zip3** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Array.zip3.**
```

    let array1 = [| 1; 2; 3 |]
    let array2 = [| -1; -2; -3 |]
    let array3 = [| "horse"; "dog"; "elephant" |]
    let arrayZip3 = Array.zip3 array1 array2 array3
    printfn "%A" arrayZip3
```

**Output**
**[|(1, -1, "horse"); (2, -2, "dog"); (3, -3, "elephant")|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

