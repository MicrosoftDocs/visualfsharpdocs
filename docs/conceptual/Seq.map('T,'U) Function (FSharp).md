# Seq.map<'T,'U> Function (F#)

Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The given function will be applied as elements are demanded using the **MoveNext** method on enumerators retrieved from the object.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Seq.map : ('T -> 'U) -> seq<'T> -> seq<'U>

// Usage:
Seq.map mapping source

```



#### Parameters
*mapping*
Type: **'T -&gt; 'U**


A function to transform items from the input sequence.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## Remarks
The returned sequence may be passed between threads safely. However, individual **IEnumerator** values generated from the returned sequence should not be accessed concurrently.

This function is named **Map** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

