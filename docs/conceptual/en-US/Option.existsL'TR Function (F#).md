# Option.exists<'T> Function (F#)

Evaluates the equivalent of [List.exists](http://msdn.microsoft.com/en-us/library/15a3ebd5-98f0-44c0-8220-7dedec3e68a8) for an option.

**Namespace/Module Path:** Microsoft.FSharp.Core.Option

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
exists : ('T -> bool) -> 'T option -> bool

// Usage:
exists predicate option


```



#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function that evaluates to a Boolean when given a value from the option type.


*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**Returns false if the option is None, otherwise it returns the result of applying the predicate to the option value.**
## CAPS_REMARKS_MD
The expression **exists p inp** evaluates to **match inp with None -&gt; false | Some x -&gt; p x**.

This function is named **Exists** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.exists.**


```



    let isValue opt value =
        Option.exists (fun elem -> elem = value) opt
    let testOpt1 = Some(10)
    let testOpt2 = Some(11)
    let testOpt3 = None
    printfn "%b" <| isValue testOpt1 10
    printfn "%b" <| isValue testOpt2 10
    printfn "%b" <| isValue testOpt3 10


```



**Output**
**truefalsefalse**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

