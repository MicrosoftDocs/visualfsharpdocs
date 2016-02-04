# Operators.( |> )<'T1,'U> Function (F#)

Apply a function to a value, the value being on the left, the function on the right.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( |> ) : 'T1 -> ('T1 -> 'U) -> 'U

// Usage:
arg |> func


```



#### CAPS_PARAMETERS_MD
*arg*
Type: **'T1**


The argument.


*func*
Type: **'T1 -&gt; 'U**


The function.



**The function result.**
## CAPS_REMARKS_MD
**The following example demonstrates the use of the forward pipe operator.**


```



    let append1 string1 = string1 + ".append1"
    let append2 string1 = string1 + ".append2"

    let result1 = "abc" |> append1
    printfn "\"abc\" |> append1 gives %A" result1

    let result2 = "abc" 
                  |> append1
                  |> append2
    printfn "result2: %A" result2

    [1; 2; 3]
    |> List.map (fun elem -> elem * 100)
    |> List.rev
    |> List.iter (fun elem -> printf "%d " elem)
    printfn ""


```



**"abc" |&gt; append1 gives "abc.append1"**
**result2: "abc.append1.append2"**
**300 200 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

