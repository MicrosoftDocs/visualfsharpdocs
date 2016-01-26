# FSharpValue.PreComputeTupleConstructorInfo Method (F#)

Gets a method that constructs objects of the given tuple type. For small tuples, no additional type will be returned.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member PreComputeTupleConstructorInfo : Type -> ConstructorInfo * Type option

// Usage:
FSharpValue.PreComputeTupleConstructorInfo (tupleType)
```

#### CAPS_PARAMETERS_MD
*tupleType*
Type: **T:System.Type**


The input tuple type.



**The description of the tuple type constructor and an optional extra type for large tuples.**
## CAPS_REMARKS_MD
For large tuples, an additional type is returned indicating that a nested encoding has been used for the tuple type. In this case the suffix portion of the tuple type has the given type and an object of this type must be created and passed as the last argument to the **T:System.Reflection.ConstructorInfo**. A recursive call to **PreComputeTupleConstructorInfo** can be used to determine the constructor for that the suffix type.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue+Class+%28F%23%29.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection+Namespace+%28F%23%29.md)

