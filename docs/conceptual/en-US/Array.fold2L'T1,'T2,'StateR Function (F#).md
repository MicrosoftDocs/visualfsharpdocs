# Array.fold2<'T1,'T2,'State> Function (F#)

Applies a function to pairs of elements drawn from the two collections, left-to-right, threading an accumulator argument through the computation. The two input arrays must have the same lengths, otherwise **T:System.ArgumentException** is raised.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.fold2 : ('State -> 'T1 -> 'T2 -> 'State) -> 'State -> 'T1 [] -> 'T2 [] -> 'State

// Usage:
Array.fold2 folder state array1 array2


```



#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T1 -&gt; 'T2 -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.



**exceptions tag is not supported!!!!**
**The final state.**
## CAPS_REMARKS_MD
This function is named **Fold2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Array.fold2.**


```



    // Use Array.fold2 to perform computations over two arrays (of equal size)
    // at the same time.
    // Example: Add the greater element at each array position.
    let sumGreatest array1 array2 =
        Array.fold2 (fun acc elem1 elem2 ->
            acc + max elem1 elem2) 0 array1 array2

    let sum = sumGreatest [| 1; 2; 3 |] [| 3; 2; 1 |]
    printfn "The sum of the greater of each pair of elements in the two arrays is %d." sum


```



**Output**
**The sum of the greater of each pair of elements in the two arrays is 8.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

