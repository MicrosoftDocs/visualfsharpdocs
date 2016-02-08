# AsyncBuilder.Return<'T> Method (F#)

Implements the **return** expression in asynchronous computations. Creates an asynchronous computation that returns a result.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
member this.Return : 'T -> Async<'T>

// Usage:
asyncBuilder.Return (value)

```



#### Parameters
*value*
Type: **'T**


The value to return from the computation.



**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that returns value when executed.**
## Remarks
A cancellation check is performed when the computation is executed. The existence of this method permits the use of **return** in the **async { ... }** computation expression syntax.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.AsyncBuilder Class &#40;F&#35;&#41;](Control.AsyncBuilder-Class-%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%28FSharp%29.md)

