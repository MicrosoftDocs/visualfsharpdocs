# Array.tryFind<'T> Function (F#)

Returns the first element for which the given function returns **true**. Return **None** if no such element exists.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.tryFind : ('T -> bool) -> 'T [] -> 'T option

// Usage:
Array.tryFind predicate array
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The first element that satisfies the predicate, or None.**
## CAPS_REMARKS_MD
This function is named **TryFind** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Array.tryFind to attempt to locate array elements that are both perfect cubes and perfect squares.**
```

    let delta = 1.0e-10
    let isPerfectSquare (x:int) =
        let y = sqrt (float x)
        abs(y - round y) < delta
    let isPerfectCube (x:int) =
        let y = System.Math.Pow(float x, 1.0/3.0)
        abs(y - round y) < delta
    let lookForCubeAndSquare array1 =
        let result = Array.tryFind (fun elem -> isPerfectSquare elem && isPerfectCube elem) array1
        match result with
        | Some x -> printfn "Found an element: %d" x
        | None -> printfn "Failed to find a matching element."

    lookForCubeAndSquare [| 1 .. 10 |]
    lookForCubeAndSquare [| 100 .. 1000 |]
    lookForCubeAndSquare [| 2 .. 50 |]
```

**Found an element: 1**
**Found an element: 729**
**Failed to find a matching element.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

