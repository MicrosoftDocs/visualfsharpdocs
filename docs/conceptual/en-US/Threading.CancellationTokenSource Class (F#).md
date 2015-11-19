# Threading.CancellationTokenSource Class (F#)

Signals to a **CancellationToken** that it should be cancelled.

**Namespace/Module Path**: System.Threading

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<Sealed>]
[<AllowNullLiteral>]
type CancellationTokenSource =
class
interface IDisposable
new CancellationTokenSource : unit -> CancellationTokenSource
member this.Cancel : unit -> unit
static member CreateLinkedTokenSource : CancellationToken * CancellationToken -> CancellationTokenSource
member this.Dispose : unit -> unit
member this.Token :  CancellationToken
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, **T:System.Threading.CancellationTokenSource**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/42dfcfe7-101c-43f6-b92a-83332a4b993e)|Creates a new cancellation capability.|

## Instance Members


|Member|Description|
|------|-----------|
|[Cancel](http://msdn.microsoft.com/en-us/library/c66b158e-7af8-4b4b-8b46-126d4d9c15e8)|Cancels the operation.|
|[Dispose](http://msdn.microsoft.com/en-us/library/dd4d00a8-da36-4fc4-8525-a1f89653cc1c)|Discards resources associated with this capability.|
|[Token](http://msdn.microsoft.com/en-us/library/02eac69e-62eb-4b1b-a247-27adaa30c88a)|Fetches the token representing the capability to detect cancellation of an operation.|

## Static Members


|Member|Description|
|------|-----------|
|[CreateLinkedTokenSource](http://msdn.microsoft.com/en-us/library/a75ae3f2-9924-4079-aaab-7f8bea64a2e8)|Creates a cancellation capability linking two tokens.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[System.Threading Namespace &#40;F&#35;&#41;](System.Threading+Namespace+28%F%2329%.md)

