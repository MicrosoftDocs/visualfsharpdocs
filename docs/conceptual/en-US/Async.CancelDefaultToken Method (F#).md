# Async.CancelDefaultToken Method (F#)

Raises the cancellation condition for the most recent set of asynchronous computations started without any specific cancellation token. Replaces the global **T:System.Threading.CancellationTokenSource** object with a new global token source for any asynchronous computations created after this point without any specific cancellation token.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member CancelDefaultToken : unit -> unit

// Usage:
Async.CancelDefaultToken ()
```

## CAPS_REMARKS_MD
**The following example shows how to create a cancellable asynchronous operation in a Windows Forms application. It also shows how to use Async.CancelDefaultToken to cancel the operation.**
**[!CODE [FsAsyncAPIs#5](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#5)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

