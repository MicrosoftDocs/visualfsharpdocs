# Map.map<'Key,'T,'U> Function (F#)

Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The key passed to the function indicates the key of element being transformed.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Map

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Map.map : ('Key -> 'T -> 'U) -> Map<'Key,'T> -> Map<'Key,'U> (requires comparison)

// Usage:
Map.map mapping table
```

#### CAPS_PARAMETERS_MD
*mapping*
Type: **'Key -&gt; 'T -&gt; 'U**


The function to transform the key/value pairs.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The resulting map of keys and transformed values.**
## CAPS_REMARKS_MD
This function is named **Map** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Map.map.**
```

    let map1 = Map.ofList [ (1, "One"); (2, "Two"); (3, "Three") ]
    let map2 = map1 |> Map.map (fun key value -> value.ToUpper())
    let map3 = map1 |> Map.map (fun key value -> value.ToLower())
    printfn "%A" map1
    printfn "%A" map2
    printfn "%A" map3
```

**Output**
**map [(1, "One"); (2, "Two"); (3, "Three")]**
**map [(1, "ONE"); (2, "TWO"); (3, "THREE")]**
**map [(1, "one"); (2, "two"); (3, "three")]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

