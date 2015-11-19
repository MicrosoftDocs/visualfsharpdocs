# FSharpFunc.op_Implicit<'T,'U> Method (F#)

Convert an value of type **T:System.Converter&#96;2** to a F# first class function value or vice versa.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signatures:
static member op_Implicit : Converter<'T,'U> -> 'T -> 'U
static member op_Implicit : ('T -> 'U) -> Converter<'T,'U>

// Usage:
FSharpFunc.op_Implicit (converter)
FSharpFunc.op_Implicit (func)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*converter*
Type: **T:System.Converter&#96;2****&lt;'T,                                                                                       'U&gt;**


The input **T:System.Converter&#96;2** instance.


*func*
Type: **'T -&gt; 'U**


An input function to be converted to a **T:System.Converter&#96;2** instance..



**The result of the conversion.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0




## See Also
[Core.FSharpFunc&#60;'T,'U&#62; Class &#40;F&#35;&#41;](Core.FSharpFunc%3C%27T%2C%27U%3E+Class+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

