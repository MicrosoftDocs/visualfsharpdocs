# Parallel.iteri<'T> Function (F#)

Apply the given function to each element of the array. The integer passed to the function indicates the index of element.

**Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
iteri : (int -> 'T -> unit) -> 'T [] -> unit

// Usage:
iteri action array
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*action*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.




## Remarks
Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.

This function is named **IterateIndexed** in compiled assemblies. If you are accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0


## See Also
[Array.Parallel Module &#40;F&#35;&#41;](Array.Parallel+Module+%28FSharp%29.md)

[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

