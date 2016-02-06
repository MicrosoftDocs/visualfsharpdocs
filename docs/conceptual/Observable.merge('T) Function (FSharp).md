# Observable.merge<'T> Function (F#)

Returns an observable for the merged observations from the sources. The returned object propagates success and error values arising from either source and completes when both the sources have completed.

**Namespace/Module Path:** Microsoft.FSharp.Control.Observable

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Observable.merge : IObservable<'T> -> IObservable<'T> -> IObservable<'T>

// Usage:
Observable.merge source1 source2
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*source1*
Type: [IObservable](http://msdn.microsoft.com/en-us/library/04855e2b-42e4-4342-860a-b86566c4f2d9)**&lt;'T&gt;**


The first Observable.


*source2*
Type: [IObservable](http://msdn.microsoft.com/en-us/library/04855e2b-42e4-4342-860a-b86566c4f2d9)**&lt;'T&gt;**


The second Observable.



**An Observable that propagates information from both sources.**
## Remarks
For each observer, the registered intermediate observing object is not thread safe. That is, observations arising from the sources must not be triggered concurrently on different threads.

This function is named **Merge** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Observable Module &#40;F&#35;&#41;](Control.Observable+Module+%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

