# ITypeProvider.ApplyStaticArguments Method (F#)

Apply static arguments to a provided type that accepts static arguments.

**Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
abstract this.ApplyStaticArguments : Type * string [] * obj [] -> Type

// Usage:
iTypeProvider.ApplyStaticArguments (typeWithoutArguments, typeNameWithArguments, staticArguments)


```





#### Parameters
*typeWithoutArguments*
Type: **T:System.Type**


A type to which you want to apply static arguments.


*typeNameWithArguments*
Type: [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a) []


The mangled name of the type after including static parameters. The mangled name is derived from the base type name by adding a backtick (&#96;) and a number that indicates the number of static arguments.


*staticArguments*
Type: [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The static parameters, indexed by name.




## Return Value
The resulting type with static arguments applied.


## Remarks
The provider must return a type with the given mangled name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0Supported in: 4.0, Portable




## See Also
[CompilerServices.ITypeProvider Interface &#40;F&#35;&#41;](CompilerServices.ITypeProvider-Interface-%5BFSharp%5D.md)

[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices-Namespace-%5BFSharp%5D.md)

