# Async.CancelDefaultToken Method (F#)

Raises the cancellation condition for the most recent set of asynchronous computations started without any specific cancellation token. Replaces the global **T:System.Threading.CancellationTokenSource** object with a new global token source for any asynchronous computations created after this point without any specific cancellation token.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member CancelDefaultToken : unit -> unit

// Usage:
Async.CancelDefaultToken ()
```

## CAPS_REMARKS_MD
**The following example shows how to create a cancellable asynchronous operation in a Windows Forms application. It also shows how to use Async.CancelDefaultToken to cancel the operation.**
```

    open System.Windows.Forms

    let bufferData = Array.zeroCreate<byte> 100000000

    let async1 (label:System.Windows.Forms.Label) filename =
         Async.StartWithContinuations(
             async {
                label.Text <- "Operation started."
                use outputFile = System.IO.File.Create(filename)
                do! outputFile.AsyncWrite(bufferData)
                },
             (fun _ -> label.Text <- "Operation completed."),
             (fun _ -> label.Text <- "Operation failed."),
             (fun _ -> label.Text <- "Operation canceled."))
        
      

    let form = new Form(Text = "Test Form")
    let button1 = new Button(Text = "Start")
    let button2 = new Button(Text = "Start Invalid", Top = button1.Height + 10)
    let button3 = new Button(Text = "Cancel", Top = 2 * button1.Height + 20)
    let label1 = new Label(Text = "", Width = 200, Top = 3 * button1.Height + 30)
    form.Controls.AddRange [| button1; button2; button3; label1 |]
    button1.Click.Add(fun args -> async1 label1 "longoutput.dat")
    // Try an invalid filename to test the error case.
    button2.Click.Add(fun args -> async1 label1 "|invalid.dat")
    button3.Click.Add(fun args -> Async.CancelDefaultToken())
    Application.Run(form)
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

