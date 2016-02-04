# Map.foldBack<'Key,'T,'State> Function (F#)

Folds over the bindings in the map.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Map

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Map.foldBack : ('Key -> 'T -> 'State -> 'State) -> Map<'Key,'T> -> 'State -> 'State (requires comparison)

// Usage:
Map.foldBack folder table state


```



#### CAPS_PARAMETERS_MD
*folder*
Type: **'Key -&gt; 'T -&gt; 'State -&gt; 'State**


The function to update the state given the input key/value pairs.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.


*state*
Type: **'State**


The initial state.



**The final state value.**
## CAPS_REMARKS_MD
This function is named **FoldBack** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Map.foldBack.**


```



    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    // Sum the keys.
    let result1 = Map.foldBack (fun key value state -> state + key) map1 0
    printfn "Result: %d" result1
    // Concatenate the values.
    let result2 = Map.foldBack (fun key value state -> state + value + " ") map1 ""
    printfn "Result: %s" result2 


```



**Output**
**Result: 6**
**Result: three two one**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

