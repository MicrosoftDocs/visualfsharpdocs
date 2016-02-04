# Map.tryFindKey<'Key,'T> Function (F#)

Returns the key of the first mapping in the collection that satisfies the given predicate, or returns **None** if no such element exists.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Map

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Map.tryFindKey : ('Key -> 'T -> bool) -> Map<'Key,'T> -> 'Key option (requires comparison)

// Usage:
Map.tryFindKey predicate table


```



#### CAPS_PARAMETERS_MD
*predicate*
Type: **'Key -&gt; 'T -&gt;**[bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


The function to test the input elements.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The first key for which the predicate returns true or None if the predicate evaluates to false for each key/value pair.**
## CAPS_REMARKS_MD
This function is named **TryFindKey** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows the use of the Map.tryFindKey function.**


```



    let map1 = [ for i in 1 .. 100 -> (i, i*i) ] |> Map.ofList
    let result = Map.tryFindKey (fun key value -> key = value) map1
    match result with
    | Some key -> printfn "Found element with key %d." key
    | None -> printfn "Did not find any element that matches the condition."


```



**Output**
**Found element with key 1.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

