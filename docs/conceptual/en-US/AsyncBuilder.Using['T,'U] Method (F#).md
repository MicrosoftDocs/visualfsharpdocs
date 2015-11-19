# AsyncBuilder.Using<'T,'U> Method (F#)

Implements the **use** and **use!** keywords in asynchronous computation expressions.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
member this.Using : 'T * ('T -> Async<'U>) -> Async<'U> (requires 'T :> IDisposable)

// Usage:
asyncBuilder.Using (resource, binder)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*resource*
Type: **'T**


The resource to be used and disposed.


*binder*
Type: **'T -&gt;**[Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'U&gt;**


The function that takes the resource and returns an asynchronous computation.



**An asynchronous computation that binds and eventually disposes resource.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
Creates an asynchronous computation that runs **binder(resource)**. The action **resource.Dispose()** is executed as this computation yields its result or if the asynchronous computation exits by an exception or by cancellation.

A cancellation check is performed when the computation is executed. The existence of this method permits the use of **use** and **use!** in the **async { ... }** computation expression syntax.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.AsyncBuilder Class &#40;F&#35;&#41;](Control.AsyncBuilder+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

