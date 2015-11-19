# Event.map<'T,'U,'Del> Function (F#)

Returns a new event that passes values transformed by the given function.

**Namespace/Module Path:** Microsoft.FSharp.Control.Event

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Event.map : ('T -> 'U) -> IEvent<'Del,'T> -> IEvent<'U> (requires delegate)

// Usage:
Event.map mapping sourceEvent
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*mapping*
Type: **'T -&gt; 'U**


The function to transform event values.


*sourceEvent*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The input event.



**An event that passes the transformed values.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Map** in the compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use the Event.map function. In this example, the event handler arguments are transformed into a more convenient format.**
**[!CODE [FsEvents#4](../CodeSnippet/VS_Snippets_Fsharp/fsevents/FSharp/fs/program.fs#4)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library VersionsF# Core Library Versions**

Supported in: 2.0, 4.0, Portable2.0, 4.0, Portable, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

