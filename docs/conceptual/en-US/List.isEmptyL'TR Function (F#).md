# List.isEmpty<'T> Function (F#)

Tests whether a list is empty.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.isEmpty : 'T list -> bool

// Usage:
List.isEmpty list
```

#### CAPS_PARAMETERS_MD
*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**true if the list is empty. Otherwise, returns false.**
## CAPS_REMARKS_MD
This function is named **IsEmpty** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows how to use List.isEmpty.**
```

    let printList list1 = 
        if (List.isEmpty list1) then
            printfn "There are no elements in this list."
        else
            printfn "This list contains the following elements:"
            List.iter (fun elem -> printf "%A " elem) list1
            printfn ""
    printList [ "test1"; "test2" ]
    printList [ ]
```

**Output**
**This list contains the following elements:**
**"test1" "test2"**
**There are no elements in this list.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

