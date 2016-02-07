# Collections.IStructuralEquatable Interface (F#)

Defines methods to support the comparison of objects for structural equality.

**Namespace/Module Path**: System.Collections

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


type IStructuralEquatable =
interface
abstract this.Equals : obj * IEqualityComparer -> bool
abstract this.GetHashCode : IEqualityComparer -> int
end

```



## Remarks
This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, **T:System.Collections.IStructuralEquatable**.


## Instance Members


|Member|Description|
|------|-----------|
|[Equals](http://msdn.microsoft.com/en-us/library/d8d24d5c-1a02-49e7-ad4d-4c38b92aa670)|Equality comparison against a target object with a given comparer.|
|[GetHashCode](http://msdn.microsoft.com/en-us/library/1aeeb426-e8a9-4a4a-8151-55f1073a86c2)|Returns a hash code for the current instance.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[System.Collections Namespace &#40;F&#35;&#41;](System.Collections+Namespace+%28FSharp%29.md)

