# Core.NoEqualityAttribute Class (F#)

Adding this attribute to a type indicates it is a type where equality is an abnormal operation. This means that the type does not satisfy the F# equality constraint. Within the bounds of the F# type system, this helps ensure that the F# generic equality function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Interface ||| AttributeTargets.Delegate ||| AttributeTargets.Struct ||| AttributeTargets.Enum, AllowMultiple = false)>]
[<Sealed>]
type NoEqualityAttribute =
class
new NoEqualityAttribute : unit -> NoEqualityAttribute
end


```



## CAPS_REMARKS_MD
You can also use the short form of the name, **NoEquality**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/72c10252-c40b-4644-b07b-e604f30b9699)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

