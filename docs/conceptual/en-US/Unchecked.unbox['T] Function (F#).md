# Unchecked.unbox<'T> Function (F#)

Unboxes a strongly typed value. This is the inverse of **box**; therefore, **unbox&lt;t&gt;(box&lt;t&gt; a)** equals **a**.

**Namespace/Module Path**: Microsoft.FSharp.Core.Operators.Unchecked

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
unbox : obj -> 'T

// Usage:
unbox
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*value*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The value to unbox.




## Return Value
The unboxed result.


## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Unbox** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Operators.Unchecked Module &#40;F&#35;&#41;](Operators.Unchecked+Module+28%F%2329%.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+28%F%2329%.md)

[Operators.box&#60;'T&#62; Function &#40;F&#35;&#41;](Operators.box%3C%27T%3E+Function+28%F%2329%.md)

