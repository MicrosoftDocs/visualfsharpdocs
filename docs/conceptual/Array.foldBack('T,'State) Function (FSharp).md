# Array.foldBack<'T,'State> Function (F#)

Applies a function to each element of the array, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN** then computes **f i0 (...(f iN s))**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
Array.foldBack : ('T -> 'State -> 'State) -> 'T [] -> 'State -> 'State

// Usage:
Array.foldBack folder array state
```

#### Parameters
*folder*
Type: **'T -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.


*state*
Type: **'State**


The initial state.



**The final state.**
## Remarks
This function is named **FoldBack** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example shows the difference between [Array.fold](http://msdn.microsoft.com/en-us/library/5ed9dd3b-3694-4567-94d0-fd9a24474e09) and Array.foldBack.**
<b>codeReference tag is not supported!!!!</b>
**Output**
**-6**
**2**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

