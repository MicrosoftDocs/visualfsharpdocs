# Handler.Invoke<'T> Method (F#)

Calls the function or functions associated with the event handler.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
abstract this.Invoke : obj * 'T -> unit

// Usage:
handler.Invoke (sender, args)

```



#### Parameters
*sender*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The object that fired the event.


*args*
Type: **'T**


The event arguments.




## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Handler&#60;'T&#62; Class &#40;F&#35;&#41;](Control.Handler%5B%27T%5D-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

