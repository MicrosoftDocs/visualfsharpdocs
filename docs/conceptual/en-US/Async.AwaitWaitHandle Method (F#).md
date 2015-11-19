# Async.AwaitWaitHandle Method (F#)

Creates an asynchronous computation that will wait for the supplied **T:System.Threading.WaitHandle**.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member AwaitWaitHandle : WaitHandle * ?int -> Async<bool>

// Usage:
Async.AwaitWaitHandle (waitHandle)
Async.AwaitWaitHandle (waitHandle, millisecondsTimeout = millisecondsTimeout)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*waitHandle*
Type: **T:System.Threading.WaitHandle**


The wait handle that can be signaled.


*millisecondsTimeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The timeout value in milliseconds. If no timeout value is provided, the default value is -1, which corresponds to ystem.Threading.Timeout.Infinite.



**An asynchronous computation that waits on the given T:System.Threading.WaitHandle object.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The computation returns true if the handle indicated a result within the given timeout.

**The following code example illustrates how to use Async.AwaitWaitHandle to set up a computation to run when another asynchronous operation is completed, as indicated by a wait handle.**
<b>codeReference tag is not supported!!!!</b>
**Output**
**Writing to file BigFile.dat.**
**Reading from file BigFile.dat.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

