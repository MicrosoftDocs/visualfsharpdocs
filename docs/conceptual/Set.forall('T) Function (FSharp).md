# Set.forall<'T> Function (F#)

Tests if all elements of the collection satisfy the given predicate. If the input function is **f** and the elements are **i0...iN** then computes **p i0 &amp;&amp; ... &amp;&amp; p iN**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Set

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Set.forall : ('T -> bool) -> Set<'T> -> bool (requires comparison)

// Usage:
Set.forall predicate set

```



#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test set elements.


*set*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The input set.



**true if all elements of set satisfy predicate. Otherwise, returns false.**
## Remarks
This function is named **ForAll** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

