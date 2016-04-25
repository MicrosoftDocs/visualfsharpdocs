# Core.CompilationArgumentCountsAttribute Class (F#)

Used internally by the compiler to indicate that a functions or member accepts a partial application of some of its arguments and returns a residual function.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>]
[<Sealed>]
type CompilationArgumentCountsAttribute =
class
new CompilationArgumentCountsAttribute : int [] -> CompilationArgumentCountsAttribute
member this.Counts :  IEnumerable<int>
end


```





## Remarks
You can also use the short form of the name, **CompilationArgumentCounts**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/3f551a93-42c4-45fc-9bd4-5daf714e31bc)|Creates an instance of the attribute.|

## Instance Members


|Member|Description|
|------|-----------|
|[Counts](http://msdn.microsoft.com/en-us/library/c7ea3be1-a18a-421d-b8b2-f63f511ea193)|Indicates the number of arguments in each argument group|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

