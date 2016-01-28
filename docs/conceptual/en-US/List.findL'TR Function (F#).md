# List.find<'T> Function (F#)

Returns the first element for which the given function returns **true**. Raises **T:System.Collections.Generic.KeyNotFoundException** if no such element exists.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.find : ('T -> bool) -> 'T list -> 'T

// Usage:
List.find predicate list
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The first element that satisfies the predicate.**
## CAPS_REMARKS_MD
This function is named **Find** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.find.**
```

let isDivisibleBy number elem = elem % number = 0
let result = List.find (isDivisibleBy 5) [ 1 .. 100 ]
printfn "%d " result
```

**Output**
**5**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

