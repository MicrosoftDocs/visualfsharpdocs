# Operators.( |> )<'T1,'U> Function (F#)

Apply a function to a value, the value being on the left, the function on the right.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
( |> ) : 'T1 -> ('T1 -> 'U) -> 'U

// Usage:
arg |> func
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*arg*
Type: **'T1**


The argument.


*func*
Type: **'T1 -&gt; 'U**


The function.



**The function result.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
**The following example demonstrates the use of the forward pipe operator.**
**[!CODE [FsOperators#1](../CodeSnippet/VS_Snippets_Fsharp/fsoperators/FSharp/fs/program.fs#1)]**
**"abc" |&gt; append1 gives "abc.append1"**
**result2: "abc.append1.append2"**
**300 200 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

