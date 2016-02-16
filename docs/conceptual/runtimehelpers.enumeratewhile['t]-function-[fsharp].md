# RuntimeHelpers.EnumerateWhile<'T> Function (F#)

The F# compiler emits calls to this function to implement the **while** keyword for F# sequence expressions.

**Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
RuntimeHelpers.EnumerateWhile : (unit -> bool) -> seq<'T> -> seq<'T>

// Usage:
RuntimeHelpers.EnumerateWhile guard source

```



#### Parameters
*guard*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function that indicates whether iteration should continue.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**The result sequence.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[CompilerServices.RuntimeHelpers Module &#40;F&#35;&#41;](CompilerServices.RuntimeHelpers-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices-Namespace-%5BFSharp%5D.md)

