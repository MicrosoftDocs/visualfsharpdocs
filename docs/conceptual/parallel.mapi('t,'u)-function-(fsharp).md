# Parallel.mapi<'T,'U> Function (F#)

Build a new array whose elements are the results of applying the given function to each of the elements of the array. The integer index passed to the function indicates the index of element being transformed.

**Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
mapi : (int -> 'T -> 'U) -> 'T [] -> 'U []

// Usage:
mapi mapping array

```



#### Parameters
*mapping*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T -&gt; 'U**


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**'U[]**
## Remarks
Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.

This function is named **MapIndexed** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0


## See Also
[Array.Parallel Module &#40;F&#35;&#41;](Array.Parallel-Module-%28FSharp%29.md)

[Collections.Array Module &#40;F&#35;&#41;](Collections.Array-Module-%28FSharp%29.md)

