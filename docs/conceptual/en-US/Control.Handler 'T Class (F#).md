# Control.Handler<'T> Class (F#)

A delegate type associated with the F# event type [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432).

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
type Handler<'T> =
class
abstract this.Invoke : obj * 'T -> unit
end
```

## CAPS_REMARKS_MD
This type is named **FSharpHandler** in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.


## Instance Members


|Member|Description|
|------|-----------|
|[Invoke](http://msdn.microsoft.com/en-us/library/0f42e201-6463-4d42-a659-44f29138b4cd)|Calls the function or functions associated with the event handler.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

