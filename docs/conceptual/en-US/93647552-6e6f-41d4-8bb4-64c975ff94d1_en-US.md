# List.replicate<'T> Function (F#)

Creates a list of a specified length with every element set to the given value.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.replicate : int -> 'T -> 'T list

// Usage:
List.replicate count initial
```

#### CAPS_PARAMETERS_MD
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of elements to replicate.


*initial*
Type: **'T**


The value to replicate



**The generated list.**
## CAPS_REMARKS_MD
This function is named **Replicate** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use List.replicate.**
```

    let testList = List.replicate 4 "test"
    printfn "%A" testList
```

**Output**
**["test"; "test"; "test"; "test"]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

