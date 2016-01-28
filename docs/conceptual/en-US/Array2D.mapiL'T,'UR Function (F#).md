# Array2D.mapi<'T,'U> Function (F#)

Builds a new array whose elements are the results of applying the given function to each of the elements of the array. The integer indices passed to the function indicates the element being transformed.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array2D

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array2D.mapi : (int -> int -> 'T -> 'U) -> 'T [,] -> 'U [,]

// Usage:
Array2D.mapi mapping array
```

#### CAPS_PARAMETERS_MD
*mapping*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T -&gt; 'U**


A function that is applied to transform each element of the array. The two integers provide the index of the element.


*array*
Type: **'T**[[,]](http://msdn.microsoft.com/en-us/library/077252f3-e6ce-441c-9d5b-a6030eaef7cd)


The input array.



**An array whose elements have been transformed by the given mapping.**
## CAPS_REMARKS_MD
For non-zero-based arrays the basing on an input array will be propagated to the output array.

This function is named **MapIndexed** in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array2D Module &#40;F&#35;&#41;](Collections.Array2D+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

