# Array.pick<'T,'U> Function (F#)

Applies the given function to successive elements, returning the first result where function returns **Some**. If the function never returns **Some** then **T:System.Collections.Generic.KeyNotFoundException** is raised.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.pick : ('T -> 'U option) -> 'T [] -> 'U

// Usage:
Array.pick chooser array
```

#### Parameters
*chooser*
Type: **'T -&gt; 'U**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The function to generate options from the elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**exceptions tag is not supported!!!!**
**The first result.**
## Remarks
This function is named **Pick** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use Array.pick.**
[!code-fsharp[Main](snippets/fsarrays/snippet62.fs)]
**Output**
**"b"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

