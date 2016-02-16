# List.foldBack2<'T1,'T2,'State> Function (F#)

Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is **f** and the elements are **i0...iN** and **j0...jN**, then this function computes **f i0 j0 (...(f iN jN s))**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.foldBack2 : ('T1 -> 'T2 -> 'State -> 'State) -> 'T1 list -> 'T2 list -> 'State -> 'State

// Usage:
List.foldBack2 folder list1 list2 state

```



#### Parameters
*folder*
Type: **'T1 -&gt; 'T2 -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.


*state*
Type: **'State**


The initial state.



**The final state value.****exceptions tag is not supported!!!!**

## Remarks
This function is named **FoldBack2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

The following code examples illustrate the difference between [List.fold2](http://msdn.microsoft.com/en-us/library/6cfcd043-a65d-4423-805a-2ab234cb5343) and **List.foldBack2**.

[!code-fsharp[Main](snippets/fslists/snippet31.fs)]
**Output**
[!code-fsharp[Main](snippets/fslists/snippet32.fs)]
**Output**
**1205.833333**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

