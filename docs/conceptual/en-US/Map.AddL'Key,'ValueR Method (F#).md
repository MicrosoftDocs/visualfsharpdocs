# Map.Add<'Key,'Value> Method (F#)

Returns a new map with the binding added to the given map.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.Add : 'Key * 'Value -> Map<'Key, 'Value> (requires comparison)

// Usage:
map.Add (key, value)
```

#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.


*value*
Type: **'Value**


The input value.



**The resulting map.**
## CAPS_REMARKS_MD
**The following code example shows how to use the Add method.**
```

    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let map2 = map1.Add(0, "zero")
    map2 |> Map.iter (fun key value -> printfn "key: %d value: %s" key value)
```

**Output**
**key: 0 value: zero**
**key: 1 value: one**
**key: 2 value: two**
**key: 3 value: three**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map&#60;'Key,'Value&#62; Class &#40;F&#35;&#41;](Collections.Map+%27Key%2C%27Value+Class+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

