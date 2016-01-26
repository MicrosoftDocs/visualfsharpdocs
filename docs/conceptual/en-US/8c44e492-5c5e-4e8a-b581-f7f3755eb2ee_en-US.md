# Operators.exit<'T> Function (F#)

Exit the current hardware isolated process, if security settings permit, otherwise raise an exception. Calls **M:System.Environment.Exit(System.Int32)**.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
exit : int -> 'T

// Usage:
exit exitcode
```

#### CAPS_PARAMETERS_MD
*exitcode*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The exit code to use.



**The result value.**
## CAPS_REMARKS_MD
This function is named **Exit** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0



Not supported


## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

