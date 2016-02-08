# Collections.HashIdentity Module (F#)

Common notions of value identity used with hash tables.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


module HashIdentity

```



## Remarks

## Values


|Value|Description|
|-----|-----------|
|[FromFunctions](http://msdn.microsoft.com/en-us/library/b19afd76-a58f-4a6d-a10e-b302d59b8889)<br />**: ('T -&gt; int) -&gt; ('T -&gt; 'T -&gt; bool) -&gt; IEqualityComparer&lt;'T&gt;**|Hash using the given hashing and equality functions.|
|[LimitedStructural](http://msdn.microsoft.com/en-us/library/9d7b59ee-78b2-40a0-a988-ca4310031dc9)<br />**: int -&gt; IEqualityComparer&lt;'T&gt;**|Provides structural hashing up to a specified number of elements.|
|[Reference](http://msdn.microsoft.com/en-us/library/5a92cdd8-bf3f-4943-b132-59c0e0463d41)<br />**: IEqualityComparer&lt;'T&gt;**|Implements physical hashing, which means that it hashes on reference identity of objects, and the contents of value types..|
|[Structural](http://msdn.microsoft.com/en-us/library/afedeb12-67a3-423f-b941-92003d2710b8)<br />**: IEqualityComparer&lt;'T&gt;**|Implements structural hashing. Hashes using [Operators.(=)](http://msdn.microsoft.com/en-us/library/5b1167e1-cc30-4d26-9f1d-556b2a308187) and [Operators.hash](http://msdn.microsoft.com/en-us/library/a83c0432-919e-407d-9ffc-8cf34fbc6daa).|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

