# RuntimeHelpers.EnumerateFromFunctions<'T,'U> Function (F#)

The F# compiler emits calls to this function to implement the compiler-intrinsic conversions from weakly typed **T:System.Collections.IEnumerable** sequences to typed sequences.

**Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
RuntimeHelpers.EnumerateFromFunctions : (unit -> 'T) -> ('T -> bool) -> ('T -> 'U) -> seq<'U>

// Usage:
RuntimeHelpers.EnumerateFromFunctions create moveNext current
```

#### CAPS_PARAMETERS_MD
*create*
Type: [unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt; 'T**


An initializer function.


*moveNext*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function to iterate and test if end of sequence is reached.


*current*
Type: **'T -&gt; 'U**


A function to retrieve the current element.



**The resulting typed sequence.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[CompilerServices.RuntimeHelpers Module &#40;F&#35;&#41;](CompilerServices.RuntimeHelpers+Module+%28F%23%29.md)

[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices+Namespace+%28F%23%29.md)

