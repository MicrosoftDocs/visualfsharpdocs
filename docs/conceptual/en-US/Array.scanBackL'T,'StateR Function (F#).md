# Array.scanBack<'T,'State> Function (F#)

Like [Array.foldBack](http://msdn.microsoft.com/en-us/library/1121a453-dead-4711-a0ca-cc147752989c), but returns both the intermediate and final results.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.scanBack : ('T -> 'State -> 'State) -> 'T [] -> 'State -> 'State []

// Usage:
Array.scanBack folder array state


```



#### CAPS_PARAMETERS_MD
*folder*
Type: **'T -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.


*state*
Type: **'State**


The initial state.



**The array of state values.**
## CAPS_REMARKS_MD
This function is named **ScanBack** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code contrasts the behavior of [Array.scan](http://msdn.microsoft.com/en-us/library/f6893608-9146-450d-9ebb-a0016803fbb0) and Array.scanBack.**


```



    // An array of functions that transform 
    // integers. (int -> int)
    let ops1 =
     [| fun x -> x + 1
        fun x -> x + 2
        fun x -> x - 5 |]

    let ops2 =
     [| fun x -> x + 1
        fun x -> x * 5
        fun x -> x * x |]

    // Compare scan and scanBack, which apply the
    // operations in the opposite order.
    let compareOpOrder ops x0 =
        let xs1 = Array.scan (fun x op -> op x) x0 ops
        let xs2 = Array.scanBack (fun op x -> op x) ops x0

        // Print the intermediate results
        let xs = Array.zip xs1 (Array.rev xs2)
        for (x1, x2) in xs do
            printfn "%10d %10d" x1 x2
        printfn ""

    compareOpOrder ops1 10
    compareOpOrder ops2 10


```



**Output**
**10         10**
**11          5**
**13          7**
**8          8**
**10         10**
**11        100**
**55        500**
**3025        501**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

