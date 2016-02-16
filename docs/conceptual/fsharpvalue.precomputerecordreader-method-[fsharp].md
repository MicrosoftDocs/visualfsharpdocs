# FSharpValue.PreComputeRecordReader Method (F#)

Precompute a function for reading all the fields from a record.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member PreComputeRecordReader : Type * ?BindingFlags -> obj -> obj []
static member PreComputeRecordReader : Type * ?bool -> obj -> obj []

// Usage:
FSharpValue.PreComputeRecordReader (recordType)
FSharpValue.PreComputeRecordReader (recordType, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.PreComputeRecordReader (recordType, allowAccessToPrivateRepresentation = false)

```



#### Parameters
*recordType*
Type: **T:System.Type**


The type of record to read.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**An optimized reader for the given record type.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)

