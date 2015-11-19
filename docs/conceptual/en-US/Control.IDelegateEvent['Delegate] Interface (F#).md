# Control.IDelegateEvent<'Delegate> Interface (F#)

First class event values for arbitrary delegate types.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
type IDelegateEvent<'Delegate> =
interface
abstract this.AddHandler : 'Delegate -> unit
abstract this.RemoveHandler : 'Delegate -> unit
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
F# gives special status to member properties compatible with type **IDelegateEvent** and tagged with the [CLIEventAttribute](http://msdn.microsoft.com/en-us/library/d359f1dd-ffa5-42fb-8808-b4c8131a0333). In this case the F# compiler generates approriate CLI metadata to make the member appear to other CLI languages as a CLI event.


## Instance Members


|Member|Description|
|------|-----------|
|[AddHandler](http://msdn.microsoft.com/en-us/library/15ff9fc8-43e6-456f-b0f7-5cd104bb6d9a)|Connect a handler delegate object to the event. A handler can be later removed using [RemoveHandler](http://msdn.microsoft.com/en-us/library/a5fd2289-29ef-4c8e-bf67-14d6fbed38b2). The listener will be invoked when the event is fired.|
|[RemoveHandler](http://msdn.microsoft.com/en-us/library/a5fd2289-29ef-4c8e-bf67-14d6fbed38b2)|Remove a listener delegate from an event listener store.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

[DelegateEvent](http://msdn.microsoft.com/en-us/library/d5c57485-4db6-4fd0-b93e-d96a99dc1051)

