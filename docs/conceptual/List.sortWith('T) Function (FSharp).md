# List.sortWith<'T> Function (F#)

Sorts the given list using the given comparison function.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.sortWith : ('T -> 'T -> int) -> 'T list -> 'T list

// Usage:
List.sortWith comparer list

```



#### Parameters
*comparer*
Type: **'T -&gt; 'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The function to compare the list elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The sorted list.**
## Remarks
This is a stable sort, that is, the original order of equal elements is preserved.

This function is named **SortWith** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use List.sortWith.**
[!code-fsharp[Main](snippets/fslists/snippet62.fs)]
**Output**
**Before sorting:**
**["&lt;&gt;"; "&amp;"; "&amp;&amp;"; "&amp;&amp;&amp;"; "&lt;"; "&gt;"; "|"; "||"; "|||"]**
**After sorting:**
**["&amp;"; "|"; "&lt;"; "&gt;"; "&amp;&amp;"; "||"; "&lt;&gt;"; "&amp;&amp;&amp;"; "|||"]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

