# Map.add<'Key,'T> Function (F#)

Returns a new map with the binding added to the given map.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Map.add : 'Key -> 'T -> Map<'Key,'T> -> Map<'Key,'T> (requires comparison)

// Usage:
Map.add key value table
```

#### CAPS_PARAMETERS_MD
*key*
Type: **'Key**


The input key.


*value*
Type: **'T**


The input value.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The resulting map.**
## CAPS_REMARKS_MD
This function is named **Add** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows how to use Map.add.**
```

    Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    |> Map.add(0) "zero"
    |> Map.iter (fun key value -> printfn "key: %d value: %s" key value)
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
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

