# Lazy.Create<'T> Extension Method (F#)

Creates a lazy computation that evaluates to the result of the given function when forced.

**Namespace/Module Path:** Microsoft.FSharp.Control.LazyExtensions

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
type System.Lazy with
member static Create : Lazy<'T>

// Usage:
lazy.Create (creator)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*creator*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt; 'T**


The function to provide the value when needed.



**The created [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489) object.**
## Remarks
**The following code illustrates the use of Create.**
[!code-fsharp[Main](snippets/fscorelib2/snippet11.fs)]
**The output is the factorial of 10.**
**3628800**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.LazyExtensions Module &#40;F&#35;&#41;](Control.LazyExtensions+Module+%28FSharp%29.md)

[Lazy Computations &#40;F&#35;&#41;](Lazy+Computations+%28FSharp%29.md)

