# Control.MailboxProcessor<'Msg> Constructor (F#)

Creates an agent.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
new MailboxProcessor : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>

// Usage:
new MailboxProcessor (body)
new MailboxProcessor (body, cancellationToken = cancellationToken)
```

#### CAPS_PARAMETERS_MD
*body*
Type: [MailboxProcessor](http://msdn.microsoft.com/en-us/library/2052c977-f787-4a0b-b25f-9444e26b5fdf)**&lt;'Msg&gt; -&gt;**[Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**&gt;**


The function to produce an asynchronous computation that will be executed as the read loop for the [MailboxProcessor](http://msdn.microsoft.com/en-us/library/2052c977-f787-4a0b-b25f-9444e26b5fdf) when [Start](http://msdn.microsoft.com/en-us/library/ebf18bf3-ba17-42b9-91ac-313a7eee6fa0) is called.


*cancellationToken*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


An optional cancellation token for the *body*. Defaults to [Async.DefaultCancellationToken](http://msdn.microsoft.com/en-us/library/42e3356a-bd73-4174-beef-b36ca2006734).



**The created MailboxProcessor.**
## CAPS_REMARKS_MD
The *body* function is used to generate the asynchronous computation executed by the agent. This function is not executed until [Start](http://msdn.microsoft.com/en-us/library/ebf18bf3-ba17-42b9-91ac-313a7eee6fa0) is called.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessorL%27MsgR+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

