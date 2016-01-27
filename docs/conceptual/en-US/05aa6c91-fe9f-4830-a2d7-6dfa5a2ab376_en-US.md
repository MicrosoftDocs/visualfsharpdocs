# MailboxProcessor.TryScan<'Msg,'T> Method (F#)

Scans for a message by looking through messages in arrival order until a provided function returns a **Some** value. Other messages remain in the queue.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.TryScan : ('Msg -> Async<'T> option) * ?int -> Async<'T option>

// Usage:
mailboxProcessor.TryScan (scanner)
mailboxProcessor.TryScan (scanner, timeout = timeout)
```

#### CAPS_PARAMETERS_MD
*scanner*
Type: **'Msg -&gt;**[Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


A function that returns **None** if the message is to be skipped, or **Some** if the message is to be processed and removed from the queue.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional timeout in milliseconds. Defaults to -1 which corresponds to **F:System.Threading.Timeout.Infinite**.



**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that scanner built off the read message.**
## CAPS_REMARKS_MD
If a timeout period is exceeded, **None** is returned. This method is for use within the body of the agent. For each agent, at most one concurrent reader can be active, so no more than one concurrent call to [Receive](http://msdn.microsoft.com/en-us/library/46a1d8e6-3906-45c2-9722-0ddab574cc6a), [TryReceive](http://msdn.microsoft.com/en-us/library/edcb3930-cefd-4d88-935d-7dd6297355ee), [Scan](http://msdn.microsoft.com/en-us/library/e86368a3-4f97-4b51-a487-4c6b5456fcbe) or **TryScan** can be active. The body of the *scanner* function is locked during its execution, but the lock is released before the execution of the asynchronous workflow.

**The following code example shows how to use the TryScan method. This example is a job submission agent. There are three agents: one called runAgent that starts each job, another called inprogressAgent that represents all running jobs, and one called completeAgent that represents notification that a job is completed. TryScan is used in the cancelJob function to find a job to cancel, or fail if there is no matching job.**
```

    open System
    open System.Threading

    let random = System.Random()


    // Generates mock jobs by using Async.Sleep.
    let createJob(id:int, source:CancellationTokenSource) =
        let job = async {
            // Let the time be a random number between 1 and 10000.
            // The mock computed result is a floating point value.
            let time = random.Next(10000)
            let result = random.NextDouble()
            let count = ref 1
            while (!count <= 100 && not source.IsCancellationRequested) do
                do! Async.Sleep(time / 100)
                count := !count + 1
            return result
            }
        id, job, source

    type Result = double

    // A Job consists of a job ID, a computation that produces a single result,
    // and a cancellation token source object that can be used to cancel the job.
    type Job = int * Async<Result> * CancellationTokenSource

    type Message = int * Result

    let context = System.Threading.SynchronizationContext.Current

    // This agent processes when jobs are completed.
    let completeAgent = MailboxProcessor<Message>.Start(fun inbox ->
        let rec loop n =
            async {
                let! (id, result) = inbox.Receive()
                printfn "The result of job #%d is %f" id result
                do! loop (n + 1)
            }
        loop (0))

    // inprogressAgent maintains a queue of in-progress jobs that can be
    // scanned to remove canceled jobs. It never runs its processor function,
    // so we set it to do nothing.
    let inprogressAgent = new MailboxProcessor<Job>(fun _ -> async { () })

    // This agent starts each job in the order in which it is received.
    let runAgent = MailboxProcessor<Job>.Start(fun inbox ->
        let rec loop n =
            async {          
                let! (id, job, source) = inbox.Receive()
                printfn "Starting job #%d" id
                // Post to the in-progress queue.
                inprogressAgent.Post(id, job, source)
                // Start the job.
                Async.StartWithContinuations(job,
                    (fun result -> completeAgent.Post(id, result)),
                    (fun _ -> ()),
                    (fun cancelException -> printfn "Canceled job #%d" id),
                    source.Token)
                do! loop (n + 1)
                }
        loop (0))

    for id in 1 .. 10 do
        let source = new CancellationTokenSource()
        runAgent.Post(createJob(id, source))

    let cancelJob(cancelId) =
        Async.RunSynchronously(
             inprogressAgent.TryScan((fun (jobId, result, source) ->
                    let action =
                        async {
                            printfn "Canceling job #%d" cancelId
                            source.Cancel()
                            return cancelId
                        }
                    // Return Some(async) if the job ID matches.
                    if (jobId = cancelId) then
                        Some(action)
                    else
                        None), 1000))
        

    printfn "Specify a job by number to cancel it, then press Enter."

    let mutable finished = false
    while not finished do
        let input = System.Console.ReadLine()
        let a = ref 0
        if (Int32.TryParse(input, a) = true) then
            match cancelJob(!a) with
            | Some id -> printfn "A job was canceled: job #%d" id
            | None -> printfn "Job not found."
        else
            printfn "Terminating."
            finished <- true
```

**Following is an example session.**
**Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.&gt; hello1 : Console loop4 : mailboxProcessorReply: Message number 0 was received. Message contents: hello&gt; testing1 : Console loop3 : mailboxProcessorReply: Message number 1 was received. Message contents: testing&gt; hello?1 : Console loop4 : mailboxProcessorReply: Message number 2 was received. Message contents: hello?&gt; testing 1 2 31 : Console loop3 : mailboxProcessorReply: Message number 3 was received. Message contents: testing 1 2 3&gt; Stop1 : Console loop4 : mailboxProcessorPress Enter to continue.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor+%27Msg+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

