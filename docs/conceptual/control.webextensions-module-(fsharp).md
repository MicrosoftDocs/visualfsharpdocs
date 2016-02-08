# Control.WebExtensions Module (F#)

A module of extension members providing asynchronous operations for some basic Web operations.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AutoOpen>]
module WebExtensions

```



## Remarks

## Extension Members


|Extension Member|Description|
|----------------|-----------|
|[AsyncDownloadString](http://msdn.microsoft.com/en-us/library/8a85a9b7-f712-4cac-a0ce-0a797f8ea32a)<br />**: Uri -&gt; Async&lt;string&gt;**|Returns an asynchronous computation that, when run, will wait for the download of the given URI.|
|[AsyncGetResponse](http://msdn.microsoft.com/en-us/library/09a60c31-e6e2-4b5c-ad23-92a86e50060c)<br />**: unit -&gt; Async&lt;WebResponse&gt;**|Returns an asynchronous computation that, when run, will wait for a response to the given web request.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%28FSharp%29.md)

