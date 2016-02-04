# Async.AwaitEvent<'Del,'T> Method (F#)

Creates an asynchronous computation that waits for a single invocation of a CLI event by adding a handler to the event. Once the computation completes or is cancelled, the handler is removed from the event.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
static member AwaitEvent : IEvent<'Del,'T> * ?(unit -> unit) -> Async<'T> (requires delegate)

// Usage:
Async.AwaitEvent (event)
Async.AwaitEvent (event, cancelAction = cancelAction)


```



#### CAPS_PARAMETERS_MD
*event*
Type: [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)**&lt;'Del,'T&gt;**


The event to handle once.


*cancelAction*
Type: **(**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**)**


An optional function to execute instead of cancelling when a cancellation is issued.



**An asynchronous computation that waits for the event to be invoked.**
## CAPS_REMARKS_MD
The computation will respond to cancellation while waiting for the event. If a cancellation occurs, and **cancelAction** is specified, then it is executed, and the computation continues to wait for the event. If **cancelAction** is not specified, then cancellation causes the computation to cancel immediately.

**The following code example demonstrates how to use Async.AwaitEvent to set up a file operation that runs in response to an event that indicates that a file is changed. In this case, waiting for the event prevents an attempt to access the file while it is locked.**


```



    open System.Windows.Forms
    open System.IO

    let filename = "longoutput.dat"
    if File.Exists(filename) then
        File.Delete(filename)
    let watcher = new FileSystemWatcher(Path = Directory.GetCurrentDirectory(),
                                        NotifyFilter = NotifyFilters.LastWrite,
                                        Filter = filename)
    watcher.Changed.Add(fun args -> printfn "The file %s is changed." args.Name)
    watcher.EnableRaisingEvents <- true

    let testFile = File.CreateText("Test.txt")
    testFile.WriteLine("Testing...")
    testFile.Close()

    let form = new Form(Text = "Test Form")
    let buttonSpacing = 5
    let button1 = new Button(Text = "Start")
    let button2 = new Button(Text = "Start Invalid", Top = button1.Height + buttonSpacing)
    let button3 = new Button(Text = "Cancel", Top = 2 * (button1.Height + buttonSpacing))
    let label1 = new Label(Text = "", Width = 200, Top = 3 * (button1.Height + buttonSpacing))
    let label2 = new Label(Text = "", Width = 200, Top = 4 * (button1.Height + buttonSpacing))
    form.Controls.AddRange [| button1; button2; button3; label1 |]
    form.Controls.Add(button1)

    let bufferData = Array.zeroCreate<byte> 100000000

    let async1 filename =
         async {
           printfn "Creating file %s." filename
           use outputFile = File.Create(filename)
           printfn "Attempting to write to file %s." filename
           do! outputFile.AsyncWrite(bufferData) 
         }

    let async2 filename =
         async {
           printfn "Waiting for file system watcher notification."
           // If you omit the call to AwaitEvent, an exception is thrown that indicates that the
           // file is locked.
           let! args = Async.AwaitEvent(watcher.Changed)
           printfn "Attempting to open and read file %s." filename
           use inputFile = File.OpenRead(filename)
           let! buffer = inputFile.AsyncRead(100000000)
           printfn "Successfully read file %s." filename
           return buffer
         }   
    
    button1.Click.Add(fun _ ->
                      // Start these as tasks simultaneously.
                      Async.StartAsTask(async1 filename) |> ignore
                      Async.StartAsTask(async2 filename) |> ignore
                      ())
    button2.Click.Add(fun _ ->
                      Async.StartAsTask(async1 filename) |> ignore
                      Async.StartAsTask(async2 "longoutputX.dat")  |> ignore
                      ())
    Application.Run(form)


```



**Sample Output**
**Creating file Waiting for file sylongoutput.dat.**
**stem watcher notification.**
**Attempting to write to file longoutput.dat.**
**The file longoutput.dat is changed.**
**The file longoutput.dat is changed.**
**Attempting to open and read file longoutput.dat.**
**Successfully read file longoutput.dat.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

