# Operators.( .. .. )<^T,^Step> Function (F#)

The standard overloaded skip range operator, for example, **[n..skip..m]** for lists, **seq {n..skip..m}** for sequences.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( .. .. ) : ^T -> ^Step -> ^T -> seq<^T> (requires ^T with static member (+) and ^Step with static member (+) and ^Step with static member Zero)

// Usage:
start .. step .. finish
```

#### CAPS_PARAMETERS_MD
*start*
Type: **^T**


The start value of the range.


*step*
Type: **^Step**


The step value of the range.


*finish*
Type: **^T**


The end value of the range.



**The sequence spanning the range using the specified step size.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

