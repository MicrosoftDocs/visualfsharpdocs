# Option.bind<'T,'U> Function (F#)

Invokes a function on an optional value that itself yields an option.

**Namespace/Module Path**: Microsoft.FSharp.Core.Option

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
bind : ('T -> 'U option) -> 'T option -> 'U option

// Usage:
bind binder option
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*binder*
Type: **'T -&gt; 'U**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


A function that takes the value of type T from an option and transforms it into an option containing a value of type U.


*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**An option of the output type of the binder.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The expression **Option.bind f inp** evaluates to **match inp with None -&gt; None | Some x -&gt; f x.**

This function is named **Bind** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.bind.**
**[!CODE [FsOptions#1](../CodeSnippet/VS_Snippets_Fsharp/fsoptions/FSharp/fs/program.fs#1)]**
**Output**
**Some "egamI rorriM"&lt;null&gt;**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

