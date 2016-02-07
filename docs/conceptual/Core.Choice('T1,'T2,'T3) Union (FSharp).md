# Core.Choice<'T1,'T2,'T3> Union (F#)

Helper types for active patterns with three choices.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<StructuralEquality>]
[<StructuralComparison>]
type Choice<'T1,'T2,'T3> =
| Choice1Of3 of 'T1
| Choice2Of3 of 'T2
| Choice3Of3 of 'T3
with
interface IStructuralEquatable
interface IComparable
interface IComparable
interface IStructuralComparable
end

```



## Remarks

## Union Cases


|Case|Description|
|----|-----------|
|Choice1Of3 of 'T1|The first choice.|
|Choice2Of3 of 'T2|The second choice.|
|Choice3Of3 of 'T3|The third choice.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

