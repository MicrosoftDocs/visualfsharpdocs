# Option.bind<'T,'U> Function (F#)

Invokes a function on an optional value that itself yields an option.

**Namespace/Module Path**: Microsoft.FSharp.Core.Option

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
bind : ('T -> 'U option) -> 'T option -> 'U option

// Usage:
bind binder option


```



#### CAPS_PARAMETERS_MD
*binder*
Type: **'T -&gt; 'U**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


A function that takes the value of type T from an option and transforms it into an option containing a value of type U.


*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**An option of the output type of the binder.**
## CAPS_REMARKS_MD
The expression **Option.bind f inp** evaluates to **match inp with None -&gt; None | Some x -&gt; f x.**

This function is named **Bind** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.bind.**


```



    let stringOpt1 = Some("Mirror Image")
    let stringOpt2 = None
    let reverse (string : System.String) =
        match string with
        | "" -> None
        | s -> Some(new System.String(string.ToCharArray() |> Array.rev))
        
    let result1 = Option.bind reverse stringOpt1
    printfn "%A" result1
    let result2 = Option.bind reverse stringOpt2
    printfn "%A" result2


```



**Output**
**Some "egamI rorriM"&lt;null&gt;**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

