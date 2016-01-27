# Map.fold<'Key,'T,'State> Function (F#)

Folds over the bindings in the map

**Namespace/Module Path:** Microsoft.FSharp.Collections.Map

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Map.fold : ('State -> 'Key -> 'T -> 'State) -> 'State -> Map<'Key,'T> -> 'State (requires comparison)

// Usage:
Map.fold folder state table
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'Key -&gt; 'T -&gt; 'State**


The function to update the state given the input key/value pairs.


*state*
Type: **'State**


The initial state.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The final state value.**
## CAPS_REMARKS_MD
This function is named **Fold** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Map.fold.**
```

    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    // Sum the keys.
    let result1 = Map.fold (fun state key value -> state + key) 0 map1
    printfn "Result: %d" result1
    // Concatenate the values.
    let result2 = Map.fold (fun state key value -> state + value + " ") "" map1
    printfn "Result: %s" result2
```

**Output**
**Result: 6**
**Result: one two three**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

