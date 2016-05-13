# Async.CancellationToken Property (F#)

Creates an asynchronous computation that returns the cancellation token governing the execution of the computation.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
static member CancellationToken :  Async<CancellationToken>

// Usage:
Async.CancellationToken


```




**An asynchronous computation capable of retrieving the T:System.Threading.CancellationToken from a computation expression.**
## Remarks
In an asynchronous computation such as the following, a cancellation token can be used to initiate other asynchronous operations that will cancel cooperatively with this workflow.




```



f#
async { let! token = Async.CancellationToken ...}


```





## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

