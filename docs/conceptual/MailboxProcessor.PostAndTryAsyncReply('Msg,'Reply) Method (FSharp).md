# MailboxProcessor.PostAndTryAsyncReply<'Msg,'Reply> Method (F#)

Like [MailboxProcessor.AsyncPostAndReply](http://msdn.microsoft.com/en-us/library/cd7d03c7-cc82-46f3-9f9a-ed689164e4a8), but returns **None** if no reply within the timeout period.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
member this.PostAndTryAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> Async<'Reply option>

// Usage:
mailboxProcessor.PostAndTryAsyncReply (buildMessage)
mailboxProcessor.PostAndTryAsyncReply (buildMessage, timeout = timeout)
```

#### Parameters
*buildMessage*
Type: [AsyncReplyChannel](http://msdn.microsoft.com/en-us/library/e32fd8ec-37dd-4e63-94a5-67709962d1d0)**&lt;'Reply&gt; -&gt;   'Msg**


The function to incorporate the [AsyncReplyChannel](http://msdn.microsoft.com/en-us/library/e32fd8ec-37dd-4e63-94a5-67709962d1d0) into the message to be sent.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional timeout parameter (in milliseconds) to wait for a reply message. The default is -1 which corresponds to **F:System.Threading.Timeout.Infinite**.



**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that will return the reply or None if the timeout expires.**
## Remarks
**The following code shows how to use the PostAndTryAsyncReply method.**
[!code-fsharp[Main](snippets/fsmailboxprocessor/snippet19.fs)]
**A sample session follows.**
**Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.&gt; test1&gt; Message number 0 was received. Message contents: test1test2&gt; Message number 1 was received. Message contents: test2test3&gt; Message number 2 was received. Message contents: test3test4&gt; Message number 3 was received. Message contents: test4test5&gt; Message number 4 was received. Message contents: test5test6&gt; Reply timeout exceeded.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor%28%27Msg%29+Class+%28FSharp%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28FSharp%29.md)

