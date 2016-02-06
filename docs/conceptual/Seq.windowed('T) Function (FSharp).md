# Seq.windowed<'T> Function (F#)

Returns a sequence that yields sliding windows of containing elements drawn from the input sequence. Each window is returned as a fresh array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Seq.windowed : int -> seq<'T> -> seq<'T []>

// Usage:
Seq.windowed windowSize source
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*windowSize*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of elements in each window.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
This function is named **Windowed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of Seq.windowed as part of a computation of a moving average for a sequence of numbers.**
[!code-fsharp[Main](snippets/fssequences/snippet180.fs)]
**Initial sequence:**
**1.0 1.5 2.0 1.5 1.0 1.5**
**Windows of length 3:**
**[|1.0; 1.5; 2.0|] [|1.5; 2.0; 1.5|] [|2.0; 1.5; 1.0|] [|1.5; 1.0; 1.5|]**
**Moving average:**
**1.5 1.666666667 1.5 1.333333333**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

