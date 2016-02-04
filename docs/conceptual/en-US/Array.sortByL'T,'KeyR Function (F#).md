# Array.sortBy<'T,'Key> Function (F#)

Sorts the elements of an array, using the given projection for the keys and returning a new array. Elements are compared using [Operators.compare](http://msdn.microsoft.com/en-us/library/295e1320-0955-4c3d-ac31-288fa80a658c).

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.sortBy : ('T -> 'Key) -> 'T [] -> 'T [] (requires comparison)

// Usage:
Array.sortBy projection array


```



#### CAPS_PARAMETERS_MD
*projection*
Type: **'T -&gt; 'Key**


The function to transform array elements into the type that is compared.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The sorted array.**
## CAPS_REMARKS_MD
This is not a stable sort, that is, the original order of equal elements is not necessarily preserved. For a stable sort, consider using [Seq.sort](http://msdn.microsoft.com/en-us/library/327ea595-e77c-4529-b61e-8c6cbf5ec92e).

This function is named **SortBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.sortBy.**


```



    let sortedArray2 = Array.sortBy (fun elem -> abs elem) [|1; 4; 8; -2; 5|]
    printfn "%A" sortedArray2


```



**Output**
**[|1; -2; 4; 5; 8|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

