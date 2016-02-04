# List.permute<'T> Function (F#)

Returns a list with all elements permuted according to the specified permutation.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.permute : (int -> int) -> 'T list -> 'T list

// Usage:
List.permute indexMap list


```



#### CAPS_PARAMETERS_MD
*indexMap*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The function to map input indices to output indices.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The permuted list.**
## CAPS_REMARKS_MD
This function is named **Permute** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code demonstrates how to use List.permute.**


```



    let printPermutation n list1 =
        let length = List.length list1
        if (n > 0 && n < length) then
            List.permute (fun index -> (index + n) % length) list1
        else
            list1
        |> printfn "%A"
    let list1 = [ 1 .. 5 ]
    // There are 5 valid permutations of list1, with n from 0 to 4.
    for n in 0 .. 4 do
        printPermutation n list1


```



**Output**
**[1; 2; 3; 4; 5]**
**[5; 1; 2; 3; 4]**
**[4; 5; 1; 2; 3]**
**[3; 4; 5; 1; 2]**
**[2; 3; 4; 5; 1]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

