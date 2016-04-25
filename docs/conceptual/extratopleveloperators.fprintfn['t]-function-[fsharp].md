# ExtraTopLevelOperators.fprintfn<'T> Function (F#)

The fprintfn prints to a file using the given format, and add a newline.

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
fprintfn : TextWriter -> TextWriterFormat<'T> -> 'T

// Usage:
fprintfn textWriter format


```





#### Parameters
*textWriter*
Type: **T:System.IO.TextWriter**


*format*
Type: [TextWriterFormat](http://msdn.microsoft.com/en-us/library/2080c4a5-7bdd-4a01-8e01-10b498af92de)**&lt;'T&gt;**




## Remarks
This function is named **PrintFormatLineToTextWriter** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of fprintfn to print a listing of the contents of a directory to a specified file, directorylisting.txt.**
[!code-fsharp[Main](snippets/fscorelib2/snippet5.fs)]
[!code-fsharp[Main](snippets/fscorelib2/snippet6.fs)]
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

