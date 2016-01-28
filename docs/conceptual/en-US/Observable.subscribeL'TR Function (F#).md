# Observable.subscribe<'T> Function (F#)

Creates an observer which subscribes to the given observable and which calls the given function for each observation.

**Namespace/Module Path**: Microsoft.FSharp.Control.Observable

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Observable.subscribe : ('T -> unit) -> IObservable<'T> -> IDisposable

// Usage:
Observable.subscribe callback source
```

#### CAPS_PARAMETERS_MD
*callback*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to be called on each observation.


*source*
Type: [IObservable](http://msdn.microsoft.com/en-us/library/04855e2b-42e4-4342-860a-b86566c4f2d9)**&lt;'T&gt;**


The input Observable.



**An object that will remove the callback if disposed.**
## CAPS_REMARKS_MD
This function is named **Subscribe** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Observable Module &#40;F&#35;&#41;](Control.Observable+Module+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

