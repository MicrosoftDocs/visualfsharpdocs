# Map.TryFind<'Key,'Value> Method (F#)

Lookup an element in the map, returning a **Some** value if the element is in the domain of the map and **None** if not.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
member this.TryFind : 'Key -> 'Value option (requires comparison)

// Usage:
map.TryFind (key)
```

#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.



**The mapped value, or None if the key is not in the map.**
## CAPS_REMARKS_MD
**The following code shows how to use the TryFind method.**
```

    let map1 = [ for i in 1 .. 100 -> (i, i*i) ] |> Map.ofList
    let result = map1.TryFind 50
    match result with
    | Some x -> printfn "Found %d." x
    | None -> printfn "Did not find the specified value."
```

**Output**
**Found 2500.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map&#60;'Key,'Value&#62; Class &#40;F&#35;&#41;](Collections.MapL%27Key%2C%27ValueR+Class+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

