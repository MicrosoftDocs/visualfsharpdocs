# List.forall<'T> Function (F#)

Tests if all elements of the collection satisfy the given predicate.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
List.forall : ('T -> bool) -> 'T list -> bool

// Usage:
List.forall predicate list


```





#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**true if all of the elements satisfy the predicate. Otherwise, returns false.**
## Remarks
The predicate is applied to the elements of the input list. If any application returns **false** then the overall result is **false** and no further elements are tested. Otherwise, **true** is returned.

This function is named **ForAll** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.forall.**
[!code-fsharp[Main](snippets/fslists/snippet3.fs)]
**Output**
**true**
**false**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

