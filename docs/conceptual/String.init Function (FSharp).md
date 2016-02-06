# String.init Function (F#)

Creates a new string whose characters are the results of applying a specified function to each index and concatenating the resulting strings.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
String.init : int -> (int -> string) -> string

// Usage:
String.init count initializer
```

#### Parameters
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of strings to initialize.


*initializer*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The function to take an index and produce a string to be concatenated with the others.



**exceptions tag is not supported!!!!**
**The constructed string.**
## Remarks
This function is named **Initialize** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use String.init.**
[!code-fsharp[Main](snippets/fsstrings/snippet5.fs)]
**Output**
**0123456789**
**ABCDEFGHIJKLMNOPQRSTUVWXYZ**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

