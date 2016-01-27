# Array.fill<'T> Function (F#)

Fills a range of elements of the array with the given value.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.fill : 'T [] -> int -> int -> 'T -> unit

// Usage:
Array.fill target targetIndex count value
```

#### CAPS_PARAMETERS_MD
*target*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The target array.


*targetIndex*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index of the first element to set.


*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of elements to set.


*value*
Type: **'T**


The value to set.




## CAPS_REMARKS_MD
This function is named **Fill** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Array.fill to overwrite a section of an array with zeroes.**
```

let arrayFill1 = [| 1 .. 25 |]
Array.fill arrayFill1 2 20 0
printfn "%A" arrayFill1
```

**[|1; 2; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 23; 24; 25|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

