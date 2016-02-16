# Set.filter<'T> Function (F#)

Returns a new collection containing only the elements of the collection for which the given predicate returns **true**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Set

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Set.filter : ('T -> bool) -> Set<'T> -> Set<'T> (requires comparison)

// Usage:
Set.filter predicate set

```



#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test set elements.


*set*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The input set.



**The set containing only the elements for which predicate returns true.**
## Remarks
This function is named **Filter** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of the Set.filter function.**
[!code-fsharp[Main](snippets/fssets/snippet3.fs)]
**Output**
**set [2; 4; 6; 8; 10]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

