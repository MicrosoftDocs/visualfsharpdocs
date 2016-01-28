# List.sum<^T> Function (F#)

Returns the sum of the elements in the list.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.sum : ^T list -> ^T (requires ^T with static member (+) and ^T with static member Zero)

// Usage:
List.sum list
```

#### CAPS_PARAMETERS_MD
*list*
Type: **^T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The resulting sum.**
## CAPS_REMARKS_MD
This function is named **Sum** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.sum, [List.sumBy](http://msdn.microsoft.com/en-us/library/b7623389-0fe1-4762-9c67-51079903ab7d), and [List.average](http://msdn.microsoft.com/en-us/library/2b9a627b-106d-4548-8c4c-ab5058b8f8e1).**
```

    // Compute the sum of the first 10 integers by using List.sum.
    let sum1 = List.sum [1 .. 10]

    // Compute the sum of the squares of the elements of a list by using List.sumBy.
    let sum2 = List.sumBy (fun elem -> elem*elem) [1 .. 10]


    // Compute the average of the elements of a list by using List.average.
    let avg1 = List.average [0.0; 1.0; 1.0; 2.0]

    printfn "%f" avg1

```

**Output**
**1.000000**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

