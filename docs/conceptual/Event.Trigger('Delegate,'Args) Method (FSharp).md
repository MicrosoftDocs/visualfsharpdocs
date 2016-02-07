# Event.Trigger<'Delegate,'Args> Method (F#)

Triggers the event using the given sender object and parameters. The sender object may be **null**.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
member this.Trigger : obj * 'Args -> unit (requires delegate)

// Usage:
event.Trigger (sender, args)

```



#### Parameters
*sender*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The object triggering the event.


*args*
Type: **'Args**


The parameters for the event.




## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event&#60;'Delegate,'Args&#62; Class &#40;F&#35;&#41;](Control.Event%28%27Delegate%2C%27Args%29+Class+%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

