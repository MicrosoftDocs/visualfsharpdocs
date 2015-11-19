# Async.SwitchToNewThread Method (F#)

Creates an asynchronous computation that creates a new thread and runs its continuation in that thread.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member SwitchToNewThread : unit -> Async<unit>

// Usage:
Async.SwitchToNewThread ()
```
**A computation that will execute on a new thread.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
**The following code example shows how to use Async.SwitchToNewThread and [Async.SwitchToThreadPool](http://msdn.microsoft.com/en-us/library/c2708739-5389-487a-a3c9-490f417bcdc6) to wrap a synchronous method call as an asynchronous method.**
**[!CODE [FsAsyncAPIs#28](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#28)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

