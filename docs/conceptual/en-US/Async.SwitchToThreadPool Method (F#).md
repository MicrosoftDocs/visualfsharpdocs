# Async.SwitchToThreadPool Method (F#)

Creates an asynchronous computation that queues a work item that runs its continuation.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member SwitchToThreadPool : unit -> Async<unit>

// Usage:
Async.SwitchToThreadPool ()
```
**A computation that generates a new work item in the thread pool.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
For examples of the use of this method, see [Async.SwitchToContext Method &#40;F&#35;&#41;](Async.SwitchToContext+Method+28%F%2329%.md) and [Async.SwitchToNewThread Method &#40;F&#35;&#41;](Async.SwitchToNewThread+Method+28%F%2329%.md).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

