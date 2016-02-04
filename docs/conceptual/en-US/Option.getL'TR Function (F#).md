# Option.get<'T> Function (F#)

Gets the value associated with the option.

**Namespace/Module Path:** Microsoft.FSharp.Core.Option

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
get : 'T option -> 'T

// Usage:
get option


```



#### CAPS_PARAMETERS_MD
*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**exceptions tag is not supported!!!!**
**The value within the option.**
## CAPS_REMARKS_MD
This function is named **GetValue** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.get.**


```



    let printOption opt =
        if (Option.isSome opt) then
            printfn "%A" <| Option.get opt
        else ()
    printOption (Some(1))
    printOption (Some("xyz"))
    printOption (None)
    printOption (Some(1.0))


```



**Output**
**1"xyz"1.0**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

