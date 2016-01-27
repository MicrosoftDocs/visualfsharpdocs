# Array.permute<'T> Function (F#)

Returns an array with all elements permuted according to the specified permutation.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.permute : (int -> int) -> 'T [] -> 'T []

// Usage:
Array.permute indexMap array
```

#### CAPS_PARAMETERS_MD
*indexMap*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The function that maps input indices to output indices.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The permuted array.**
## CAPS_REMARKS_MD
This function is named **Permute** in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.permute.**
```

    let printPermutation n array1 =
        let length = Array.length array1
        if (n > 0 && n < length) then
            Array.permute (fun index -> (index + n) % length) array1
        else
            array1
        |> printfn "%A"
    let array1 = [| 1 .. 5 |]
    // There are 5 valid permutations of array1, with n from 0 to 4.
    for n in 0 .. 4 do
        printPermutation n array1 
```

**Output**
**[|1; 2; 3; 4; 5|]**
**[|5; 1; 2; 3; 4|]**
**[|4; 5; 1; 2; 3|]**
**[|3; 4; 5; 1; 2|]**
**[|2; 3; 4; 5; 1|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

