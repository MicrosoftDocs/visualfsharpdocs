# Parallel.partition<'T> Function (F#)

Splits the collection into two collections, containing the elements for which the given predicate returns **true** and **false**, respectively

**Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
partition : ('T -> bool) -> 'T [] -> 'T [] * 'T []

// Usage:
partition predicate array

```



#### Parameters
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The two collections.**
## Remarks
Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to indices is not specified.

This function is named **Partition** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0


## See Also
[Array.Parallel Module &#40;F&#35;&#41;](Array.Parallel+Module+%28FSharp%29.md)

[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

