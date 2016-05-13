# Core.CLIEventAttribute Class (F#)

Adding this attribute to a property with event type causes it to be compiled with as a Common Language Infrastructure (CLI) metadata event, through a syntactic translation to a pair of **add_EventName** and **remove_EventName** methods.

**Namespace/Module Path**: Microsoft.FSharp.Core

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax



```




[<AttributeUsage(AttributeTargets.Property, AllowMultiple = false)>]
[<Sealed>]
type CLIEventAttribute =
class
new CLIEventAttribute : unit -> CLIEventAttribute
end


```





## Remarks
You can also use the short form of the name, **CLIEvent**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/eedeb776-b947-42db-be4f-6905ee8a14b8)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core-Namespace-%5BFSharp%5D.md)

