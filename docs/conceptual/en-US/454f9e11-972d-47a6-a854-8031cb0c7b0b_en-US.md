# Array.sortInPlaceWith<'T> Function (F#)

Sorts the elements of an array by mutating the array in place, using the given comparison function as the order.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.sortInPlaceWith : ('T -> 'T -> int) -> 'T [] -> unit

// Usage:
Array.sortInPlaceWith comparer array
```

#### CAPS_PARAMETERS_MD
*comparer*
Type: **'T -&gt; 'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The function to compare pairs of array elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.




## CAPS_REMARKS_MD
This function is named **SortInPlaceWith** in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use Array.sortInPlaceWith.**
```

    open System

    let array1 = [| "<>"; "&"; "&&"; "&&&"; "<"; ">"; "|"; "||"; "|||" |]
    printfn "Before sorting: "
    array1 |> printfn "%A"
    let sortFunction (string1:string) (string2:string) =
        if (string1.Length > string2.Length) then
           1
        else if (string1.Length < string2.Length) then
           -1
        else
            String.Compare(string1, string2)
    Array.sortInPlaceWith sortFunction array1
    printfn "After sorting: "
    array1 |> printfn "%A"
```

**Output**
**Before sorting:**
**[|"&lt;&gt;"; "&amp;"; "&amp;&amp;"; "&amp;&amp;&amp;"; "&lt;"; "&gt;"; "|"; "||"; "|||"|]**
**After sorting:**
**[|"&amp;"; "|"; "&lt;"; "&gt;"; "&amp;&amp;"; "||"; "&lt;&gt;"; "&amp;&amp;&amp;"; "|||"|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

