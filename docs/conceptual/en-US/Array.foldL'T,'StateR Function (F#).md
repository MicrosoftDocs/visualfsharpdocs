# Array.fold<'T,'State> Function (F#)

Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN** then computes **f (... (f s i0)...) iN.**

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.fold : ('State -> 'T -> 'State) -> 'State -> 'T [] -> 'State

// Usage:
Array.fold folder state array


```



#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The final state.**
## CAPS_REMARKS_MD
This function is named **Fold** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.fold.**


```



    let sumArray array = Array.fold (fun acc elem -> acc + elem) 0 array
    printfn "Sum of the elements of array %A is %d." [ 1 .. 3 ] (sumArray [| 1 .. 3 |])

    // The following example computes the average of a array.
    let averageArray array = (Array.fold (fun acc elem -> acc + float elem) 0.0 array / float array.Length)

    // The following example computes the standard deviation of a array.
    // The standard deviation is computed by taking the square root of the
    // sum of the variances, which are the differences between each value
    // and the average.
    let stdDevArray array =
        let avg = averageArray array
        sqrt (Array.fold (fun acc elem -> acc + (float elem - avg) ** 2.0 ) 0.0 array / float array.Length)

    let testArray arrayTest =
        printfn "Array %A average: %f stddev: %f" arrayTest (averageArray arrayTest) (stdDevArray arrayTest)

    testArray [|1; 1; 1|]
    testArray [|1; 2; 1|]
    testArray [|1; 2; 3|]

    // Array.fold is the same as to Array.iter when the accumulator is not used.
    let printArray array = Array.fold (fun acc elem -> printfn "%A" elem) () array
    printArray [|0.0; 1.0; 2.5; 5.1 |]


```



**Output**
**Sum of the elements of array [1; 2; 3] is 6.**
**Array [|1; 1; 1|] average: 1.000000 stddev: 0.000000**
**Array [|1; 2; 1|] average: 1.333333 stddev: 0.471405**
**Array [|1; 2; 3|] average: 2.000000 stddev: 0.816497**
**0.0**
**1.0**
**2.5**
**5.1**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

