# String.collect Function (F#)

Builds a new string whose characters are the results of applying a specified function to each of the characters of the input string and concatenating the resulting strings.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
String.collect : (char -> string) -> string -> string

// Usage:
String.collect mapping str
```

#### CAPS_PARAMETERS_MD
*mapping*
Type: [char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)**-&gt;**[string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The function to produce a string from each character of the input string.


*str*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The input string.



**exceptions tag is not supported!!!!**
**The concatenated string.**
## CAPS_REMARKS_MD
This function is named **Collect** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use String.collect.**
```

    let spaceOut inputString =
         String.collect (fun c -> sprintf "%c " c) inputString
    printfn "%s" (spaceOut "Hello World!")
```

**Output**
**H e l l o   W o r l d !**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

