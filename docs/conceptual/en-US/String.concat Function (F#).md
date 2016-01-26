# String.concat Function (F#)

Returns a new string made by concatenating the given strings with a separator.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
String.concat : string -> seq<string> -> string

// Usage:
String.concat sep strings
```

#### CAPS_PARAMETERS_MD
*sep*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The separator string to be inserted between the strings of the input sequence.


*strings*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;**[string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)**&gt;**


The sequence of strings to be concatenated.



**exceptions tag is not supported!!!!**
**A new string consisting of the concatenated strings separated by the separation string.**
## CAPS_REMARKS_MD
This function is named **Concat** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use String.concat.**
**[!CODE [FsStrings#2](../CodeSnippet/VS_Snippets_Fsharp/fsstrings/FSharp/fs/program.fs#2)]**
**Output**
**tomatoes, bananas, apples**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

