# MailboxProcessor.TryPostAndReply<'Msg,'Reply> Method (F#)

Like [MailboxProcessor.PostAndReply](http://msdn.microsoft.com/en-us/library/11842a52-ea51-45e8-86c4-72e887fedf71), but returns **None** if there is no reply within the timeout period.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.TryPostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> 'Reply option

// Usage:
mailboxProcessor.TryPostAndReply (buildMessage)
mailboxProcessor.TryPostAndReply (buildMessage, timeout = timeout)
```

#### CAPS_PARAMETERS_MD
*buildMessage*
Type: [AsyncReplyChannel](http://msdn.microsoft.com/en-us/library/e32fd8ec-37dd-4e63-94a5-67709962d1d0)**&lt;'Reply&gt; -&gt;   'Msg**


The function to incorporate the [AsyncReplyChannel](http://msdn.microsoft.com/en-us/library/e32fd8ec-37dd-4e63-94a5-67709962d1d0) into the message to be sent.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional timeout parameter (in milliseconds) to wait for a reply message. Defaults to -1 which corresponds to **F:System.Threading.Timeout.Infinite**.



**The reply from the agent or None if the timeout expires.**
## CAPS_REMARKS_MD
**The following example shows how to use TryPostAndReply. In this example, the agent has a delay that eventually results in a timeout.**
```

    open System

    type Message = string * AsyncReplyChannel<string>

    let formatString = "Message number {0} was received. Message contents: {1}"

    let agent = MailboxProcessor<Message>.Start(fun inbox ->
        let rec loop n =
            async {
                    let! (message, replyChannel) = inbox.Receive();
                    // The delay gets longer with each message, and eventually will trigger a timeout.
                    do! Async.Sleep(200 * n );
                    if (message = "Stop") then
                        replyChannel.Reply("Stop")
                    else
                        replyChannel.Reply(String.Format(formatString, n, message))
                    do! loop (n + 1)
            }
        loop 0)

    let asyncReadInput =
       async {
           printf "> "
           let input = Console.ReadLine();
           return input
       }

    printfn "Mailbox Processor Test"
    printfn "Type some text and press Enter to submit a message."
    printfn "Type 'Stop' to close the program."

    let rec loop() =
        Async.StartWithContinuations(asyncReadInput, (fun input ->
            let reply = agent.TryPostAndReply((fun replyChannel -> input, replyChannel), 1000)
            match reply with
            | None -> printfn "Timeout exceeded."
            | Some(reply) ->
                if (reply <> "Stop") then
                    printfn "Reply: %s" reply
                    loop()
                else
                    ()),
            (fun exn -> ()),
            (fun _ -> ()))
    loop()

    printfn "Press Enter to continue."
    Console.ReadLine() |> ignore
```

**A sample session follows.**
**Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.&gt; test1Reply: Message number 0 was received. Message contents: test1&gt; test2Reply: Message number 1 was received. Message contents: test2&gt; test3Reply: Message number 2 was received. Message contents: test3&gt; test4Reply: Message number 3 was received. Message contents: test4&gt; test5Reply: Message number 4 was received. Message contents: test5&gt; test6Timeout exceeded.Press Enter to continue.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor+%27Msg+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

