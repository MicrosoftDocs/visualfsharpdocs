# Map.containsKey<'Key,'T> Function (F#)

Tests if an element is in the domain of the map.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Map.containsKey : 'Key -> Map<'Key,'T> -> bool (requires comparison)

// Usage:
Map.containsKey key table
```

#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**true if the map contains the key.**
## CAPS_REMARKS_MD
This function is named **ContainsKey** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Map.containsKey.**
```

    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let findKeyAndPrint key map =
        if (Map.containsKey key map) then
            printfn "The specified map contains the key %d." key
        else
            printfn "The specified map does not contain the key %d." key
    findKeyAndPrint 1 map1
    findKeyAndPrint 0 map1
```

**Output**
**The specified map contains the key 1.**
**The specified map does not contain the key 0.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

