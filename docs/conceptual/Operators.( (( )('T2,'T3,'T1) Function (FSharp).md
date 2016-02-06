# Operators.( << )<'T2,'T3,'T1> Function (F#)

Composes two functions, the function on the right being applied first.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
( << ) : ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3

// Usage:
func2 << func1
```

#### Parameters
*func2*
Type: **'T2 -&gt; 'T3**


The second function to apply.


*func1*
Type: **'T1 -&gt; 'T2**


The first function to apply.



**The composition of the input functions.**
## Remarks
This operator is referred to as the *backward* or *reverse composition operator*.

**The following example demonstrates the use of the reverse composition operator (&lt;&lt;).**
[!code-fsharp[Main](snippets/fsoperators/snippet8.fs)]
**abc.append2.append1**
**abc.append3.append2.append1**
**myfile.txt**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

