# Event.pairwise<'Del,'T> Function (F#)

Returns a new event that triggers on the second and subsequent triggerings of the input event. The Nth triggering of the input event passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.

**Namespace/Module Path**: Microsoft.FSharp.Control.Event

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Event.pairwise : IEvent<'Del,'T> -> IEvent<'T * 'T> (requires delegate)

// Usage:
Event.pairwise sourceEvent


```



#### CAPS_PARAMETERS_MD
*sourceEvent*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The input event.



**An event that triggers on pairs of consecutive values passed from the source event.**
## CAPS_REMARKS_MD
This function is named **Pairwise** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use the Event.pairwise function. In this example, the function makes data available from more than one MouseMove event, and the data is used to draw a line between consecutive mouse positions.**


```



    open System.Windows.Forms
    open System.Drawing

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)

    let graphics = BufferedGraphicsManager.Current.Allocate(form.CreateGraphics(), 
                                    new Rectangle( 0, 0, form.Width, form.Height ))
    let whitePen = new Pen(Color.White)

    form.MouseClick
        |> Event.pairwise
        |> Event.add ( fun (evArgs1, evArgs2) ->
            graphics.Graphics.DrawLine(whitePen, evArgs1.X, evArgs1.Y, evArgs2.X, evArgs2.Y)
            form.Refresh())

    form.Paint
        |> Event.add(fun evArgs -> graphics.Render(evArgs.Graphics))


```



## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

