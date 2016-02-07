# List.tryFindIndex<'T> Function (F#)

Returns the index of the first element in the list that satisfies the given predicate. Return **None** if no such element exists.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.tryFindIndex : ('T -> bool) -> 'T list -> int option

// Usage:
List.tryFindIndex predicate list

```



#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The index of the first element for which the predicate returns true, or None if every element evaluates to false.**
## Remarks
This function is named **TryFindIndex** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.tryFind and List.tryFindIndex.**
[!code-fsharp[Main](snippets/fslists/snippet10.fs)]
**Output**
**The first even value is 22.**
**The first even value is at position 8.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

