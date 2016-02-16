# Control.Event<'Delegate,'Args> Class (F#)

Event implementations for a delegate types following the standard .NET Framework convention of a first *sender* argument.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


type Event<'Delegate,'Args (requires delegate)> =
class
new Event : unit -> Event<'Delegate,'Args>
member this.Trigger : obj * 'Args -> unit
member this.Publish :  IEvent<'Delegate,'Args>
end

```



## Remarks
This type is named **FSharpEvent** in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/2f112efb-a288-4640-87ec-414d6c607d31)|Creates an event object suitable for delegate types following the standard .NET Framework convention of a first 'sender' argument.|

## Instance Members


|Member|Description|
|------|-----------|
|[Publish](http://msdn.microsoft.com/en-us/library/99fb267f-7751-40b4-a137-1279edf5b303)|Publishes the event as a first class event value.|
|[Trigger](http://msdn.microsoft.com/en-us/library/e73a5a2b-7d5f-425b-8ff6-f35780c84968)|Triggers the event using the given sender object and parameters. The sender object may be **null**.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

