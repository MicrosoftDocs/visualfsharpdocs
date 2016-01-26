# Async.StartImmediate Method (F#)

Runs an asynchronous computation, starting immediately on the current operating system thread.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member StartImmediate : Async<unit> * CancellationToken option -> unit

// Usage:
Async.StartImmediate (computation)
Async.StartImmediate (computation, cancellationToken = cancellationToken)
```

#### CAPS_PARAMETERS_MD
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**&gt;**


The asynchronous computation to execute.


*cancellationToken*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The optional cancellation token to associate with the computation. The default is used if this parameter is not provided.




## CAPS_REMARKS_MD
If no cancellation token is provided then the default cancellation token is used.

**The following code example shows how to use Async.StartImmediate to start an asynchronous computation on the current thread. Often, an asynchronous operation needs to update UI, which should always be done on the UI thread. When your asynchronous operation needs to begin by updating UI, Async.StartImmediate is a better choice than [Async.Start](http://msdn.microsoft.com/en-us/library/338aa756-beac-4dc1-95ca-613822679347), which starts the asynchronous operation on a thread pool thread.**
**[!CODE [FsAsyncAPIs#320](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#320)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

