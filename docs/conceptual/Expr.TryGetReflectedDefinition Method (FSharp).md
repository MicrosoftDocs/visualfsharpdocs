# Expr.TryGetReflectedDefinition Method (F#)

Tries to find a stored reflection definition for the given method. Stored reflection definitions are added to an F# assembly through the use of the [ReflectedDefinition](http://msdn.microsoft.com/en-us/library/56bb03a2-4deb-4860-b334-f59fdfc95b04) attribute.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
static member TryGetReflectedDefinition : MethodBase -> Expr option

// Usage:
Expr.TryGetReflectedDefinition (methodBase)

```



#### Parameters
*methodBase*
Type: **T:System.Reflection.MethodBase**


The description of the method to find.



**The reflection definition or None if a match could not be found.**
## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Quotations.Expr Class &#40;F&#35;&#41;](Quotations.Expr+Class+%28FSharp%29.md)

[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations+Namespace+%28FSharp%29.md)

