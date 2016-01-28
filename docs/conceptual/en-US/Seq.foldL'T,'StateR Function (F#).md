# Seq.fold<'T,'State> Function (F#)

Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN**, then this function computes **f (... (f s i0)...) iN**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.fold : ('State -> 'T -> 'State) -> 'State -> seq<'T> -> 'State

// Usage:
Seq.fold folder state source
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T -&gt; 'State**


A function that updates the state with each element from the sequence.


*state*
Type: **'State**


The initial state.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The final result of the computation.**
## CAPS_REMARKS_MD
This function is named **Fold** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.fold to implement a function that computes the sum of the elements of a sequence.**
```

    let sumSeq sequence1 = Seq.fold (fun acc elem -> acc + elem) 0 sequence1
    Seq.init 10 (fun index -> index * index)
    |> sumSeq
    |> printfn "The sum of the elements is %d."
```

**Output**
**The sum of the elements is 285.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

