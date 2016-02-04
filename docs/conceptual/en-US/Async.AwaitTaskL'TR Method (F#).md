# Async.AwaitTask<'T> Method (F#)

Returns an asynchronous computation that waits for the given task to complete and returns its result.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
static member AwaitTask : Task<'T> -> Async<'T>

// Usage:
Async.AwaitTask (task)


```



#### CAPS_PARAMETERS_MD
*task*
Type: **T:System.Threading.Tasks.Task&#96;1**


The task to wait for.



**An asynchronous computation object.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

