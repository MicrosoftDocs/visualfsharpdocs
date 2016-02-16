# List.findIndex<'T> Function (F#)

Returns the index of the first element in the list that satisfies the given predicate. Raises **T:System.Collections.Generic.KeyNotFoundException** if no such element exists.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.findIndex : ('T -> bool) -> 'T list -> int

// Usage:
List.findIndex predicate list

```



#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The index of the first element that satisfies the predicate.**
## Remarks
This function is named **FindIndex** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use List.findIndex and compares its behavior to that of [List.find](http://msdn.microsoft.com/en-us/library/0594593e-9c75-44c1-8f5a-a37b2e561c06).**
[!code-fsharp[Main](snippets/fslists/snippet45.fs)]
**Output**
**The first element that is both a square and a cube is 64 and its index is 62.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

