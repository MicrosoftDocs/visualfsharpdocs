# Map.ContainsKey<'Key,'Value> Method (F#)

Tests if an element is in the domain of the map.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.ContainsKey : 'Key -> bool (requires comparison)

// Usage:
map.ContainsKey (key)
```

#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.



**true if the map contains the given key.**
## CAPS_REMARKS_MD
**The following code shows how to use the ContainsKey method.**
```

    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let findKeyAndPrint key (map : Map<int,string>) =
        if (map.ContainsKey key) then
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
[Collections.Map&#60;'Key,'Value&#62; Class &#40;F&#35;&#41;](Collections.Map+%27Key%2C%27Value+Class+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

