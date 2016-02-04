# Event.split<'T,'U1,'U2,'Del> Function (F#)

Returns a new event that listens to the original event and triggers the first resulting event if the application of the function to the event arguments returned a **Choice1Of2**, and the second event if it returns a **Choice2Of2**.

**Namespace/Module Path:** Microsoft.FSharp.Control.Event

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Event.split : ('T -> Choice<'U1,'U2>) -> IEvent<'Del,'T> -> IEvent<'U1> * IEvent<'U2> (requires delegate)

// Usage:
Event.split splitter sourceEvent


```



#### CAPS_PARAMETERS_MD
*splitter*
Type: **'T -&gt;**[Choice](http://msdn.microsoft.com/en-us/library/2ab2513e-e307-4360-96cd-8b682a8d64f0)**&lt;'U1,'U2&gt;**


A function, typically an active pattern recognizer, that transforms event values into one of two types.


*sourceEvent*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The input event.



**A tuple of events. The first fires whenever splitter evaluates to Choice1of1 and the second fires whenever splitter evaluates to Choice2of2.**
## CAPS_REMARKS_MD
This function is named **Split** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use the Event.split function to implement the ability to move a control on a form. The splitter function is the active pattern recognizer (|Down|Up|), which represents the state of the mouse buttons. If a user presses the mouse button while moving the mouse when it is over the button, the button moves. There is also code that sometimes changes the color of the button while it is moving, depending on which mouse button is used. This test uses a different color for each mouse button. The other event path, which is used when the mouse button is not down, restores the original color of the button after the button is released.**


```



    open System.Windows.Forms
    open System.Drawing
    open Microsoft.FSharp.Core

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)

    let button = new Button(Text = "Button",
                            Visible = true,
                            Left = 100,
                            Width = 50,
                            Top = 100,
                            Height = 20)

    form.Controls.Add(button)
    let originalColor = button.BackColor
    let mutable xOff, yOff = (0, 0)

    let (|Down|Up|) (evArgs:MouseEventArgs) =
        match evArgs.Button with
        | MouseButtons.Left 
        | MouseButtons.Right 
        | MouseButtons.Middle -> Down(evArgs)
        | _ -> Up

    button.MouseDown 
    |> Event.add(fun evArgs ->
        xOff <- evArgs.X
        yOff <- evArgs.Y)

    form.MouseMove
    |> Event.map (fun evArgs -> (evArgs.X, evArgs.Y))
    |> Event.add (fun (x, y) -> form.Text <- sprintf "(%d, %d)" x y)

    let (dragButton, noDragButton) = Event.split (|Down|Up|) button.MouseMove

    // Move the button, and change its color if the user uses the
    // right or middle mouse button.
    dragButton |> Event.add ( fun evArgs ->
        match evArgs.Button with
        | MouseButtons.Left ->
            button.BackColor <- originalColor
        | MouseButtons.Right ->
            button.BackColor <- Color.Red
        | MouseButtons.Middle ->
            button.BackColor <- Color.Blue
        | _ -> ()
        button.Left <- button.Left + evArgs.X - xOff
        button.Top <- button.Top + evArgs.Y - yOff
        button.Refresh())

    // Restore the button's original color when the mouse is moved after
    // the release of the button.
    noDragButton |> Event.add ( fun () -> 
        button.BackColor <- originalColor)


```



## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

