# Map.find<'Key,'T> Function (F#)

Looks up an element in the map. If no binding exists in the map, raises **T:System.Collections.Generic.KeyNotFoundException**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Map.find : 'Key -> Map<'Key,'T> -> 'T (requires comparison)

// Usage:
Map.find key table


```



#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**exceptions tag is not supported!!!!**
**The value mapped to the given key.**
## CAPS_REMARKS_MD
This function is named **Find** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following examples shows how to use Map.filter.**


```



    let findAndPrint key map =
        printfn "With key %d, found value %A." key (Map.find key map)
    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let map2 = Map.ofList [ for i in 1 .. 10 -> (i, i*i) ]
    try
        findAndPrint 1 map1
        findAndPrint 2 map1
        findAndPrint 3 map2
        findAndPrint 5 map2
        // The key is not in the map, so this throws an exception.
        findAndPrint 0 map2
    with
         :? System.Collections.Generic.KeyNotFoundException as e -> printfn "%s" e.Message


```



**Output**
**With key 1, found value "one".**
**With key 2, found value "two".**
**With key 3, found value 9.**
**With key 5, found value 25.**
**The given key was not present in the dictionary.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

