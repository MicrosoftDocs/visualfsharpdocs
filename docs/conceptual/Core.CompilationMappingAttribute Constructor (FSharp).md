# Core.CompilationMappingAttribute Constructor (F#)

Creates an instance of the attribute.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signatures:
new CompilationMappingAttribute : SourceConstructFlags * int * int -> CompilationMappingAttribute
new CompilationMappingAttribute : SourceConstructFlags * int -> CompilationMappingAttribute
new CompilationMappingAttribute : SourceConstructFlags -> CompilationMappingAttribute

// Usage:
new CompilationMappingAttribute (sourceConstructFlags, variantNumber, sequenceNumber)
new CompilationMappingAttribute (sourceConstructFlags, sequenceNumber)
new CompilationMappingAttribute (sourceConstructFlags)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*sourceConstructFlags*
Type: [SourceConstructFlags](http://msdn.microsoft.com/en-us/library/6da6a0c5-25d0-407d-8536-70182654d738)


Indicates the type of source construct.


*variantNumber*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


*sequenceNumber*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)



**A new CompilationMappingAttribute instance.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable, Portable




## See Also
[Core.CompilationMappingAttribute Class &#40;F&#35;&#41;](Core.CompilationMappingAttribute+Class+%28FSharp%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

