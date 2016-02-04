# InteractiveSession.CommandLineArgs Property (F#)

The command line arguments after ignoring the arguments relevant to the interactive environment and replacing the first argument with the name of the last script file, if any.

**Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive

**Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)


## CAPS_SYNTAX_MD



```


// Signatures:
member this.CommandLineArgs :  string []
member this.CommandLineArgs : string [] with set :  string []

// Usage:
interactiveSession.CommandLineArgs
interactiveSession.CommandLineArgs <- commandLineArgs


```



#### CAPS_PARAMETERS_MD
commandLineArgs
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a)[Core.string Type Abbreviation &#40;F&#35;&#41;](Core.string+Type+Abbreviation+%28F%23%29.md)[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The array of command line arguments.




## CAPS_REMARKS_MD
For example, the command line **fsi.exe test1.fs test2.fs -- hello goodbye**will give arguments **test2.fs**, **hello**, **goodbye**. This value will normally be different to those returned by **M:System.Environment.GetCommandLineArgs**.


## Platforms
Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2


## Version Information
**F# Runtime**

Supported in: 2.0, 4

**Silverlight**

Supported in: 3


## See Also
[Interactive.InteractiveSession Class &#40;F&#35;&#41;](Interactive.InteractiveSession+Class+%28F%23%29.md)

[Microsoft.FSharp.Compiler.Interactive Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Compiler.Interactive+Namespace+%28F%23%29.md)

