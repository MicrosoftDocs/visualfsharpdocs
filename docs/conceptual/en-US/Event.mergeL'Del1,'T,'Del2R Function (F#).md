# Event.merge<'Del1,'T,'Del2> Function (F#)

Fires the output event when either of the input events fire.

**Namespace/Module Path:** Microsoft.FSharp.Control.Event

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Event.merge : IEvent<'Del1,'T> -> IEvent<'Del2,'T> -> IEvent<'T> (requires delegate and delegate)

// Usage:
Event.merge event1 event2
```

#### CAPS_PARAMETERS_MD
*event1*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del1,'T&gt;**


The first input event.


*event2*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del2,'T&gt;**


The second input event.



**An event that fires when either of the input events fire.**
## CAPS_REMARKS_MD
This function is named **Merge** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use the Event.merge function.**
```

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)
    form.MouseClick
        |> Event.merge(form.MouseDoubleClick)
        |> Event.add ( fun evArgs ->
            form.BackColor <- System.Drawing.Color.FromArgb(
                evArgs.X, evArgs.Y, evArgs.X ^^^ evArgs.Y) )
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

