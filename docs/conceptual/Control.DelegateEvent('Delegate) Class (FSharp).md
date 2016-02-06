# Control.DelegateEvent<'Delegate> Class (F#)

Event implementations for an arbitrary type of delegate.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
type DelegateEvent<'Delegate> =
class
new DelegateEvent : unit -> DelegateEvent<'Delegate>
member this.Trigger : obj [] -> unit
member this.Publish :  IDelegateEvent<'Delegate>
end
```

## Remarks
This type is named **FSharpDelegateEvent** in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/dc240900-1e0a-440d-87a6-271a0fde2aa2)|Creates an event object suitable for implementing an arbitrary type of delegate.|

## Instance Members


|Member|Description|
|------|-----------|
|[Publish](http://msdn.microsoft.com/en-us/library/7773c3df-99de-43bd-9e11-1b5763651d27)|Publishes the event as a first class event value.|
|[Trigger](http://msdn.microsoft.com/en-us/library/81433778-b592-40d1-a5a6-c94e3ab3fd88)|Triggers the event using the given parameters.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

