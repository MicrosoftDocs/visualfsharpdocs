# Seq.where<'T> Function (F#)

Returns a new collection containing only the elements of the collection for which the given predicate returns **true**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:where : ('T -> bool) -> seq<'T> -> seq<'T>// Usage:Seq.where predicate source

```



#### Parameters
*predicate*
Type: 'T -&gt; [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function to test whether each item in the input sequence should be included in the output.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)&lt;'T&gt;


The input sequence.



**exceptions tag is not supported!!!!**

## Return Value
The result sequence.


## Remarks
The returned sequence may be passed between threads safely. However, individual **T:System.Collections.Generic.IEnumerator&#96;1** values generated from the returned sequence should not be accessed concurrently. Remember that sequence is subject to lazy evaluation, which means that effects are delayed until it is enumerated. This function is a synonym for [Seq.filter](http://msdn.microsoft.com/en-us/library/7f2e9850-a660-460c-9831-3bbff5613770).

This function is named **Where** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable



.0


## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

[Seq.filter&lt;'T&gt; Function (F#)](http://msdn.microsoft.com/en-us/library/7f2e9850-a660-460c-9831-3bbff5613770)

