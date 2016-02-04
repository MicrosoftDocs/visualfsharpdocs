# List.rev<'T> Function (F#)

Returns a new list with the elements in reverse order.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.rev : 'T list -> 'T list

// Usage:
List.rev list


```



#### CAPS_PARAMETERS_MD
*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The reversed list.**
## CAPS_REMARKS_MD
This function is named **Reverse** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code demonstrates how to use List.rev.**


```



    let reverseList = List.rev [ 1 .. 10 ]
    printfn "%A" reverseList


```



**Output**
**[10; 9; 8; 7; 6; 5; 4; 3; 2; 1]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

