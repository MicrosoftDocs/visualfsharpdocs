# Stream.AsyncWrite Extension Method (F#)

Returns an asynchronous computation that will write the given bytes to the stream.

**Namespace/Module Path:** Microsoft.FSharp.Control.CommonExtensions

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
type System.IO.Stream with
member AsyncWrite : byte [] * ?int * ?int -> Async<unit>

// Usage:
stream.AsyncWrite (buffer)


```





#### Parameters
*buffer*
Type: [byte](http://msdn.microsoft.com/en-us/library/17a98430-283a-4ff6-a475-e6999577179d)[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The buffer to write from.


*offset*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional offset as the number of bytes in the stream.


*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


An optional number of bytes to write to the stream.



**exceptions tag is not supported!!!!**

## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[Control.CommonExtensions Module &#40;F&#35;&#41;](Control.CommonExtensions-Module-%5BFSharp%5D.md)

