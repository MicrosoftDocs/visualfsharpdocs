# String.mapi Function (F#)

Creates a new string whose characters are the results of applying a specified function to each character and index of the input string.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
String.mapi : (int -> char -> char) -> string -> string

// Usage:
String.mapi mapping str

```



#### Parameters
*mapping*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)**-&gt;**[char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)


The function to apply to each character and index of the string.


*str*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The input string.



**exceptions tag is not supported!!!!**
**The resulting string.**
## Remarks
This function is named **MapIndexed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use String.mapi.**
<b>codeReference tag is not supported!!!!</b>
**Output**
**MASK**
**BASK**
**BASH**
**BATH**
**BOTH**
**MOTH**
**MATH**
**MASH**
**MASK**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library VersionsF# Core Library Versions**

Supported in: 2.0, 4.0, Portable2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

