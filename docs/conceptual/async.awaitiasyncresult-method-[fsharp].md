# Async.AwaitIAsyncResult Method (F#)

Creates an asynchronous computation that will wait on the **T:System.IAsyncResult**.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member AwaitIAsyncResult : IAsyncResult * ?int -> Async<bool>

// Usage:
Async.AwaitIAsyncResult (iar)
Async.AwaitIAsyncResult (iar, millisecondsTimeout = millisecondsTimeout)

```



#### Parameters
*iar*
Type: **T:System.IAsyncResult**


The IAsyncResult to wait on.


*millisecondsTimeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The timeout value in milliseconds. If one is not provided then the default value of -1 corresponding to **F:System.Threading.Timeout.Infinite**.



**An asynchronous computation that waits on the given T:System.IAsyncResult.**
## Remarks
The computation returns **true** if the handle indicated a result within the given timeout.

**The following code example illustrates how to use Async.AwaitIAsyncResult to set up and execute a computation that is triggered when a previous .NET Framework asynchronous operation that produces an T:System.IAsyncResult finishes. In this case, the call to AwaitIAsyncResult causes the operation to wait for a file write operation to be completed before opening the file for reading.**
<b>codeReference tag is not supported!!!!</b>
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

