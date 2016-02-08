# Set.( + )<'T> Method (F#)

Compute the union of the two sets.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member ( + ) : Set<'T> * Set<'T> -> Set<'T> (requires comparison)

// Usage:
set1 + set2

```



#### Parameters
*set1*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The first input set.


*set2*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The second input set.



**The union of the two input sets.**
## Remarks
**The following code illustrates the use of the + and - operators on sets.**
[!code-fsharp[Main](snippets/fssets/snippet1.fs)]
**Output**
**set1: set [1; 2; 3]set2: set [4; 5; 6]set3 = set1 + set2: set [1; 2; 3; 4; 5; 6]set3 - set1: set [4; 5; 6]set3 - set2: set [1; 2; 3]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set&#60;'T&#62; Class &#40;F&#35;&#41;](Collections.Set%28%27T%29+Class+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

