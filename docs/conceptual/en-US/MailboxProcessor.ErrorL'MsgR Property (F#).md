# MailboxProcessor.Error<'Msg> Property (F#)

Occurs when the execution of the agent results in an exception.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
member this.Error :  [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432)<Exception>

// Usage:
mailboxProcessor.Error


```


**The error event as an object that implements [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432)**
## CAPS_REMARKS_MD
**The following code shows how to use the Error event to handle an exception that occurs in the body of the agent.**


```



    open System

    type Message = string

    let agent = MailboxProcessor<Message>.Start(fun inbox ->
        let rec loop n =
            async {
                    let! message = inbox.Receive(10000);
                    printfn "Message number %d. Message contents: %s" n message
                    do! loop (n + 1)
            }
        loop 0)

    agent.Error.Add(fun exn ->
        match exn with
        | :? System.TimeoutException as exn -> printfn "The agent timed out."
                                               printfn "Press Enter to close the program."
                                               Console.ReadLine() |> ignore
                                               exit(1)
        | _ -> printfn "Unknown exception.")

    printfn "Mailbox Processor Test"
    printfn "Type some text and press Enter to submit a message."
      
    while true do
        Console.ReadLine() |> agent.Post


```



**An example session follows.**
**Mailbox Processor TestType some text and press Enter to submit a message.helloMessage number 0. Message contents: hellotestingMessage number 1. Message contents: testingThe agent timed out.Press Enter to close the program.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor+%27Msg+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

