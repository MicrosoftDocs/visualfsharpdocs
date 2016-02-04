# List.Item<'T> Property (F#)

Gets the element of the list at the given position.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
member this.Item (int) :  'T

// Usage:
list.[index]


```



#### CAPS_PARAMETERS_MD
*index*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index.



**The value at the given index.**
## CAPS_REMARKS_MD
Lists are represented as linked lists so this is an O(n) operation.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List&#60;'T&#62; Union &#40;F&#35;&#41;](Collections.List+%27T+Union+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

