# MailboxProcessor.Error<'Msg> Property (F#)

Occurs when the execution of the agent results in an exception.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
member this.Error :  [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432)<Exception>

// Usage:
mailboxProcessor.Error
```
**The error event as an object that implements [IEvent](http://msdn.microsoft.com/en-us/library/7976554f-9aa8-451f-a69d-d4670c064432)**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
**The following code shows how to use the Error event to handle an exception that occurs in the body of the agent.**
**[!CODE [FsMailboxProcessor#23](../CodeSnippet/VS_Snippets_Fsharp/fsmailboxprocessor/FSharp/fs/program.fs#23)]**
**An example session follows.**
**Mailbox Processor TestType some text and press Enter to submit a message.helloMessage number 0. Message contents: hellotestingMessage number 1. Message contents: testingThe agent timed out.Press Enter to close the program.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor%3C%27Msg%3E+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

