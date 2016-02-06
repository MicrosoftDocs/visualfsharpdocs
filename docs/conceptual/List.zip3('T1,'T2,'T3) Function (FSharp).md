# List.zip3<'T1,'T2,'T3> Function (F#)

Combines the three lists into a list of triples. The lists must have equal lengths.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
List.zip3 : 'T1 list -> 'T2 list -> 'T3 list -> ('T1 * 'T2 * 'T3) list

// Usage:
List.zip3 list1 list2 list3
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.


*list3*
Type: **'T3**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The third input list.



**A single list containing triples of matching elements from the input lists.**
## Remarks
This function is named **Zip3** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.zip3.**
[!code-fsharp[Main](snippets/fslists/snippet40.fs)]
**Output**
**[(1, -1, 0); (2, -2, 0); (3, -3, 0)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

