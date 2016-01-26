# Array.sum<^T> Function (F#)

Returns the sum of the elements in the array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.sum : ^T [] -> ^T (requires ^T with static member (+) and ^T with static member Zero)

// Usage:
Array.sum array
```

#### CAPS_PARAMETERS_MD
*array*
Type: **^T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The resulting sum.**
## CAPS_REMARKS_MD
This function is named **Sum** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Array.sum.**
**[!CODE [FsArrays#66](../CodeSnippet/VS_Snippets_Fsharp/fsarrays/FSharp/fs/program.fs#66)]**
**Output**
**55**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

