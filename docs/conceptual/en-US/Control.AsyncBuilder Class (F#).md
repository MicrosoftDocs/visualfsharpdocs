# Control.AsyncBuilder Class (F#)

The type of the **async** operator, used to build workflows for asynchronous computations.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<Sealed>]
type AsyncBuilder =
class
new AsyncBuilder : unit -> AsyncBuilder
member this.Bind : Async<'T> * ('T -> Async<'U>) -> Async<'U>
member this.Combine : Async<unit> * Async<'T> -> Async<'T>
member this.Delay : (unit -> Async<'T>) -> Async<'T>
member this.For : seq<'T> * ('T -> Async<unit>) -> Async<unit>
member this.Return : 'T -> Async<'T>
member this.ReturnFrom : Async<'T> -> Async<'T>
member this.TryFinally : Async<'T> * (unit -> unit) -> Async<'T>
member this.TryWith : Async<'T> * (exn -> Async<'T>) -> Async<'T>
member this.Using : 'T * ('T -> Async<'U>) -> Async<'U>
member this.While : (unit -> bool) * Async<unit> -> Async<unit>
member this.Zero : unit -> Async<unit>
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
For general information on computation expressions and builder types, see [Computation Expressions &#40;F&#35;&#41;](Computation+Expressions+28%F%2329%.md).

This type is named **FSharpAsyncBuilder** in compiled assemblies. If accessing the type from a language other than F#, or through reflection, use this name.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/8e4ea5d1-f1db-4f69-bfb9-6e6b5c5deb83)|Generates an object used to build asynchronous computations using F# computation expressions. The value **async** is a pre-defined instance of this type. A cancellation check is performed when the computation is executed.|

## Instance Members


|Member|Description|
|------|-----------|
|[Bind](http://msdn.microsoft.com/en-us/library/74deaad1-5d78-4ce7-905b-399231df02bc)|Implements **let!** in asynchronous computations.|
|[Combine](http://msdn.microsoft.com/en-us/library/26ffe7f2-31e3-475f-9042-94347187b721)|Creates an asynchronous computation that first runs **computation1** and then runs **computation2**, returning the result of **computation2**.|
|[Delay](http://msdn.microsoft.com/en-us/library/71097cf1-ce79-46f3-9756-bd153d3d44ea)|Creates an asynchronous computation that runs a function.|
|[For](http://msdn.microsoft.com/en-us/library/e49389df-b5d0-46ab-ba9c-58aa51a2bfdd)|Implements the **for** expression in asynchronous computations.|
|[Return](http://msdn.microsoft.com/en-us/library/0f90f7c3-0774-4557-8d2d-59fe70bd09ea)|Implements the **return** expression in asynchronous computations. Creates an asynchronous computation that returns the specified result.|
|[ReturnFrom](http://msdn.microsoft.com/en-us/library/f76f8b91-f194-42aa-90e9-ca26650baef2)|Implements the **return!** keyword for asynchronous computations. This function delegates to the input computation.|
|[TryFinally](http://msdn.microsoft.com/en-us/library/e82a1256-35e8-4d57-9dda-6e4e5a6f4445)|Implements **try...finally** in asynchronous computations.|
|[TryWith](http://msdn.microsoft.com/en-us/library/47fa979f-0790-40ca-bf32-96628c83f763)|Implements **try...with** in asynchronous computations.|
|[Using](http://msdn.microsoft.com/en-us/library/73b0269e-30b3-4ee6-9f38-a233809d2636)|Implements the **use** and **use!** keywords in asynchronous computation expressions.|
|[While](http://msdn.microsoft.com/en-us/library/d47c0775-5a40-4e74-a9ae-f96c5385efe7)|Implements the **while** keyword in asynchronous computation expressions.|
|[Zero](http://msdn.microsoft.com/en-us/library/8379ba80-9693-4f51-ae93-1d7c4e3e878b)|Creates an asynchronous computation that does nothing and returns **()**.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

