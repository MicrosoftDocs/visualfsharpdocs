# Array.sortWith<'T> Function (F#)

Sorts the elements of an array, using the given comparison function as the order, returning a new array.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Array.sortWith : ('T -> 'T -> int) -> 'T [] -> 'T []

// Usage:
Array.sortWith comparer array


```



#### CAPS_PARAMETERS_MD
*comparer*
Type: **'T -&gt; 'T -&gt;**[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The function to compare pairs of array elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The sorted array.**
## CAPS_REMARKS_MD
This is not a stable sort, that is, the original order of equal elements might not be preserved. For a stable sort, consider using [Seq.sort](http://msdn.microsoft.com/en-us/library/327ea595-e77c-4529-b61e-8c6cbf5ec92e).

This function is named **SortWith** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows the use of Array.sortWith.**


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

    Array.sortWith sortFunction array1
    |> printfn "After sorting: \n%A"


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

