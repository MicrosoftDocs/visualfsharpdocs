# Map.find<'Key,'T> Function (F#)

Looks up an element in the map. If no binding exists in the map, raises **T:System.Collections.Generic.KeyNotFoundException**.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
Map.find : 'Key -> Map<'Key,'T> -> 'T (requires comparison)

// Usage:
Map.find key table
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*key*
Type: **'Key**


The input key.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**exceptions tag is not supported!!!!**
**The value mapped to the given key.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Find** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following examples shows how to use Map.filter.**
**[!CODE [FsMaps#6](../CodeSnippet/VS_Snippets_Fsharp/fsmaps/FSharp/fs/program.fs#6)]**
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
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+28%F%2329%.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

