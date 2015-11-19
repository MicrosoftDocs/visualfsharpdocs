# MailboxProcessor.Receive<'Msg> Method (F#)

Waits for a message. This will consume the first message in arrival order.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
member this.Receive : ?int -> Async<'Msg>

// Usage:
mailboxProcessor.Receive ()
mailboxProcessor.Receive (timeout = timeout)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional timeout in milliseconds. Defaults to -1 which corresponds to **F:System.Threading.Timeout.Infinite**.



**exceptions tag is not supported!!!!**
**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that returns the received message.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This method is for use within the body of the agent. For each agent, at most one concurrent reader may be active, so no more than one concurrent call to **Receive**, [TryReceive](http://msdn.microsoft.com/en-us/library/edcb3930-cefd-4d88-935d-7dd6297355ee), [Scan](http://msdn.microsoft.com/en-us/library/e86368a3-4f97-4b51-a487-4c6b5456fcbe) or [TryScan](http://msdn.microsoft.com/en-us/library/05aa6c91-fe9f-4830-a2d7-6dfa5a2ab376) may be active.

**The following example shows how to use the Receive method. In this case, a timeout of 10 seconds is specified. In general, the message processing function runs on a different thread from the [Post](http://msdn.microsoft.com/en-us/library/70597a62-6aa9-4565-9b37-c0877cd3283b) function, so you must catch the timeout exception in the message processor function. In this example, the timeout exception just causes the loop to continue, and increases the message number by 1.**
**[!CODE [FsMailboxProcessor#10](../CodeSnippet/VS_Snippets_Fsharp/fsmailboxprocessor/FSharp/fs/program.fs#10)]**
**A typical session follows. Notice that message 2 is skipped, due to the timeout.**
**&gt; helloReply: Message number 0 was received. Message contents: hello&gt; hello?Reply: Message number 1 was received. Message contents: hello?&gt; The mailbox processor timed out.anyone there?Reply: Message number 3 was received. Message contents: anyone there?&gt;**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor%3C%27Msg%3E+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

