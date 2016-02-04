# Async.FromContinuations<'T> Method (F#)

Creates an asynchronous computation that captures the current success, exception and cancellation continuations. The callback must eventually call exactly one of the given continuations.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
static member FromContinuations : (('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) -> unit) -> Async<'T>

// Usage:
Async.FromContinuations (callback)


```



#### CAPS_PARAMETERS_MD
*callback*
Type: **('T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**) &#42; (**[exn](http://msdn.microsoft.com/en-us/library/e1569b69-3b30-440b-8c6f-966d1c6a06ab)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**) &#42; (****T:System.OperationCanceledException****-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**) -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function that accepts the current success, exception, and cancellation continuations.



**An asynchronous computation that provides the callback with the current continuations.**
## CAPS_REMARKS_MD
The argument for this method is a lambda expression that takes three continuation functions, which are typically called **cont** (the success continuation), **ccont** (the cancel continuation) and **econt** (the error continuation), as the following code shows:




```


Async.FromContinuations (fun (cont, ccont, econt) -> ...)


```



>[!WARNING] {If you use this method, you must call exactly one of the continuation functions or else throw an exception, in which case F# calls **econt** with the exception on your behalf. If you call more than one continuation, call any continuation more than once, or both call a continuation and throw an exception, any subsequent use of the resulting async object may have undefined behavior.

}
**The following example illustrates how to use Async.FromContinuations to wrap an event-based asynchronous computation as an F# async.**


```



    open System
    open System.ComponentModel
    open System.Windows.Forms

    type BackgroundWorker with
            member this.AsyncRunWorker (computation, argument : 'T, progressChangedHandler) : Async<'U> =
                let workerAsync =
                    Async.FromContinuations (fun (cont, econt, ccont) ->
                                let handler = new RunWorkerCompletedEventHandler (fun sender args ->          
                                    if args.Cancelled then
                                        ccont (new OperationCanceledException()) 
                                    elif args.Error <> null then
                                        econt args.Error
                                    else
                                        cont (args.Result :?> 'U))
                                this.WorkerSupportsCancellation <- true;
                                this.WorkerReportsProgress <- true
                                this.DoWork.AddHandler(new DoWorkEventHandler(fun sender args ->
                                    args.Result <- computation(argument, this, args)))
                                this.ProgressChanged.AddHandler(progressChangedHandler)
                                this.RunWorkerCompleted.AddHandler(handler)
                                this.RunWorkerAsync(argument)
                            )

                async { 
                    use! holder = Async.OnCancel(fun _ -> this.CancelAsync())
                    return! workerAsync
                 }

    let factorial number =
        let rec fact number =
            match number with
            | value when value < 0I ->
                raise (InvalidOperationException(sprintf "Cannot compute the factorial of a negative number: %s." (value.ToString())))
            | value when value > 2000I ->
                raise (InvalidOperationException(sprintf "Input too large: %s" (value.ToString())))
            | value when value = 0I -> 1I
            | value when value = 1I -> 1I
            | number -> number * fact (number - 1I)
        fact number

    // Recursive isprime function.
    let isprime number =
        let rec check count =
            count > number/2 || (number % count <> 0 && check (count + 1))
        check 2

    let isprimeBigInt number =
        let rec check count =
            count > number/2I || (number % count <> 0I && check (count + 1I))
        check 2I

    let computeNthPrime (number, worker: BackgroundWorker, eventArgs: DoWorkEventArgs) =
         if (number < 1) then
             invalidOp <| sprintf "Invalid input for nth prime: %s." (number.ToString())
         let mutable count = 0
         let mutable num = 1I
         let isDone = false
         while (count < number && not eventArgs.Cancel ) do
             if (worker.CancellationPending) then
                 eventArgs.Cancel <- true
             else
                 let percentComplete = int ((float count) / (float number) * 100.0)
                 worker.ReportProgress(percentComplete, num.ToString())
             num <- num + 1I
             if (num < bigint System.Int32.MaxValue) then
                 while (not (isprime (int num))) do
                     num <- num + 1I
             else
                 while (not (isprimeBigInt num)) do
                     num <- num + 1I
             count <- count + 1
         num
             
    let async1 (progressBar:ProgressBar) (label:Label) value =
         let worker = new BackgroundWorker()
         label.Text <- "Computing..."
         let computation value = worker.AsyncRunWorker(computeNthPrime, value,
                                                       (fun sender eventArgs ->
                                                           label.Text <- "Scanning ... " + eventArgs.UserState.ToString()
                                                           progressBar.Value <- eventArgs.ProgressPercentage ))
         Async.StartWithContinuations(
             computation value,
             (fun result -> label.Text <- sprintf "Result: %s" (result.ToString())),
             (fun exn -> label.Text <- "Operation failed with error:" + exn.Message),
             (fun _ -> label.Text <- "Operation canceled."))

    let form = new Form(Text = "Test Form", Width = 400, Height = 400)
    let panel1 = new Panel(Dock = DockStyle.Fill)
    panel1.DockPadding.All <- 10
    let spacing = 5
    let button1 = new Button(Text = "Start")
    let button2 = new Button(Text = "Start Invalid", Top = button1.Height + spacing)
    let button3 = new Button(Text = "Cancel", Top = 2 * (button1.Height + spacing))
    let updown1 = new System.Windows.Forms.NumericUpDown(Top = 3 * (button1.Height + spacing), 
                                                         Value = 20m,
                                                         Minimum = 0m,
                                                         Maximum = 1000000m)
    let label1 = new Label (Text = "", Top = 4 * (button1.Height + spacing),
                            Width = 300, Height = 2 * button1.Height)
    let progressBar = new ProgressBar(Top = 6 * (button1.Height + spacing),
                                      Width = 300)
    panel1.Controls.AddRange [| button1; button2; button3; updown1; label1; progressBar; |]
    form.Controls.Add(panel1)
    button1.Click.Add(fun args -> async1 progressBar label1 (int updown1.Value))
    button2.Click.Add(fun args -> async1 progressBar label1 (int (-updown1.Value)))
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

