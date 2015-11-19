# Operators.( <| )<'T,'U> Function (F#)

Applies a function to a value, the value being on the right, the function on the left.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
( <| ) : ('T -> 'U) -> 'T -> 'U

// Usage:
func <| arg1
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*func*
Type: **'T -&gt; 'U**


The function.


*arg1*
Type: **'T**


The argument.



**The function result.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The function is referred to as the *backward* or *reverse pipe operator*.

**The following example demonstrates the use of the &lt;| operator.**
**[!CODE [FsOperators#4](../CodeSnippet/VS_Snippets_Fsharp/fsoperators/FSharp/fs/program.fs#4)]**
**append1 &lt;| "abc" gives "abc.append1"**
**result2: "abc.append1.append2"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

