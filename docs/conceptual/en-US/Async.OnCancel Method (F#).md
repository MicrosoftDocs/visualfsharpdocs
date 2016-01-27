# Async.OnCancel Method (F#)

Generates a scoped, cooperative cancellation handler for use within an asynchronous workflow.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member OnCancel : (unit -> unit) -> Async<IDisposable>

// Usage:
Async.OnCancel (interruption)
```

#### CAPS_PARAMETERS_MD
*interruption*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function that is executed on the thread performing the cancellation.



**An asynchronous computation that triggers the interruption if it is cancelled before being disposed.**
## CAPS_REMARKS_MD
For example, the following code generates an asynchronous computation where, if a cancellation happens any time during the execution of the asynchronous computation in the scope of **holder**, then action **interruption** is executed on the thread that is performing the cancellation. This can be used to arrange for a computation to be asynchronously notified that a cancellation has occurred, for example, by setting a flag, or deregistering a pending I/O action.


```f#
async { use! holder = Async.OnCancel interruption ... }
```
**The following code example demonstrates the use of Async.OnCancel.**
```

    // This is a simulated cancellable computation. It checks the token source
    // to see whether the cancel signal was received.
    let computation (tokenSource:System.Threading.CancellationTokenSource) =
        async {
            use! cancelHandler = Async.OnCancel(fun () -> printfn "Canceling operation.")
            // Async.Sleep checks for cancellation at the end of the sleep interval,
            // so loop over many short sleep intervals instead of sleeping
            // for a long time.
            while true do
                do! Async.Sleep(100)
        }

    let tokenSource1 = new System.Threading.CancellationTokenSource()
    let tokenSource2 = new System.Threading.CancellationTokenSource()

    Async.Start(computation tokenSource1, tokenSource1.Token)
    Async.Start(computation tokenSource2, tokenSource2.Token)
    printfn "Started computations."
    System.Threading.Thread.Sleep(1000)
    printfn "Sending cancellation signal."
    tokenSource1.Cancel()
    tokenSource2.Cancel()

    // Wait for user input to prevent application termination.
    System.Console.ReadLine() |> ignore
```

**Output**
**Started computations.**
**Sending cancellation signal.**
**Canceling operation.**
**Canceling operation.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

