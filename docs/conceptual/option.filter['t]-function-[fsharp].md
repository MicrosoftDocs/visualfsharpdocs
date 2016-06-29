# Option.filter<'T> Function (F#)

Invokes a function on an optional value that itself yields an option.

**Namespace/Module Path**: Microsoft.FSharp.Core.Option

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
filter : ('T -> bool) -> option:'T option -> 'T option

// Usage:
filter predicate option
```

#### Parameters
*predicate*
Type: **'T -&gt;**[bool](https://msdn.microsoft.com/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function that evaluates whether the value contained in the option should remain, or be filtered out.


*option*
Type: **'T**[option](https://msdn.microsoft.com/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The input option.
