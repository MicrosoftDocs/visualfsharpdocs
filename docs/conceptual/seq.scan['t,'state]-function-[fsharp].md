# Seq.scan<'T,'State> Function (F#)

Like [Seq.fold](http://msdn.microsoft.com/en-us/library/30c4c95a-9563-4c96-bbe1-f7aacfd026e3), but computes on-demand and returns the sequence of intermediate and final results.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
Seq.scan : ('State -> 'T -> 'State) -> 'State -> seq<'T> -> seq<'State>

// Usage:
Seq.scan folder state source


```





#### Parameters
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
**The result sequence.**
## Remarks
This function is named **Scan** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

