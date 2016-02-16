# IObservable.Subscribe<'T> Extension Method (F#)

Connects a listener function to the observable. The listener will be invoked for each observation. The listener can be removed by calling Dispose on the returned IDisposable object.

**Namespace/Module Path**: Microsoft.FSharp.Control.CommonExtensions

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
type System.IObservable with
member Subscribe : ('T -> unit) -> IDisposable

// Usage:
iObservable.Subscribe (callback)

```



#### Parameters
*callback*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to be called for each observation.




## Remarks
This member is named **SubscribeToObservable** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.CommonExtensions Module &#40;F&#35;&#41;](Control.CommonExtensions-Module-%5BFSharp%5D.md)

