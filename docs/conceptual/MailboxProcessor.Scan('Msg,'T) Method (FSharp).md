# MailboxProcessor.Scan<'Msg,'T> Method (F#)

Scans for a message by looking through messages in arrival order until a provided function returns a **Some** value. Other messages remain in the queue.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
member this.Scan : ('Msg -> Async<'T> option) * ?int -> Async<'T>

// Usage:
mailboxProcessor.Scan (scanner)
mailboxProcessor.Scan (scanner, timeout = timeout)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*scanner*
Type: **'Msg -&gt;**[Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


A function that returns **None** if the message is to be skipped, or **Some** if the message is to be processed and removed from the queue.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional timeout in milliseconds. Defaults to -1 which corresponds to **F:System.Threading.Timeout.Infinite**.



**exceptions tag is not supported!!!!**
**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that scanner built off the read message.**
## Remarks
This method is for use within the body of the agent. For each agent, at most one concurrent reader may be active, so no more than one concurrent call to [Receive](http://msdn.microsoft.com/en-us/library/46a1d8e6-3906-45c2-9722-0ddab574cc6a), [TryReceive](http://msdn.microsoft.com/en-us/library/edcb3930-cefd-4d88-935d-7dd6297355ee), **Scan** or [TryScan](http://msdn.microsoft.com/en-us/library/05aa6c91-fe9f-4830-a2d7-6dfa5a2ab376) may be active. The body of the *scanner* function is locked during its execution, but the lock is released before the execution of the asynchronous workflow.

**The following example shows how to use the Scan method. In this code, mailbox processor agents manage a series of simulated jobs that run and compute a result.**
[!code-fsharp[Main](snippets/fsmailboxprocessor/snippet21.fs)]
**A sample session follows.**
**Number Of Logical Processors: 2Requesting job #1Job #1 submitted.Job #1 started on procId 0.Requesting job #2Job #2 submitted.Job #2 started on procId 1.Requesting job #3Requesting job #4Requesting job #5Requesting job #6Requesting job #7Requesting job #8Requesting job #9Requesting job #10Job #1 completed.Nth Prime for N = 5000 is 48611.Job #3 submitted.Job #3 started on procId 0.Done submitting jobs. Press Enter to exit when ready.Job #2 completed.Nth Prime for N = 10000 is 104729.Job #4 submitted.Job #4 started on procId 1.Job #3 completed.Nth Prime for N = 15000 is 163841.Job #5 submitted.Job #5 started on procId 0.Job #4 completed.Nth Prime for N = 20000 is 224737.Job #6 submitted.Job #6 started on procId 1.Job #5 completed.Nth Prime for N = 25000 is 287117.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor%3C%27Msg%3E+Class+%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

