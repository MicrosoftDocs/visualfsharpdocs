# List.reduceBack<'T> Function (F#)

Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is **f** and the elements are **i0...iN**, then this function computes **f i0 (...(f iN-1 iN))**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
List.reduceBack : ('T -> 'T -> 'T) -> 'T list -> 'T

// Usage:
List.reduceBack reduction list

```



#### Parameters
*reduction*
Type: **'T -&gt; 'T -&gt; 'T**


The function to reduce two list elements to a single element.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**exceptions tag is not supported!!!!**
**The final reduced value.**
## Remarks
This function is named **ReduceBack** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28FSharp%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

