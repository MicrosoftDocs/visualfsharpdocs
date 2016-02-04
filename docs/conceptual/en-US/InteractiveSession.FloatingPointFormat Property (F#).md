# InteractiveSession.FloatingPointFormat Property (F#)

Gets or sets the floating point format used in the output of the interactive session.

**Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive

**Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)


## CAPS_SYNTAX_MD



```


// Signatures:
member this.FloatingPointFormat :  string
member this.FloatingPointFormat : string with set :  string

// Usage:
interactiveSession.FloatingPointFormat
interactiveSession.FloatingPointFormat <- floatingPointFormat


```



#### CAPS_PARAMETERS_MD
*floatingPointFormat*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)


A format code to use for floating point output in the F# Interactive Session.




## CAPS_REMARKS_MD
The possible format codes are described in [Core.Printf Module &#40;F&#35;&#41;](Core.Printf+Module+%28F%23%29.md). The default value is **g10**.


## Platforms
Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2


## Version Information
**F# Runtime**

Supported in: 2.0, 4.0

**Silverlight**

Supported in: 2, 3


## See Also
[Interactive.InteractiveSession Class &#40;F&#35;&#41;](Interactive.InteractiveSession+Class+%28F%23%29.md)

[Microsoft.FSharp.Compiler.Interactive Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Compiler.Interactive+Namespace+%28F%23%29.md)

