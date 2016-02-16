# List.maxBy<'T,'U> Function (F#)

Returns the greatest of all elements of the list, compared by using [Operators.max](http://msdn.microsoft.com/en-us/library/9a988328-00e9-467b-8dfa-e7a6990f6cce) on the function result.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.maxBy : ('T -> 'U) -> 'T list -> 'T (requires comparison)

// Usage:
List.maxBy projection list

```



#### Parameters
*projection*
Type: **'T -&gt; 'U**


The function to transform the list elements into the type to be compared.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The maximum element.**
## Remarks
This function is named **MaxBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use List.maxBy.**
[!code-fsharp[Main](snippets/fslists/snippet56.fs)]
**Output**
**0.0**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

