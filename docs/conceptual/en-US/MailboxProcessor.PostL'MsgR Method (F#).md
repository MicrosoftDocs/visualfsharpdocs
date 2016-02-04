# MailboxProcessor.Post<'Msg> Method (F#)

Posts a message to the message queue of the [MailboxProcessor](http://msdn.microsoft.com/en-us/library/2052c977-f787-4a0b-b25f-9444e26b5fdf), asynchronously.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
member this.Post : 'Msg -> unit

// Usage:
mailboxProcessor.Post (message)


```



#### CAPS_PARAMETERS_MD
*message*
Type: **'Msg**


The message to post.




## CAPS_REMARKS_MD
**The following code example shows how to start a mailbox processor agent and post messages to it.**


```



    open System
    open Microsoft.FSharp.Control

    type Message(id, contents) =
        static let mutable count = 0
        member this.ID = id
        member this.Contents = contents
        static member CreateMessage(contents) =
            count <- count + 1
            Message(count, contents)

    let mailbox = new MailboxProcessor<Message>(fun inbox ->
        let rec loop count =
            async { printfn "Message count = %d. Waiting for next message." count
                    let! msg = inbox.Receive()
                    printfn "Message received. ID: %d Contents: %s" msg.ID msg.Contents
                    return! loop( count + 1) }
        loop 0)

    mailbox.Start()

    mailbox.Post(Message.CreateMessage("ABC"))
    mailbox.Post(Message.CreateMessage("XYZ"))


    Console.WriteLine("Press any key...")
    Console.ReadLine() |> ignore


```



**Following is an example session.**
**Press any key...**
**Message count = 0. Waiting for next message.**
**Message received. ID: 1 Contents: ABC**
**Message count = 1. Waiting for next message.**
**Message received. ID: 2 Contents: XYZ**
**Message count = 2. Waiting for next message.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor+%27Msg+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

