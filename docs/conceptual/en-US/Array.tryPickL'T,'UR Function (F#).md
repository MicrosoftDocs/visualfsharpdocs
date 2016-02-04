# Array.tryPick<'T,'U> Function (F#)

Applies the given function to successive elements, returning the first result where function returns **Some**. If the function does not return **Some** for any element, then **None** is returned.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.tryPick : ('T -> 'U option) -> 'T [] -> 'U option

// Usage:
Array.tryPick chooser array


```



#### CAPS_PARAMETERS_MD
*chooser*
Type: **'T -&gt; 'U option**


The function to transform the array elements into options.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The first transformed element that has an option value of Some, or None if the function does not return Some for any element.**
## CAPS_REMARKS_MD
This function is named **TryPick** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Array.tryPick to attempt to locate an element that satisfies a condition, and also return some additional data about the element, in this case the square root and the cube root.**


```



    let findPerfectSquareAndCube array1 =
        let delta = 1.0e-10
        let isPerfectSquare (x:int) =
            let y = sqrt (float x)
            abs(y - round y) < delta
        let isPerfectCube (x:int) =
            let y = System.Math.Pow(float x, 1.0/3.0)
            abs(y - round y) < delta
        // intFunction : (float -> float) -> int -> int
        // Allows the use of a floating point function with integers.
        let intFunction function1 number = int (round (function1 (float number)))
        let cubeRoot x = System.Math.Pow(x, 1.0/3.0)
        // testElement: int -> (int * int * int) option
        // Test an element to see whether it is a perfect square and a perfect
        // cube, and, if so, return the element, square root, and cube root
        // as an option value. Otherwise, return None.
        let testElement elem = 
            if isPerfectSquare elem && isPerfectCube elem then
                Some(elem, intFunction sqrt elem, intFunction cubeRoot elem)
            else None
        match Array.tryPick testElement array1 with
        | Some (n, sqrt, cuberoot) -> printfn "Found an element %d with square root %d and cube root %d." n sqrt cuberoot
        | None -> printfn "Did not find an element that is both a perfect square and a perfect cube."

    findPerfectSquareAndCube [| 1 .. 10 |]
    findPerfectSquareAndCube [| 2 .. 100 |]
    findPerfectSquareAndCube [| 100 .. 1000 |]
    findPerfectSquareAndCube [| 1000 .. 10000 |]
    findPerfectSquareAndCube [| 2 .. 50 |]


```



**Found an element 1 with square root 1 and cube root 1.**
**Found an element 64 with square root 8 and cube root 4.**
**Found an element 729 with square root 27 and cube root 9.**
**Found an element 4096 with square root 64 and cube root 16.**
**Did not find an element that is both a perfect square and a perfect cube.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

