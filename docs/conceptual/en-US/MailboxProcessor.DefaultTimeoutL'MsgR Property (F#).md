# MailboxProcessor.DefaultTimeout<'Msg> Property (F#)

Gets or sets the current default timeout.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signatures:
member this.DefaultTimeout :  int with get, set

// Usage:
mailboxProcessor.DefaultTimeout
mailboxProcessor.DefaultTimeout <- defaultTimeout


```



#### CAPS_PARAMETERS_MD
*value*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The timeout, in milliseconds.




## CAPS_REMARKS_MD
The [MailboxProcessor](http://msdn.microsoft.com/en-us/library/2052c977-f787-4a0b-b25f-9444e26b5fdf) raises a timeout exception if a message is not received in this amount of time. If this property is not set, no timeout is used.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.MailboxProcessor&#60;'Msg&#62; Class &#40;F&#35;&#41;](Control.MailboxProcessor+%27Msg+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

