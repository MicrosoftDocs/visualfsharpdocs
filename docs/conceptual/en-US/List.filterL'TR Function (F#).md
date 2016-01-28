# List.filter<'T> Function (F#)

Returns a new collection containing only the elements of the collection for which the given predicate returns **true**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.List

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.filter : ('T -> bool) -> 'T list -> 'T list

// Usage:
List.filter predicate list
```

#### CAPS_PARAMETERS_MD
*predicate*
Type: **'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**A list containing only the elements that satisfy the predicate.**
## CAPS_REMARKS_MD
This function is named **Filter** in compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of List.filter.**
```

let evenOnlyList = List.filter (fun x -> x % 2 = 0) [1; 2; 3; 4; 5; 6]
```

**The resulting list is [2; 4; 6].****The following example shows another typical use for List.filter.**
```

    let data = [("Cats",4);
                ("Dogs",5);
                ("Mice",3);
                ("Elephants",2)]
    let res = data |> List.filter (fun (nm,x) -> nm.Length <= 4)
    printfn "Animals with short names: %A" res
```

**Animals with short names: [("Cats", 4); ("Dogs", 5); ("Mice", 3)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

