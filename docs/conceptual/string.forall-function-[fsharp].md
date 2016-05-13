# String.forall Function (F#)

Tests if all characters in the string satisfy the given predicate.

**Namespace/Module Path:** Microsoft.FSharp.Core.String

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
String.forall : (char -> bool) -> string -> bool

// Usage:
String.forall predicate str


```





#### Parameters
*predicate*
Type: [char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)**-&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test each character of the string.


*str*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


The input string.



**exceptions tag is not supported!!!!**
**Returns true if all characters return true for the predicate and false otherwise.**
## Remarks
This function is named **ForAll** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use String.forall.**
[!code-fsharp[Main](snippets/fsstrings/snippet4.fs)]
**Output**
**The string "8005" is a whole number.**
**The string "512" is a whole number.**
**The string "0x20" is not a valid whole number.**
**The string "1.0E-5" is not a valid whole number.**
**The string "-20" is not a valid whole number.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.String Module &#40;F&#35;&#41;](Core.String-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

