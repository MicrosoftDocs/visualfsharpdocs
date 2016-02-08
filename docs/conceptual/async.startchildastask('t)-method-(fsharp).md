# Async.StartChildAsTask<'T> Method (F#)

Creates an asynchronous computation which starts the given computation as a **T:System.Threading.Tasks.Task**.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member StartChildAsTask : Async<'T> * ?TaskCreationOptions -> Async<Task<'T>>

// Usage:
Async.StartChildAsTask (computation)
Async.StartChildAsTask (computation, taskCreationOptions = taskCreationOptions)

```



#### Parameters
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The computation to execute.


*taskCreationOptions*
Type: **T:System.Threading.Tasks.TaskCreationOptions**


Optional task creation options.



**The task wrapped as an asynchronous computation.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%28FSharp%29.md)

