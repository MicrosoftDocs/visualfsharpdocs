# Core.Choice<'T1,'T2,'T3,'T4,'T5> Union (F#)

Helper types for active patterns with five choices.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<StructuralEquality>]
[<StructuralComparison>]
type Choice<'T1,'T2,'T3,'T4,'T5> =
| Choice1Of5 of 'T1
| Choice2Of5 of 'T2
| Choice3Of5 of 'T3
| Choice4Of5 of 'T4
| Choice5Of5 of 'T5
with
interface IStructuralEquatable
interface IComparable
interface IComparable
interface IStructuralComparable
end


```



## CAPS_REMARKS_MD

## Union Cases


|Case|Description|
|----|-----------|
|Choice1Of5 of 'T1|The first choice.|
|Choice2Of5 of 'T2|The second choice.|
|Choice3Of5 of 'T3|The third choice.|
|Choice4Of5 of 'T4|The fourth choice.|
|Choice5Of5 of 'T5|The fifth choice.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

