# Option.forall<'T> Function (F#)

Evaluates the equivalent of [List.forall](http://msdn.microsoft.com/en-us/library/e11a5233-d612-40ac-833b-d5cf496900b7) for an option type.

**Namespace/Module Path**: Microsoft.FSharp.Core.Option

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
forall : ('T -> bool) -> 'T option -> bool

// Usage:
forall predicate option


```



#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function that evaluates to a Boolean when given a value from the option type.


*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**true if the option is None, otherwise it returns the result of applying the predicate to the option value.**
## CAPS_REMARKS_MD
The expression **forall p inp** evaluates to **match inp with None -&gt; true | Some x -&gt; p x**.

This function is named **ForAll** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.forall.**


```



    let isEven opt =
        Option.forall (fun elem -> elem % 2 = 0) opt
    printfn "%b" <| isEven (Some(2))
    printfn "%b" <| isEven None
    printfn "%b" <| isEven (Some(1))

    // Use this function with an array of int options.
    let forAllOptions function1 = List.forall (fun opt -> Option.forall function1 opt)
    let list1 = [ for i in 1 .. 10 do yield Some(i) ]
    let list2 = [ for i in 1 .. 10 do yield if (i % 2) = 0 then Some(i) else None ]
    let list3 = [ for i in 1 .. 10 do yield if (i % 2) = 1 then Some(i) else None ]
    let evalList list = printfn "%b" <| forAllOptions (fun value -> value % 2 = 0) list
    let lists = [ list1; list2; list3 ]
    List.iter evalList lists


```



**Output**
**truetruefalsefalsetruefalse**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

