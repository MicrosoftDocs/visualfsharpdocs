# Control.IEvent<'Delegate,'Args> Interface (F#)

First class event values for CLI events conforming to CLI Framework standards.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
type IEvent<'Delegate,'Args when 'Delegate : delegate<'Args,unit> and 'Delegate :> System.Delegate> =
interface
inherit IObservable<'Args>
inherit IDelegateEvent<'Delegate>
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

[Control.IDelegateEvent&#60;'Delegate&#62; Interface &#40;F&#35;&#41;](Control.IDelegateEvent%3C%27Delegate%3E+Interface+28%F%2329%.md)

[System.IObservable&#60;'T&#62; Interface &#40;F&#35;&#41;](System.IObservable%3C%27T%3E+Interface+28%F%2329%.md)

