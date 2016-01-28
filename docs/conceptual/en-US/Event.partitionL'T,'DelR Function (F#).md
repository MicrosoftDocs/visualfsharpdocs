# Event.partition<'T,'Del> Function (F#)

Returns a new event that listens to the original event and triggers the first resulting event if the application of the predicate to the event arguments returned **true**, and the second event if it returned **false**.

**Namespace/Module Path**: Microsoft.FSharp.Control.Event

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Event.partition : ('T -> bool) -> IEvent<'Del,'T> -> IEvent<'T> * IEvent<'T> (requires delegate)

// Usage:
Event.partition predicate sourceEvent
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to determine which output event to trigger.


*sourceEvent*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The input event.



**A tuple of events. The first is triggered when the predicate evaluates to true and the second when the predicate evaluates to false.**
## CAPS_REMARKS_MD
This function is named **Partition** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use the Event.partition function to split an event into two events, each with its own event handling code.**
```

    open System.Windows.Forms
    open System.Drawing

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)

    let (event1, event2) =
        form.MouseMove 
        |> Event.partition (fun evArgs -> evArgs.X > 100)

    event1 |> Event.add ( fun evArgs ->
        form.BackColor <- System.Drawing.Color.FromArgb(
            evArgs.X, evArgs.Y, evArgs.X ^^^ evArgs.Y))
    event2 |> Event.add ( fun evArgs ->
        form.BackColor <- System.Drawing.Color.FromArgb(
            evArgs.Y, evArgs.X, evArgs.Y ^^^ evArgs.X))
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

