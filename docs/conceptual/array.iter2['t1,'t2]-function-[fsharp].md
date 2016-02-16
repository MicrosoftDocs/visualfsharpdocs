# Array.iter2<'T1,'T2> Function (F#)

Applies the given function to pair of elements drawn from matching indices in two arrays. The two arrays must have the same lengths, otherwise an **T:System.ArgumentException** is raised.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Array

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
Array.iter2 : ('T1 -> 'T2 -> unit) -> 'T1 [] -> 'T2 [] -> unit

// Usage:
Array.iter2 action array1 array2

```



#### Parameters
*action*
Type: **'T1 -&gt; 'T2 -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to apply.


*array1*
Type: **'T1**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The first input array.


*array2*
Type: **'T2**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The second input array.



**exceptions tag is not supported!!!!**

## Remarks
This function is named **Iterate2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows the differences between [Array.iter](http://msdn.microsoft.com/en-us/library/94eba0f1-ecd7-459f-b89f-ed2a2923e516), Array.iter2, [Array.iteri](http://msdn.microsoft.com/en-us/library/8bbe2ed4-ada7-4906-ac3e-cb09f9db6486), and [Array.iteri2](http://msdn.microsoft.com/en-us/library/c041b91f-6080-45b7-867b-2ed983a90405).**
<b>codeReference tag is not supported!!!!</b>
**Output**
**Array.iter: element is 1**
**Array.iter: element is 2**
**Array.iter: element is 3**
**Array.iteri: element 0 is 1**
**Array.iteri: element 1 is 2**
**Array.iteri: element 2 is 3**
**Array.iter2: elements are 1 4**
**Array.iter2: elements are 2 5**
**Array.iter2: elements are 3 6**
**Array.iteri2: element 0 of array1 is 1 element 0 of array2 is 4**
**Array.iteri2: element 1 of array1 is 2 element 1 of array2 is 5**
**Array.iteri2: element 2 of array1 is 3 element 2 of array2 is 6**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

