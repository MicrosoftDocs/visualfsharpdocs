# List.foldBack<'T,'State> Function (F#)

Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN**, then this function computes **f i0 (...(f iN s))**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.foldBack : ('T -> 'State -> 'State) -> 'T list -> 'State -> 'State

// Usage:
List.foldBack folder list state
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'T -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.


*state*
Type: **'State**


The initial state.



**The final state value.**
## CAPS_REMARKS_MD
This function is named **FoldBack** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.foldBack.**
**[!CODE [FsLists#41](../CodeSnippet/VS_Snippets_Fsharp/fslists/FSharp/fs/program.fs#41)]**
**Output**
**6**
**[1; 2; 3; 4; 5; 6; 7; 8; 9; 10]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

