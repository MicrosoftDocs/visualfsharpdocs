# Event.choose<'T,'U,'Del> Function (F#)

Returns a new event which fires on a selection of messages from the original event. The selection function takes an original message to an optional new message.

**Namespace/Module Path:** Microsoft.FSharp.Control.Event

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Event.choose : ('T -> 'U option) -> IEvent<'Del,'T> -> IEvent<'U> (requires delegate)

// Usage:
Event.choose chooser sourceEvent
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*chooser*
Type: **'T -&gt; 'U**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The function to select and transform event values to pass on.


*sourceEvent*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The input event.



**An event that fires only when the chooser returns Some.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Choose** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example shows how to use the Event.choose function. In this example, the function is used to select only events when the mouse button is down. At the same time, the function transforms the input data of type MouseEventArgs into a more convenient format, a tuple of two integers that represent the current mouse position.**
**[!CODE [FsEvents#2](../CodeSnippet/VS_Snippets_Fsharp/fsevents/FSharp/fs/program.fs#2)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

