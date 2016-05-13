# Async.StartAsTask<'T> Method (F#)

Executes a computation in the thread pool. Returns a **T:System.Threading.Tasks.Task** that will be completed in the corresponding state once the computation terminates (produces the result, throws exception or gets canceled) If no cancellation token is provided then the default cancellation token is used.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
static member StartAsTask : Async<'T> * ?TaskCreationOptions * ?CancellationToken -> Task<'T>

// Usage:
Async.StartAsTask (computation)
Async.StartAsTask (computation, taskCreationOptions = taskCreationOptions, cancellationToken = cancellationToken)


```





#### Parameters
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The computation to execute.


*taskCreationOptions*
Type: **T:System.Threading.Tasks.TaskCreationOptions**


Optional task creation options.


*cancellationToken*
Type: **T:System.Threading.CancellationToken**


Optional cancellation token.



**A T:System.Threading.Tasks.Task&#96;1 object that represents the given computation.**
## Remarks
**The following code example demonstrates the use of Async.StartAsTask.**
[!code-fsharp[Main](snippets/fsasyncapis/snippet330.fs)]
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

