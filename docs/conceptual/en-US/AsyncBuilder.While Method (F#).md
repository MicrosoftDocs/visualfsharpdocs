# AsyncBuilder.While Method (F#)

Implements the **while** keyword in asynchronous computation expressions.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.While : (unit -> bool) * Async<unit> -> Async<unit>

// Usage:
asyncBuilder.While (guard, computation)
```

#### CAPS_PARAMETERS_MD
*guard*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to determine when to stop executing **computation**.


*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**&gt;**


The function to be executed. Equivalent to the body of a **while** expression.



**An asynchronous computation that behaves similarly to a while loop when run.**
## CAPS_REMARKS_MD
Creates an asynchronous computation that runs *computation* repeatedly until *guard* evaluates to false.

A cancellation check is performed whenever the computation is executed. The existence of this method permits the use of **while** in the **async { ... }** computation expression syntax.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.AsyncBuilder Class &#40;F&#35;&#41;](Control.AsyncBuilder+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

