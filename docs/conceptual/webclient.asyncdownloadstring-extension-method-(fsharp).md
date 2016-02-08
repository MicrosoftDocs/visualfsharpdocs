# WebClient.AsyncDownloadString Extension Method (F#)

Returns an asynchronous computation that, when run, will wait for the download of the given URI.

**Namespace/Module Path:** Microsoft.FSharp.Control.WebExtensions

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
type System.Net.WebClient with
member AsyncDownloadString : Uri -> Async<string>

// Usage:
webClient.AsyncDownloadString (address)

```



#### Parameters
*address*
Type: **T:System.Uri**


The URI to retrieve.



**An asynchronous computation ([Async](http://msdn.microsoft.com/en-us/library/03eb4d12-a01a-4565-a077-5e83f17cf6f7) object) that will wait for the return of the URI.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0




## See Also
[Control.WebExtensions Module &#40;F&#35;&#41;](Control.WebExtensions-Module-%28FSharp%29.md)

