# Control.CommonExtensions Module (F#)

A module of extension members providing asynchronous operations for some basic CLI types related to concurrency and I/O.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
[<AutoOpen>]
module CommonExtensions
```

## Remarks

## Extension Members


|Extension Member|Description|
|----------------|-----------|
|[Add](http://msdn.microsoft.com/en-us/library/cf21f284-ab78-4628-9585-090df11336c5)<br />**: ('T -&gt; unit) -&gt; unit**|Permanently connects a listener function to the observable. The listener will be invoked for each observation.|
|[Subscribe](http://msdn.microsoft.com/en-us/library/cf21f284-ab78-4628-9585-090df11336c5)<br />**: ('T -&gt; unit) -&gt; IDisposable**|Connects a listener function to the observable. The listener will be invoked for each observation. You can remove the listener by calling **M:System.IDisposable.Dispose** on the returned **T:System.IDisposable** object.|
|[AsyncRead](http://msdn.microsoft.com/en-us/library/85698aaa-bdda-47e6-abed-3730f59fda5e)<br />**: byte [] &#42; ?int &#42; ?int -&gt; Async&lt;int&gt;**|Returns an asynchronous computation that will read from the stream into the given buffer.|
|[AsyncWrite](http://msdn.microsoft.com/en-us/library/1b0a2751-e42a-47e1-bd27-020224adc618)<br />**: byte[] &#42; ?int &#42; ?int -&gt; Async&lt;unit&gt;**|Returns an asynchronous computation that will write the given bytes to the stream.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

