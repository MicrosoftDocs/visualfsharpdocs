# Async.AsBeginEnd<'Arg,'T> Method (F#)

Creates three functions that can be used to implement the .NET Framework Asynchronous Programming Model (APM) for the supplied asynchronous computation.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member AsBeginEnd : ('Arg -> Async<'T>) -> ('Arg * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * (IAsyncResult -> unit)

// Usage:
Async.AsBeginEnd (computation)

```



#### Parameters
*computation*
Type: **'Arg -&gt;**[Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


A function that generates the asynchronous computation to split into the traditional .NET Framework Asynchronous Programming Model.



**A tuple of the begin, end, and cancel members.**
## Remarks
For more information about the .NET Framework Asynchronous Programming Model, see [Asynchronous Programming Model &#40;APM&#41;](https://msdn.microsoft.com/en-us/library/ms228963.aspx).

The begin, end, and cancel functions should normally be published as members that are prefixed with **Begin**, **End**, and **Cancel**, and that can be used within a type definition as follows.



```

f#
let beginAction,endAction,cancelAction =
Async.AsBeginEnd (fun arg -> computation)
member x.BeginSomeOperation(arg, callback ,state:obj) =
beginAction(arg, callback, state)
member x.EndSomeOperation(iar) = endAction(iar)
member x.CancelSomeOperation(iar) = cancelAction(iar)

```


If the asynchronous computation takes no arguments, **AsBeginEnd** is used as follows.



```

f#
let beginAction,endAction,cancelAction =
Async.AsBeginEnd (fun () -> computation)
member x.BeginSomeOperation(callback, state:obj) =
beginAction((), callback, state)
member x.EndSomeOperation(iar) = endAction(iar)
member x.CancelSomeOperation(iar) = cancelAction(iar)

```


If the asynchronous computation takes two arguments, **AsBeginEnd** is used as follows.



```

f#
let beginAction,endAction,cancelAction =
Async.AsBeginEnd (fun arg1 arg2 -> computation)
member x.BeginSomeOperation(arg1, arg2, callback, state:obj) =
beginAction((), callback, state)
member x.EndSomeOperation(iar) = endAction(iar)
member x.CancelSomeOperation(iar) = cancelAction(iar)

```


In each case, the resulting API resembles that used in other .NET Framework languages and is a useful way to publish asynchronous computations in components that are intended to be used from other .NET Framework languages.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%28FSharp%29.md)

