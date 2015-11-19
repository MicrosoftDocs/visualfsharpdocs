# Array.map<'T,'U> Function (F#)

Builds a new array whose elements are the results of applying the given function to each of the elements of the array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Array.map : ('T -> 'U) -> 'T [] -> 'U []

// Usage:
Array.map mapping array
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*mapping*
Type: **'T -&gt; 'U**


The function to transform elements of the array.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The array of transformed elements.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Map** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use Array.map.**
**[!CODE [FsArrays#510](../CodeSnippet/VS_Snippets_Fsharp/fsarrays/FSharp/fs/program.fs#510)]**
**Output**
**Adding '1' using map = [|2; 3; 4; 5|]**
**Converting to strings by using map = [|"1"; "2"; "3"; "4"|]**
**Converting to tuples by using map = [|(1, 1); (2, 2); (3, 3); (4, 4)|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

