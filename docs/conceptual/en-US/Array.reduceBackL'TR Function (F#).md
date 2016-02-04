# Array.reduceBack<'T> Function (F#)

Applies a function to each element of the array, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN** then computes **f i0 (...(f iN-1 iN))**. Raises **T:System.ArgumentException** if the array has size zero.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.reduceBack : ('T -> 'T -> 'T) -> 'T [] -> 'T

// Usage:
Array.reduceBack reduction array


```



#### CAPS_PARAMETERS_MD
*reduction*
Type: **'T -&gt; 'T -&gt; 'T**


The function to reduce a pair of elements to a single element.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**exceptions tag is not supported!!!!**
**The final result of the reductions.**
## CAPS_REMARKS_MD
This function is named **ReduceBack** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.

**The following code example compares [Array.reduce](http://msdn.microsoft.com/en-us/library/fd62a985-89fe-4f49-a9d4-0c808ac6749d) and Array.reduceBack.**


```



    // Computes ((1 - 2) - 3) - 4 = -8
    Array.reduce (fun elem acc -> elem - acc) [| 1; 2; 3; 4 |]
    |> printfn "%A"
    // Computes 1 - (2 - (3 - 4)) = -2
    Array.reduceBack (fun elem acc -> elem - acc) [| 1; 2; 3; 4 |]
    |> printfn "%A"


```



**Output**
**-8**
**-2**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

