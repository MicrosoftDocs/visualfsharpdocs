# IObservable.Subscribe<'T> Method (F#)

Subscribe an observer to the source of results

**Namespace/Module Path**: System

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
abstract this.Subscribe : IObserver<'T> -> IDisposable

// Usage:
iObservable.Subscribe (observer)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*observer*
Type: [IObserver](http://msdn.microsoft.com/en-us/library/38436152-0d4c-4b0f-9916-440b34f377fb)**&lt;'T&gt;**


The observer to be added to those that are notified.



**An IDisposable to allow for unsubscription.**
## Remarks
This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, **M:System.IObservable&#96;1.Subscribe(System.IObserver{&#96;0})**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[System.IObservable&#60;'T&#62; Interface &#40;F&#35;&#41;](System.IObservable%3C%27T%3E+Interface+%28FSharp%29.md)

[System Namespace &#40;F&#35;&#41;](System+Namespace+%28FSharp%29.md)

