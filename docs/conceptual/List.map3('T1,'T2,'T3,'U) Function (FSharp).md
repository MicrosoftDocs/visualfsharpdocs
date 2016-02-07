# List.map3<'T1,'T2,'T3,'U> Function (F#)

Creates a new collection whose elements are the results of applying the given function to the corresponding elements of the three collections simultaneously.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.map3 : ('T1 -> 'T2 -> 'T3 -> 'U) -> 'T1 list -> 'T2 list -> 'T3 list -> 'U list

// Usage:
List.map3 mapping list1 list2 list3

```



#### Parameters
*mapping*
Type: **'T1 -&gt; 'T2 -&gt; 'T3 -&gt; 'U**


The function to transform triples of elements from the input lists.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.


*list3*
Type: **'T3**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The third input list.



**The list of transformed elements.**
## Remarks
This function is named **Map3** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.map3.**
[!code-fsharp[Main](snippets/fslists/snippet35.fs)]
**Output**
**[7; 10; 13]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

