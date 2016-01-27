# Lazy.CreateFromValue<'T> Extension Method (F#)

Creates a lazy computation that evaluates to the given value when forced.

**Namespace/Module Path:** Microsoft.FSharp.Control.LazyExtensions

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
type System.Lazy with
member static CreateFromValue : Lazy<'T>

// Usage:
lazy.CreateFromValue (value)
```

#### CAPS_PARAMETERS_MD
*value*
Type: **'T**


The input value.



**The created [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489) object.**
## CAPS_REMARKS_MD
**The following code example illustrates the use of the Lazy.CreateFromValue extension method. In this example, a dictionary is used to store previously computed values. When the factorial function is called, if the value is already computed, then Lazy.CreateFromValue is called with the cached result. If the value is not already computed, then Lazy.Create is used.**
```


    let cacheMap = new System.Collections.Generic.Dictionary<_, _>()
    cacheMap.Add(0, 1I)
    cacheMap.Add(1, 1I)

    let lazyFactorial n =
        let rec factorial n =
            if cacheMap.ContainsKey(n) then cacheMap.[n] else
            let result = new System.Numerics.BigInteger(n) * factorial (n - 1)
            cacheMap.Add(n, result)
            result
        if cacheMap.ContainsKey(n) then
            printfn "Reading factorial for %d from cache." n
            Lazy.CreateFromValue(cacheMap.[n])
        else
            printfn "Creating lazy factorial for %d." n
            Lazy.Create (fun () ->
                printfn "Evaluating lazy factorial for %d." n
                let result = factorial n
                result)

    printfn "%A" ((lazyFactorial 12).Force())
    printfn "%A" ((lazyFactorial 10).Force())
    printfn "%A" ((lazyFactorial 11).Force())
    printfn "%A" ((lazyFactorial 30).Force())
```

**Output**
**Creating lazy factorial for 12.**
**Evaluating lazy factorial for 12.**
**479001600**
**Reading factorial for 10 from cache.**
**3628800**
**Reading factorial for 11 from cache.**
**39916800**
**Creating lazy factorial for 30.**
**Evaluating lazy factorial for 30.**
**265252859812191058636308480000000**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.LazyExtensions Module &#40;F&#35;&#41;](Control.LazyExtensions+Module+%28F%23%29.md)

[Lazy Computations &#40;F&#35;&#41;](Lazy+Computations+%28F%23%29.md)

