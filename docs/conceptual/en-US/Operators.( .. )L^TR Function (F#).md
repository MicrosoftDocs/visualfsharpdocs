# Operators.( .. )<^T> Function (F#)

The standard overloaded range operator, for example, **[n..m]** for lists, **seq {n..m}** for sequences.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( .. ) : ^T -> ^T -> seq<^T> (requires ^T with static member (+) and ^T with static member One)

// Usage:
start .. finish


```



#### CAPS_PARAMETERS_MD
*start*
Type: **^T**


The start value of the range.


*finish*
Type: **^T**


The end value of the range.



**The sequence spanning the range.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

