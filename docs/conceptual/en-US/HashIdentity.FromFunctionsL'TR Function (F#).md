# HashIdentity.FromFunctions<'T> Function (F#)

Hash using the given hashing and equality functions.

**Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
FromFunctions : ('T -> int) -> ('T -> 'T -> bool) -> IEqualityComparer<'T>

// Usage:
FromFunctions hasher equality


```



#### CAPS_PARAMETERS_MD
*hasher*
Type: **'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


A function to generate a hash code from a value.


*equality*
Type: **'T -&gt; 'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


A function to test equality of two values.



**An object that implements T:System.Collections.IEqualityComparer using the supplied functions.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.HashIdentity Module &#40;F&#35;&#41;](Collections.HashIdentity+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

