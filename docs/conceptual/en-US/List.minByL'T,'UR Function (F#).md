# List.minBy<'T,'U> Function (F#)

Returns the lowest of all elements of the list, compared by using [Operators.min](http://msdn.microsoft.com/en-us/library/adea4fd7-bfad-4834-989c-7878aca81fed) on the function result.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.minBy : ('T -> 'U) -> 'T list -> 'T (requires comparison)

// Usage:
List.minBy projection list


```



#### CAPS_PARAMETERS_MD
*projection*
Type: **'T -&gt; 'U**


The function to transform list elements into the type to be compared.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The minimum value.**
## CAPS_REMARKS_MD
This function is named **MinBy** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use List.minBy.**


```



    [ -10.0 .. 10.0 ]
    |> List.minBy (fun x -> x * x - 1.0)
    |> printfn "%A"


```



**Output**
**0.0**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

