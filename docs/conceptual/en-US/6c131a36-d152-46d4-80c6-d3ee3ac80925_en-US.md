# List.scanBack<'T,'State> Function (F#)

Like [List.foldBack](http://msdn.microsoft.com/en-us/library/b9a58e66-efe1-445f-a90c-ac9ffb9d40c7), but returns both the intermediate and final results.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.scanBack : ('T -> 'State -> 'State) -> 'T list -> 'State -> 'State list

// Usage:
List.scanBack folder list state
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'T -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.


*state*
Type: **'State**


The initial state.



**The list of states.**
## CAPS_REMARKS_MD
This function is named **ScanBack** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use List.scanBack, and also contrasts its behavior with [List.scan](http://msdn.microsoft.com/en-us/library/21f636db-885c-4a72-970e-e3841f33a1b8).**
```

    // A list of functions that transform 
    // integers. (int -> int)
    let ops1 =
     [ (fun x -> x + 1), "add 1"
       (fun x -> x + 2), "add 2"
       (fun x -> x - 5), "subtract 5" ]

    let ops2 =
     [ (fun x -> x + 1), "add 1"
       (fun x -> x * 5), "multiply by 5"
       (fun x -> x * x), "square" ]

    // Compare scan and scanBack, which apply the
    // operations in the opposite order.
    let compareOpOrder ops x0 =
        let ops, opNames = List.unzip ops
        let xs1 = List.scan (fun x op -> op x) x0 ops
        let xs2 = List.scanBack (fun op x -> op x) ops x0

        printfn "Operations:"
        opNames |> List.iter (fun opName -> printf "%s  " opName)
        printfn ""

        // Print the intermediate results.
        let xs = List.zip xs1 (List.rev xs2)
        printfn "List.scan List.scanBack"
        for (x1, x2) in xs do
            printfn "%10d %10d" x1 x2
        printfn ""

    compareOpOrder ops1 10
    compareOpOrder ops2 10
```

**Output**
**Operations:**
**add 1  add 2  subtract 5**
**List.scan List.scanBack**
**10         10**
**11          5**
**13          7**
**8          8**
**Operations:**
**add 1  multiply by 5  square**
**List.scan List.scanBack**
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
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

