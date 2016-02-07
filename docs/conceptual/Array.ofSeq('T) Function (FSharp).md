# Array.ofSeq<'T> Function (F#)

Builds a new array from the given enumerable object.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array.ofSeq : seq<'T> -> 'T []

// Usage:
Array.ofSeq source

```



#### Parameters
*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**The array of elements from the sequence.**
## Remarks
This function is named **OfSeq** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**Thhhe following code shows how to use Array.ofSeq.**
[!code-fsharp[Main](snippets/fsarrays/snippet60.fs)]
**FSI Output**
**val array1 : int [] = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

