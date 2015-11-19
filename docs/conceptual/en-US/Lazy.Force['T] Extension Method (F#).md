# Lazy.Force<'T> Extension Method (F#)

Forces the execution of this value and returns its result. Same as **P:System.Lazy&#96;1.Value**. Mutual exclusion is used to prevent other threads from also computing the value.

**Namespace/Module Path**: Microsoft.FSharp.Control.LazyExtensions

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
type System.Lazy with
member Force : unit -> 'T

// Usage:
lazy.Force ()
```
**The value of the [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489) object.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
**The following code illustrates the use of the Force extension method.**
**[!CODE [FsCoreLib2#13](../CodeSnippet/VS_Snippets_Fsharp/fscorelib2/FSharp/fs/program.fs#13)]**
**The output indicates that when Force is called to create the value for lazyVal1, the computed value is retrieved when printing the values.**
**Retrieving stored value: 479001600**
**Computing value: 3628800**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.LazyExtensions Module &#40;F&#35;&#41;](Control.LazyExtensions+Module+28%F%2329%.md)

[Lazy Computations &#40;F&#35;&#41;](Lazy+Computations+28%F%2329%.md)

