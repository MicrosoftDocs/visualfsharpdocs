# List.zip<'T1,'T2> Function (F#)

Combines the two lists into a list of pairs. The two lists must have equal lengths.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.zip : 'T1 list -> 'T2 list -> ('T1 * 'T2) list

// Usage:
List.zip list1 list2

```



#### Parameters
*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**A single list containing pairs of matching elements from the input lists.**
## Remarks
This function is named **Zip** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.zip.**
[!code-fsharp[Main](snippets/fslists/snippet13.fs)]
**Output**
**[(1, -1); (2, -2); (3; -3)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

