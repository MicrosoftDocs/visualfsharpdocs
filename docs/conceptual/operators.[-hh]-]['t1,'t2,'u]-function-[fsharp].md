# Operators.( ||> )<'T1,'T2,'U> Function (F#)

Apply a function to two values, the values being a pair on the left, the function on the right.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
( ||> ) : 'T1 * 'T2 -> ('T1 -> 'T2 -> 'U) -> 'U

// Usage:
(arg1, arg2) ||> func


```





#### Parameters
*arg1*
Type: **'T1**


The first argument.


*arg2*
Type: **'T2**


The second argument.


*func*
Type: **'T1 -&gt; 'T2 -&gt; 'U**


The function.



**The function result.**
## Remarks
**The following example demonstrates the use of the ||&gt; operator.**
[!code-fsharp[Main](snippets/fsoperators/snippet2.fs)]
**("abc", "def") ||&gt; append gives "abc.def"**
**result2: "ABC.DEF"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

