# List.mapi2<'T1,'T2,'U> Function (F#)

Like [List.mapi](http://msdn.microsoft.com/en-us/library/284b9234-3d26-409b-b328-ac79638d9e14), but mapping corresponding elements from two lists of equal length.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.mapi2 : (int -> 'T1 -> 'T2 -> 'U) -> 'T1 list -> 'T2 list -> 'U list

// Usage:
List.mapi2 mapping list1 list2

```



#### Parameters
*mapping*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T1 -&gt; 'T2 -&gt; 'U**


The function to transform pairs of elements from the two lists and their index.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**The list of transformed elements.**
## Remarks
This function is named **MapIndexed2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.mapi2.**
[!code-fsharp[Main](snippets/fslists/snippet37.fs)]
**Output**
**[0; 7; 18]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

