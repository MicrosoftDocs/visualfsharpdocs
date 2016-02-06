# CancellationTokenSource.CreateLinkedTokenSource Method (F#)

Creates a cancellation capability linking two tokens.

**Namespace/Module Path**: System.Threading

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member CreateLinkedTokenSource : CancellationToken * CancellationToken -> CancellationTokenSource

// Usage:
CancellationTokenSource.CreateLinkedTokenSource (token1, token2)
```

#### Parameters
*token1*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The first input token.


*token2*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The second input token.



**The created CancellationTokenSource.**
## Remarks
This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, **M:System.Threading.CancellationTokenSource.CreateLinkedTokenSource(System.Threading.CancellationToken,System.Threading.CancellationToken)**.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Threading.CancellationTokenSource Class &#40;F&#35;&#41;](Threading.CancellationTokenSource+Class+%28FSharp%29.md)

[System.Threading Namespace &#40;F&#35;&#41;](System.Threading+Namespace+%28FSharp%29.md)

