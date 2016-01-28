# Unchecked.unbox<'T> Function (F#)

Unboxes a strongly typed value. This is the inverse of **box**; therefore, **unbox&lt;t&gt;(box&lt;t&gt; a)** equals **a**.

**Namespace/Module Path**: Microsoft.FSharp.Core.Operators.Unchecked

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
unbox : obj -> 'T

// Usage:
unbox
```

#### CAPS_PARAMETERS_MD
*value*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The value to unbox.




## Return Value
The unboxed result.


## CAPS_REMARKS_MD
This function is named **Unbox** in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Operators.Unchecked Module &#40;F&#35;&#41;](Operators.Unchecked+Module+%28F%23%29.md)

[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Operators.box&#60;'T&#62; Function &#40;F&#35;&#41;](Operators.boxL%27TR+Function+%28F%23%29.md)

