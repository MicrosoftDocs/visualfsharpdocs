# ExtraTopLevelOperators.failwithf<'T,'Result> Function (F#)

Print to a string buffer and raise an exception with the given result. Helper printers must return strings.

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
failwithf : StringFormat<'T,'Result> -> 'T

// Usage:
failwithf format
```

#### CAPS_PARAMETERS_MD
*format*
Type: [StringFormat](http://msdn.microsoft.com/en-us/library/d69a911f-3a25-42fa-bd51-a9c9c1102fa8)**&lt;'T,'Result&gt;**




## CAPS_REMARKS_MD
This function is named **PrintFormatToStringThenFail** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of failwithf.**
```

    let reportError componentName code =
        failwithf "Component %s reported a failure. Error code: 0x%x" componentName code
    reportError "Filesystem monitor" 0x80000005
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

