# List.init<'T> Function (F#)

Creates a list by calling the given generator on each index.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.init : int -> (int -> 'T) -> 'T list

// Usage:
List.init length initializer

```



#### Parameters
*length*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the list to generate.


*initializer*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T**


The function to generate an element from an index.



**The list of generated elements.**
## Remarks
This function is named **Initialize** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use List.init.**
[!code-fsharp[Main](snippets/fslists/snippet46.fs)]
**Output**
**List of squares: [0; 1; 4; 9; 16; 25; 36; 49; 64; 81]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

