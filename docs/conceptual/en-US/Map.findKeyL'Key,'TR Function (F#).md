# Map.findKey<'Key,'T> Function (F#)

Evaluates the function on each mapping in the collection and returns the key for the first mapping where the function returns **true**. If no such element exists, this function raises **T:System.Collections.Generic.KeyNotFoundException**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Map

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Map.findKey : ('Key -> 'T -> bool) -> Map<'Key,'T> -> 'Key (requires comparison)

// Usage:
Map.findKey predicate table


```



#### CAPS_PARAMETERS_MD
*predicate*
Type: **'Key -&gt; 'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**exceptions tag is not supported!!!!**
**The first key for which the predicate evaluates true.**
## CAPS_REMARKS_MD
This function is named **FindKey** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example shows how to use Map.findKey.**


```



    let findKeyFromValue findValue map =
        printfn "With value %A, found key %A." findValue (Map.findKey (fun key value -> value = findValue) map)
    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let map2 = Map.ofList [ for i in 1 .. 10 -> (i, i*i) ]
    try
        findKeyFromValue "one" map1
        findKeyFromValue "two" map1
        findKeyFromValue 9 map2
        findKeyFromValue 25 map2
        // The key is not in the map, so the following line throws an exception.
        findKeyFromValue 0 map2
    with
         :? System.Collections.Generic.KeyNotFoundException as e -> printfn "%s" e.Message


```



**Output**
**With value "one", found key 1.**
**With value "two", found key 2.**
**With value 9, found key 3.**
**With value 25, found key 5.**
**Exception of type 'System.Collections.Generic.KeyNotFoundException' was thrown.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

