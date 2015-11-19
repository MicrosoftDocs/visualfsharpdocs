# IObservable.Add<'T> Extension Method (F#)

Permanently connects a listener function to the observable. The listener will be invoked for each observation.

**Namespace/Module Path:** Microsoft.FSharp.Control.CommonExtensions

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
type System.IObservable with
member Add : ('T -> unit) -> unit

// Usage:
iObservable.Add (callback)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*callback*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to be called for each observation.




## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This member is named **AddToObservable** in compiled assemblies. If you are accessing the method from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.CommonExtensions Module &#40;F&#35;&#41;](Control.CommonExtensions+Module+28%F%2329%.md)

[IObservable.Subscribe&lt;'T&gt; Extension Method (F#)](http://msdn.microsoft.com/en-us/library/8c8702c2-caa8-4a72-94bb-025f0922e04a)

[System.IObservable&lt;'T&gt; Interface](http://msdn.microsoft.com/en-us/library/04855e2b-42e4-4342-860a-b86566c4f2d9)

