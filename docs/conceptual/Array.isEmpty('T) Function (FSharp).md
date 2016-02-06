# Array.isEmpty<'T> Function (F#)

Tests whether an array is empty.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.isEmpty : 'T [] -> bool

// Usage:
Array.isEmpty array
```

#### Parameters
*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**true if the array is empty. Otherwise, returns false.**
## Remarks
This function is named **IsEmpty** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Array.isEmpty.**
[!code-fsharp[Main](snippets/fsarrays/snippet48.fs)]
**Output**
**This array contains the following elements:**
**"test1" "test2"**
**There are no elements in this array.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

