# Async.RunSynchronously<'T> Method (F#)

Runs the provided asynchronous computation and awaits its result.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member RunSynchronously : Async<'T> * ?int * ?CancellationToken -> 'T

// Usage:
Async.RunSynchronously (computation)
Async.RunSynchronously (computation, timeout = timeout, cancellationToken = cancellationToken)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The computation to run.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The amount of time in milliseconds to wait for the result of the computation before raising a **T:System.TimeoutException**. If no value is provided for timeout then a default of -1 is used to correspond to **F:System.Threading.Timeout.Infinite**.


*cancellationToken*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The cancellation token to be associated with the computation. If one is not supplied, the default cancellation token is used.



**The result of the computation.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
If an exception occurs in the asynchronous computation then an exception is re-raised by this function. If no cancellation token is provided then the default cancellation token is used. The timeout parameter is given in milliseconds. A value of -1 is equivalent to **F:System.Threading.Timeout.Infinite**.

If you provide a cancelable cancellation token, the timeout is ignored. Instead, you can implement your own timeout by canceling the operation. A cancellation token is cancelable if its **P:System.Threading.CancellationToken.CanBeCanceled** property is set to **true**.

**Async.RunSynchronously** should not be used on the main thread in asynchronous programming environments, such as in Silverlight-based applications.

**The following example shows how to use Async.RunSynchronously to run an asynchronous computation created by using [Async.Parallel](http://msdn.microsoft.com/en-us/library/aa9b0355-2d55-4858-b943-cbe428de9dc4), with no timeout.**
**[!CODE [FsAsyncAPIs#1](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#1)]****The following example shows how to use Async.RunSynchronously with a timeout.**
**[!CODE [FsAsyncAPIs#2](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#2)]**
**Sample Output**
**The operation has timed out.420 write operations completed successfully.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

