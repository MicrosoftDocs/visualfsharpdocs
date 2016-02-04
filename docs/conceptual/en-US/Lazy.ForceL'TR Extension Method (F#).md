# Lazy.Force<'T> Extension Method (F#)

Forces the execution of this value and returns its result. Same as **P:System.Lazy&#96;1.Value**. Mutual exclusion is used to prevent other threads from also computing the value.

**Namespace/Module Path**: Microsoft.FSharp.Control.LazyExtensions

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
type System.Lazy with
member Force : unit -> 'T

// Usage:
lazy.Force ()


```


**The value of the [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489) object.**
## CAPS_REMARKS_MD
**The following code illustrates the use of the Force extension method.**


```



    let lazyFactorial n = Lazy.Create (fun () ->
        let rec factorial n =
            match n with
            | 0 | 1 -> 1
            | n -> n * factorial (n - 1)
        factorial n)
    let printLazy (lazyVal:Lazy<int>) =
        if (lazyVal.IsValueCreated) then
            printfn "Retrieving stored value: %d" (lazyVal.Value)
        else
            printfn "Computing value: %d" (lazyVal.Force())
    let lazyVal1 = lazyFactorial 12
    let lazyVal2 = lazyFactorial 10
    lazyVal1.Force() |> ignore
    printLazy lazyVal1
    printLazy lazyVal2


```



**The output indicates that when Force is called to create the value for lazyVal1, the computed value is retrieved when printing the values.**
**Retrieving stored value: 479001600**
**Computing value: 3628800**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.LazyExtensions Module &#40;F&#35;&#41;](Control.LazyExtensions+Module+%28F%23%29.md)

[Lazy Computations &#40;F&#35;&#41;](Lazy+Computations+%28F%23%29.md)

