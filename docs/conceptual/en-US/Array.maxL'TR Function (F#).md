# Array.max<'T> Function (F#)

Returns the greatest of all elements of the array, compared by using [Operators.max](http://msdn.microsoft.com/en-us/library/9a988328-00e9-467b-8dfa-e7a6990f6cce) on the function result.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.max : 'T [] -> 'T (requires comparison)

// Usage:
Array.max array
```

#### CAPS_PARAMETERS_MD
*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**exceptions tag is not supported!!!!**
**The maximum element.**
## CAPS_REMARKS_MD
This function is named **Max** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example demonstrates how to use Array.max.**
```

    [| for x in -100 .. 100 -> 4 - x * x |]
    |> Array.max
    |> printfn "%A"
```

**Output**
**4**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

