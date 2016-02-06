# Set.map<'T,'U> Function (F#)

Returns a new collection containing the results of applying the given function to each element of the input set.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Set

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Set.map : ('T -> 'U) -> Set<'T> -> Set<'U> (requires comparison and comparison)

// Usage:
Set.map mapping set
```

#### Parameters
*mapping*
Type: **'T -&gt; 'U**


The function to transform elements of the input set.


*set*
Type: [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)**&lt;'T&gt;**


The input set.



**A set containing the transformed elements.**
## Remarks
This function is named [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664) in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Set Module &#40;F&#35;&#41;](Collections.Set+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

