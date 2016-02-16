# Set.isSubset<'T> Function (F#)

Evaluates to **true** if all elements of the first set are in the second.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Set

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Set.isSubset : Set<'T> -> Set<'T> -> bool (requires comparison)

// Usage:
Set.isSubset set1 set2

```



#### Parameters
*set1*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The potential subset.


*set2*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The set to test against.



**True if set1 is a subset of set2.**
## Remarks
This function is named **IsSubset** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of the Set.isSubset function.**
[!code-fsharp[Main](snippets/fssets/snippet11.fs)]
**Output**
**set [1; 2; 3; 4; 5] is a subset of set [1; 2; 3; 4; 5; 6]: true**
**set [1; 2; 3; 4; 5; 6] is a subset of set [1; 2; 3; 4; 5; 6]: true**
**set [5; 6; 7; 8; 9; 10] is a subset of set [1; 2; 3; 4; 5; 6]: false**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

