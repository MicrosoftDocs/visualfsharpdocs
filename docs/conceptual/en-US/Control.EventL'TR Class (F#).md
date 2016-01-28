# Control.Event<'T> Class (F#)

Event implementations for the [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432) type.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
type Event<'T> =
class
new Event : unit -> Event<'T>
member this.Trigger : 'T -> unit
member this.Publish :  IEvent<'T>
end
```

## CAPS_REMARKS_MD
Functions that work with events are defined in the [Event module](http://msdn.microsoft.com/en-us/library/8b883baa-a460-4840-9baa-de8260351bc7).

This type is named **FSharpEvent** in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/4f9c6229-7502-4f4f-97ef-413a6c8501d1)|Creates an observable object.|

## Instance Members


|Member|Description|
|------|-----------|
|[Publish](http://msdn.microsoft.com/en-us/library/b0fdaad5-25e5-43d0-9c0c-ce37c4aeb68e)|Publishes an observation as a first class value.|
|[Trigger](http://msdn.microsoft.com/en-us/library/f8a418ad-72b4-4574-bdf8-b1e7e1f21459)|Triggers an observation using the given parameters.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

[Control.IEvent&#60;'T&#62; Type Abbreviation &#40;F&#35;&#41;](Control.IEventL%27TR+Type+Abbreviation+%28F%23%29.md)

[Control.IEvent&#60;'Delegate,'Args&#62; Interface &#40;F&#35;&#41;](Control.IEventL%27Delegate%2C%27ArgsR+Interface+%28F%23%29.md)

