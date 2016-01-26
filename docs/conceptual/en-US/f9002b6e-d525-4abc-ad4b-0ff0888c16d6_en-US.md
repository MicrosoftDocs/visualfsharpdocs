# IEventLoop.Invoke<'T> Method (F#)

Request that the given operation be run synchronously on the event loop.

**Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive

**Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)


## CAPS_SYNTAX_MD

```
// Signature:
abstract this.Invoke : (unit -> 'T) -> 'T

// Usage:
iEventLoop.Invoke (func)
```

#### CAPS_PARAMETERS_MD
*func*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt; 'T**


A function to run on the event loop.




## CAPS_REMARKS_MD

## Platforms
Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2


## Version Information
**F# Runtime**

Supported in: 2.0, 4

**Silverlight**

Supported in: 3


## See Also
[Interactive.IEventLoop Interface &#40;F&#35;&#41;](Interactive.IEventLoop+Interface+%28F%23%29.md)

[Microsoft.FSharp.Compiler.Interactive Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Compiler.Interactive+Namespace+%28F%23%29.md)

