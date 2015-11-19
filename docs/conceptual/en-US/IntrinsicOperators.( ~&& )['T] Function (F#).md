# IntrinsicOperators.( ~&& )<'T> Function (F#)

Takes the address of the argument as a native pointer. Uses of this value may result in the generation of unverifiable code.

**Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
( ~&& ) : 'T -> nativeptr<'T> (requires unmanaged)

// Usage:
&& obj
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*obj*
Type: **'T**


The input object.



**The unmanaged pointer.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[LanguagePrimitives.IntrinsicOperators Module &#40;F&#35;&#41;](LanguagePrimitives.IntrinsicOperators+Module+28%F%2329%.md)

[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives+Module+28%F%2329%.md)

