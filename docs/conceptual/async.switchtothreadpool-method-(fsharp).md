# Async.SwitchToThreadPool Method (F#)

Creates an asynchronous computation that queues a work item that runs its continuation.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member SwitchToThreadPool : unit -> Async<unit>

// Usage:
Async.SwitchToThreadPool ()

```


**A computation that generates a new work item in the thread pool.**
## Remarks
For examples of the use of this method, see [Async.SwitchToContext Method &#40;F&#35;&#41;](Async.SwitchToContext-Method-%28FSharp%29.md) and [Async.SwitchToNewThread Method &#40;F&#35;&#41;](Async.SwitchToNewThread-Method-%28FSharp%29.md).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%28FSharp%29.md)

