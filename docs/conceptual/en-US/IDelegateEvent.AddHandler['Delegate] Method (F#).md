# IDelegateEvent.AddHandler<'Delegate> Method (F#)

Connect a handler delegate object to the event. A handler can be later removed using [RemoveHandler](http://msdn.microsoft.com/en-us/library/a5fd2289-29ef-4c8e-bf67-14d6fbed38b2). The listener will be invoked when the event is fired.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
abstract this.AddHandler : 'Delegate -> unit

// Usage:
iDelegateEvent.AddHandler (handler)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*handler*
Type: **'Delegate**


A delegate to be invoked when the event is fired.




## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.IDelegateEvent&#60;'Delegate&#62; Interface &#40;F&#35;&#41;](Control.IDelegateEvent%3C%27Delegate%3E+Interface+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

