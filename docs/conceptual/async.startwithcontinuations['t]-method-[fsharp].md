# Async.StartWithContinuations<'T> Method (F#)

Runs an asynchronous computation, starting immediately on the current operating system thread. Call one of the three continuations when the operation completes.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member StartWithContinuations : Async<'T> * ('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) * ?CancellationToken -> unit

// Usage:
Async.StartWithContinuations (computation, continuation, exceptionContinuation, cancellationContinuation)
Async.StartWithContinuations (computation, continuation, exceptionContinuation, cancellationContinuation, cancellationToken = cancellationToken)

```



#### Parameters
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The asynchronous computation to execute.


*continuation*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function called on success.


*exceptionContinuation*
Type: [exn](http://msdn.microsoft.com/en-us/library/e1569b69-3b30-440b-8c6f-966d1c6a06ab)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function called on exception.


*cancellationContinuation*
Type: **T:System.OperationCanceledException****-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function called on cancellation.


*cancellationToken*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The optional cancellation token to associate with the computation. The default is used if this parameter is not provided.




## Remarks
If no cancellation token is provided, the default cancellation token is used.

**The following code example illustrates the use of Async.StartWithContinuations.**
[!code-fsharp[Main](snippets/fsasyncapis/snippet5.fs)]
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

