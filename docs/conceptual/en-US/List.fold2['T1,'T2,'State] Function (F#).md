# List.fold2<'T1,'T2,'State> Function (F#)

Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is **f** and the elements are **i0...iN** and **j0...jN** then computes **f (... (f s i0 j0)...) iN jN**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
List.fold2 : ('State -> 'T1 -> 'T2 -> 'State) -> 'State -> 'T1 list -> 'T2 list -> 'State

// Usage:
List.fold2 folder state list1 list2
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*folder*
Type: **'State -&gt; 'T1 -&gt; 'T2 -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**The final state value.****exceptions tag is not supported!!!!**

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Fold2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.fold2.**
**[!CODE [FsLists#28](../CodeSnippet/VS_Snippets_Fsharp/fslists/FSharp/fs/program.fs#28)]**
**Output**
**The sum of the greater of each pair of elements in the two lists is 8.****The following code example illustrates the use of List.fold2 to compute the ending balance in a bank account after a series of transactions. The two input lists represent the transaction type (deposit or withdrawal) and the transaction amount.**
**[!CODE [FsLists#29](../CodeSnippet/VS_Snippets_Fsharp/fslists/FSharp/fs/program.fs#29)]**
**Output**
**1205.000000**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

