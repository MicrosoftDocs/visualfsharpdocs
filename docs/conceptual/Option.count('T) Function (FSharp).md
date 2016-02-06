# Option.count<'T> Function (F#)

Evaluates the equivalent of [Set.count](http://msdn.microsoft.com/en-us/library/54acc46d-af76-474e-9ff7-bd4bd6b7b4c4) for an option.

**Namespace/Module Path:** Microsoft.FSharp.Core.Option

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
count : 'T option -> int

// Usage:
count option
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*option*
Type: **'T**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.



**A zero if the option is None, a one otherwise.**
## Remarks
The expression **count inp** evaluates to **match inp with None -&gt; 0 | Some _ -&gt; 1**.

This function is named **Count** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Option.count.**
[!code-fsharp[Main](snippets/fsoptions/snippet2.fs)]
**Output**
**1 035**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Option Module &#40;F&#35;&#41;](Core.Option+Module+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

