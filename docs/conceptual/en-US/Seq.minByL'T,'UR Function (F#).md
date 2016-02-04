# Seq.minBy<'T,'U> Function (F#)

Returns the lowest of all elements of the sequence, compared by using [Operators.min](http://msdn.microsoft.com/en-us/library/adea4fd7-bfad-4834-989c-7878aca81fed) on the function result.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Seq.minBy : ('T -> 'U) -> seq<'T> -> 'T (requires comparison)

// Usage:
Seq.minBy projection source


```



#### CAPS_PARAMETERS_MD
*projection*
Type: **'T -&gt; 'U**


A function to transform items from the input sequence into comparable keys.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This function is named **MinBy** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

