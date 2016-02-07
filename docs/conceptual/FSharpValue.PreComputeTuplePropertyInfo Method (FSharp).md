# FSharpValue.PreComputeTuplePropertyInfo Method (F#)

Gets information that indicates how to read a field of a tuple.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member PreComputeTuplePropertyInfo : Type * int -> PropertyInfo * (Type * int) option

// Usage:
FSharpValue.PreComputeTuplePropertyInfo (tupleType, index)

```



#### Parameters
*tupleType*
Type: **T:System.Type**


The input tuple type.


*index*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index of the tuple element to describe.



**The description of the tuple element as a T:System.Reflection.PropertyInfo object and an optional type and index if the tuple is big.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28FSharp%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28FSharp%29.md)

