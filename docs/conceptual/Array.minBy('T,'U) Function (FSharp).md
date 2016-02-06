# Array.minBy<'T,'U> Function (F#)

Returns the lowest of all elements of the array, compared by using [Operators.min](http://msdn.microsoft.com/en-us/library/adea4fd7-bfad-4834-989c-7878aca81fed) on the function result.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.minBy : ('T -> 'U) -> 'T [] -> 'T (requires comparison)

// Usage:
Array.minBy projection array
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*projection*
Type: **'T -&gt; 'U**


The function to transform the elements into a type supporting comparison.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**exceptions tag is not supported!!!!**
**The minimum element.**
## Remarks
This function is named **MinBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example demonstrates the use of Array.minBy.**
[!code-fsharp[Main](snippets/fsarrays/snippet58.fs)]
**Output**
**0.0**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

