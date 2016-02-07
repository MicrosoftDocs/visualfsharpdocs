# Map.toArray<'Key,'T> Function (F#)

Returns an array of all key/value pairs in the mapping. The array will be ordered by the keys of the map.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Map.toArray : Map<'Key,'T> -> ('Key * 'T) [] (requires comparison)

// Usage:
Map.toArray table

```



#### Parameters
*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The array of key/value pairs.**
## Remarks
This function is named **ToArray** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

