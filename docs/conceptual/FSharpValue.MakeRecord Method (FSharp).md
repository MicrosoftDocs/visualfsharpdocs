# FSharpValue.MakeRecord Method (F#)

Creates an instance of a record type.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member MakeRecord : Type * obj [] * ?BindingFlags -> obj
static member MakeRecord : Type * obj [] * ?bool -> obj

// Usage:
FSharpValue.MakeRecord (recordType, values)
FSharpValue.MakeRecord (recordType, values, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.MakeRecord (recordType, values, allowAccessToPrivateRepresentation = false)
```

#### Parameters
*recordType*
Type: **T:System.Type**


The type of record to make.


*values*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The array of values to initialize the record.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**


Optional binding flags for the record.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**The created record.**
## Remarks
Assumes the given input is a record type.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28FSharp%29.md)

