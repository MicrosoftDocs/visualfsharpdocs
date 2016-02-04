# Seq.delay<'T> Function (F#)

Returns a sequence that is built from the given delayed specification of a sequence.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Seq.delay : (unit -> seq<'T>) -> seq<'T>

// Usage:
Seq.delay generator


```



#### CAPS_PARAMETERS_MD
*generator*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The generating function for the sequence.



**The resulting sequence.**
## CAPS_REMARKS_MD
The input function is evaluated each time an **IEnumerator** for the sequence is requested.

This function is named **Delay** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.delay to delay the evaluation of a sequence that is created from a collection that is normally evaluated immediately.**


```



    // Normally sequences are evaluated lazily.  In this case,
    // the sequence is created from a list, which is not evaluated
    // lazily. Therefore, without Seq.delay, the elements would be
    // evaluated at the time of the call to makeSequence.
    let makeSequence function1 maxNumber = Seq.delay (fun () ->
        let rec loop n acc =
            printfn "Evaluating %d." n
            match n with
            | 0 -> acc
            | n -> (function1 n) :: loop (n - 1) acc
        loop maxNumber []
        |> Seq.ofList)
    printfn "Calling makeSequence."
    let seqSquares = makeSequence (fun x -> x * x) 4          
    let seqCubes = makeSequence (fun x -> x * x * x) 4
    printfn "Printing sequences."
    printfn "Squares:"
    seqSquares |> Seq.iter (fun x -> printf "%d " x)
    printfn "\nCubes:"
    seqCubes |> Seq.iter (fun x -> printf "%d " x)                       


```



**Output**
**Calling makeSequence.**
**Printing sequences.**
**Squares:**
**Evaluating 4.**
**Evaluating 3.**
**Evaluating 2.**
**Evaluating 1.**
**Evaluating 0.16 9 4 1 Cubes:Evaluating 4.**
**Evaluating 3.**
**Evaluating 2.**
**Evaluating 1.**
**Evaluating 0.**
**64 27 8 1****The following code example is equivalent to the previous example, except that it does not use Seq.delay. Notice the difference in the output.**


```



    // Compare the output of this example with that of the previous.
    // Notice that Seq.delay delays the
    // execution of the loop until the sequence is used.
    let makeSequence function1 maxNumber =
        let rec loop n acc =
            printfn "Evaluating %d." n
            match n with
            | 0 -> acc
            | n -> (function1 n) :: loop (n - 1) acc
        loop maxNumber []
        |> Seq.ofList
    printfn "Calling makeSequence."
    let seqSquares = makeSequence (fun x -> x * x) 4          
    let seqCubes = makeSequence (fun x -> x * x * x) 4
    printfn "Printing sequences."
    printfn "Squares:"
    seqSquares |> Seq.iter (fun x -> printf "%d " x)
    printfn "\nCubes:"
    seqCubes |> Seq.iter (fun x -> printf "%d " x)


```



**Output**
**Calling makeSequence.**
**Evaluating 4.**
**Evaluating 3.**
**Evaluating 2.**
**Evaluating 1.**
**Evaluating 0.**
**Evaluating 4.**
**Evaluating 3.**
**Evaluating 2.**
**Evaluating 1.**
**Evaluating 0.**
**Printing sequences.**
**Squares:**
**16 9 4 1**
**Cubes:**
**64 27 8 1**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

