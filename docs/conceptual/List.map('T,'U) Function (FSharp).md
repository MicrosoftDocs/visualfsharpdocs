# List.map<'T,'U> Function (F#)

Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
List.map : ('T -> 'U) -> 'T list -> 'U list

// Usage:
List.map mapping list
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*mapping*
Type: **'T -&gt; 'U**


The function to transform elements from the input list.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The list of transformed elements.**
## Remarks
This function is named **Map** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of List.map.**
[!code-fsharp[Main](snippets/fssamples101/snippet3002.fs)]
**Adding '1' using map = [2; 3; 4; 5]**
**Converting to strings using map = ["1"; "2"; "3"; "4"]**
**Tupling up using map = [(1, 1); (2, 2); (3, 3); (4, 4)]****The next example demonstrates the use of List.map to transform data into a different format.**
[!code-fsharp[Main](snippets/fssamples101/snippet1004.fs)]
**"Monday, January 01, 2001 12:00:00 AM"**
**"Monday, February 02, 2004 12:00:00 AM"**
**"Wednesday, June 17, 2009 12:00:00 AM"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

