# List.average<^T> Function (F#)

Returns the average of the elements in the list.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.average : ^T list -> ^T (requires ^T with static member (+) and ^T with static member DivideByInt and ^T with static member Zero)

// Usage:
List.average list


```



#### CAPS_PARAMETERS_MD
*list*
Type: **^T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The resulting average.**
## CAPS_REMARKS_MD
This function cannot be used directly on a list of integers since it requires that the type support an exact division operation, which is indicated by the constraint that the element type must support [DivideByInt](http://msdn.microsoft.com/en-us/library/24b70b03-c9fb-4edf-b04e-c9d8355fe1ca) Floating point types support **DivideByInt**. To compute the average of a list of integers, see the example in [List.averageBy](http://msdn.microsoft.com/en-us/library/936cc9ec-62af-464d-8726-7999c2f48403).

This function is named **Average** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.average.**


```



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

