# Parallel.iter<'T> Function (F#)

Apply the given function to each element of the array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.ArrayModule.Parallel

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
iter : ('T -> unit) -> 'T [] -> unit

// Usage:
iter action array

```



#### Parameters
*action*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.




## Remarks
Performs the operation in parallel using System.Threading.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.

This function is named **Iterate** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0


## See Also
[Array.Parallel Module &#40;F&#35;&#41;](Array.Parallel+Module+%28FSharp%29.md)

[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

