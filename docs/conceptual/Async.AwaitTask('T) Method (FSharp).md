# Async.AwaitTask<'T> Method (F#)

Returns an asynchronous computation that waits for the given task to complete and returns its result.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member AwaitTask : Task<'T> -> Async<'T>

// Usage:
Async.AwaitTask (task)

```



#### Parameters
*task*
Type: **T:System.Threading.Tasks.Task&#96;1**


The task to wait for.



**An asynchronous computation object.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

