# Option.count<'T> Function (F#)

Evaluates the equivalent of [Set.count](http://msdn.microsoft.com/en-us/library/54acc46d-af76-474e-9ff7-bd4bd6b7b4c4) for an option.

**Namespace/Module Path:** Microsoft.FSharp.Core.Option

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
count : 'T option -> int

// Usage:
count option


```



#### CAPS_PARAMETERS_MD
*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**A zero if the option is None, a one otherwise.**
## CAPS_REMARKS_MD
The expression **count inp** evaluates to **match inp with None -&gt; 0 | Some _ -&gt; 1**.

This function is named **Count** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.count.**


```



    let opt1 = Some("test")
    let opt2 = None
    printfn "%A %A" (Option.count opt1) (Option.count opt2)

    // Use Option.count to count the number of Some values in
    // an array of options.
    let getCount (array1 : int option array) =
        Array.fold (fun state elem -> state + Option.count elem) 0 array1
    let testArray1 = [| Some(10); None; Some(1); None; None; Some(56) |]
    let testArray2 = [| for i in 1 .. 10 do if i % 2 = 0 then yield Some(i) else yield None |]
    printfn "%d" <| getCount testArray1
    printfn "%d" <| getCount testArray2


```



**Output**
**1 035**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

