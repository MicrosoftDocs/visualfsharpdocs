# Map.tryPick<'Key,'T,'U> Function (F#)

Searches the map looking for the first element where the given function returns a **Some** value.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Map.tryPick : ('Key -> 'T -> 'U option) -> Map<'Key,'T> -> 'U option (requires comparison)

// Usage:
Map.tryPick chooser table

```



#### Parameters
*chooser*
Type: **'Key -&gt; 'T -&gt; 'U**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The function to generate options from the key/value pairs.


*table*
Type: [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.



**The first result.**
## Remarks
This function is named **TryPick** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code shows the use of the Map.tryPick function.**
[!code-fsharp[Main](snippets/fsmaps/snippet18.fs)]
**Output**
**Result where key and value are the same: 50**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map-Module-%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%28FSharp%29.md)

