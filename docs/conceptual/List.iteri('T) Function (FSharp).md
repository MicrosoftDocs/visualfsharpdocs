# List.iteri<'T> Function (F#)

Applies the given function to each element of the collection. The integer passed to the function indicates the index of element.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
List.iteri : (int -> 'T -> unit) -> 'T list -> unit

// Usage:
List.iteri action list
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*action*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to apply to the elements of the list along with their index.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.




## Remarks
This function is named **IterateIndexed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of List.iteri.**
[!code-fsharp[Main](snippets/fssamples101/snippet3005.fs)]
**item 0: Cats**
**item 1: Dogs**
**item 2: Mice**
**item 3: Elephants**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

