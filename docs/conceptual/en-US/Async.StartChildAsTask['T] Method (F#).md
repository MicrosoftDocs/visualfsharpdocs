# Async.StartChildAsTask<'T> Method (F#)

Creates an asynchronous computation which starts the given computation as a **T:System.Threading.Tasks.Task**.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member StartChildAsTask : Async<'T> * ?TaskCreationOptions -> Async<Task<'T>>

// Usage:
Async.StartChildAsTask (computation)
Async.StartChildAsTask (computation, taskCreationOptions = taskCreationOptions)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The computation to execute.


*taskCreationOptions*
Type: **T:System.Threading.Tasks.TaskCreationOptions**


Optional task creation options.



**The task wrapped as an asynchronous computation.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

