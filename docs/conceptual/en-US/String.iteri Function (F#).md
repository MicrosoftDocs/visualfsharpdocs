# String.iteri Function (F#)

Applies a specified function to each character and corresponding index in the string.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
String.iteri : (int -> char -> unit) -> string -> unit

// Usage:
String.iteri action str
```

#### CAPS_PARAMETERS_MD
*action*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to apply to each character and index of the string.


*str*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The input string.



**exceptions tag is not supported!!!!**

## CAPS_REMARKS_MD
This function is named **IterateIndexed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use String.iteri.**
**[!CODE [FsStrings#9](../CodeSnippet/VS_Snippets_Fsharp/fsstrings/FSharp/fs/program.fs#9)]**
**Output**
**0 T**
**1 I**
**2 M**
**3 E**
**0 S**
**1 P**
**2 A**
**3 C**
**4 E**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

