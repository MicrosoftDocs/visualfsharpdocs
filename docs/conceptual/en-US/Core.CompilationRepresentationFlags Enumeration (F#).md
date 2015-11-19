# Core.CompilationRepresentationFlags Enumeration (F#)

Indicates one or more adjustments to the compiled representation of an F# type or member.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<Flags>]
type CompilationRepresentationFlags =
| None = 0
| Static = 1
| Instance = 2
| ModuleSuffix = 4
| UseNullAsTrueValue = 8
| Event
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The following table shows the possible values and their meaning.



|Value|Description|
|-----|-----------|
|None|No special compilation representation.|
|Static|Compile an instance member as static.|
|Instance|Compile a member as instance even if null is used as a representation for this type.|
|ModuleSuffix|Append **Module** to the end of a module whose name clashes with a type name in the same namespace.|
|UseNullAsTrueValue|Permit the use of null as a representation for nullary discriminators in a discriminated union.|
|Event|Compile a property as a Common Language Infrastructure (CLI) event.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

