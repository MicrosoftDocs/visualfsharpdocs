# FSharpValue.GetExceptionFields Method (F#)

Reads all the fields from a value built using an instance of an F# exception declaration.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member GetExceptionFields : obj * ?BindingFlags -> obj []
static member GetExceptionFields : obj * ?bool -> obj []

// Usage:
FSharpValue.GetExceptionFields (exn)
FSharpValue.GetExceptionFields (exn, bindingFlags = bindingFlags)

open FSharpReflectionExtensions
FSharpValue.GetExceptionFields (exn, allowAccessToPrivateRepresentation = false)

```



#### Parameters
*exn*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)


The exception instance.


*bindingFlags*
Type: **T:System.Reflection.BindingFlags**[option](http://msdn.microsoft.com/en-us/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


Optional binding flags.


*allowAccessToPrivateRepresentation*
Type: [bool](http://msdn.microsoft.com/en-us/library/89c0cf9c-49ce-4207-a3be-555851a67dd5)


Optional flag that denotes accessibility of the private representation.



**exceptions tag is not supported!!!!**
**The fields from the given exception.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Reflection.FSharpValue Class &#40;F&#35;&#41;](Reflection.FSharpValue-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)

