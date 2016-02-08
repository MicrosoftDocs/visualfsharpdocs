# Core.ReferenceEqualityAttribute Class (F#)

Adding this attribute to a record or union type disables the automatic generation of overrides for **M:System.Object.Equals(System.Object)**, **M:System.Object.GetHashCode** and **T:System.IComparable** for the type. The type will by default use reference equality.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
[<Sealed>]
type ReferenceEqualityAttribute =
class
new ReferenceEqualityAttribute : unit -> ReferenceEqualityAttribute
end

```



## Remarks
You can also use the short form of the name, **ReferenceEquality**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/a1deaf51-602e-4fc9-9b1e-8f70d325bf20)|Creates an instance of the attribute.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%28FSharp%29.md)

