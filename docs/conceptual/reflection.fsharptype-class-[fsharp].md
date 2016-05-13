# Reflection.FSharpType Class (F#)

Contains operations associated with constructing and analyzing F# types such as records, unions and tuples.

**Namespace/Module Path:** Microsoft.FSharp.Reflection

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




[<AbstractClass>]
[<Sealed>]
type FSharpType =
class
static member GetExceptionFields : Type * ?BindingFlags -> PropertyInfo []
static member GetFunctionElements : Type -> Type * Type
static member GetRecordFields : Type * ?BindingFlags -> PropertyInfo []
static member GetTupleElements : Type -> Type []
static member GetUnionCases : Type * ?BindingFlags -> UnionCaseInfo []
static member IsExceptionRepresentation : Type * ?BindingFlags -> bool
static member IsFunction : Type -> bool
static member IsModule : Type -> bool
static member IsRecord : Type * ?BindingFlags -> bool
static member IsTuple : Type -> bool
static member IsUnion : Type * ?BindingFlags -> bool
static member MakeFunctionType : Type * Type -> Type
static member MakeTupleType : Type [] -> Type
end


```





## Remarks

## Static Members


|Member|Description|
|------|-----------|
|[GetExceptionFields](http://msdn.microsoft.com/en-us/library/7fb355e6-b345-4c7d-bea0-9af302f60148)|Reads all the fields from an F# exception declaration, in declaration order.|
|[GetFunctionElements](http://msdn.microsoft.com/en-us/library/8d1f4508-a36c-4486-93b8-94ec6d2a0df7)|Gets the domain and range types from an F# function type or from the runtime type of a closure implementing an F# type.|
|[GetRecordFields](http://msdn.microsoft.com/en-us/library/266635db-ea29-481f-9cb7-b7f72b754497)|Reads all the fields from a record value, in declaration order.|
|[GetTupleElements](http://msdn.microsoft.com/en-us/library/a7199975-b4cc-45d4-9ec1-d7f450baa04b)|Gets the tuple elements from the representation of an F# tuple type.|
|[GetUnionCases](http://msdn.microsoft.com/en-us/library/a1d0f854-48ac-4e61-a80b-2db11d7d2c1a)|Gets the cases of a union type.|
|[IsExceptionRepresentation](http://msdn.microsoft.com/en-us/library/6ca9be2b-2f54-40b4-90a0-3c5dc623f116)|Returns **true** if the specified type is a representation of an F# exception declaration.|
|[IsFunction](http://msdn.microsoft.com/en-us/library/98a858ba-7be9-4e2f-924e-5c876272a6a7)|Returns **true** if the specified type is a representation of an F# function type or the runtime type of a closure implementing an F# function type.|
|[IsModule](http://msdn.microsoft.com/en-us/library/77f65dd3-3111-4f59-8ab6-c028bc1c47e7)|Returns **true** if the specified type is a **T:System.Type** value corresponding to the compiled form of an F# module.|
|[IsRecord](http://msdn.microsoft.com/en-us/library/bb3b2a3b-51b5-4a8b-82fe-d61282becead)|Returns **true** if the specified type is a representation of an F# record type.|
|[IsTuple](http://msdn.microsoft.com/en-us/library/dc627b14-e1a6-4ac8-b0d2-25e9984f87b7)|Returns **true** if the specified type is a representation of an F# tuple type.|
|[IsUnion](http://msdn.microsoft.com/en-us/library/529743e4-c456-429f-934f-ab8610166abb)|Returns **true** if the specified type is a representation of an F# union type or the runtime type of a value of that type.|
|[MakeFunctionType](http://msdn.microsoft.com/en-us/library/568814c9-1099-439d-abd1-de4a0b923476)|Returns a **T:System.Type****object** representing the F# function type with the given domain and range.|
|[MakeTupleType](http://msdn.microsoft.com/en-us/library/d6ed5a4f-390f-425d-8a21-66271782c417)|Returns a **T:System.Type** representing an F# tuple type with the given element types.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Reflection Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Reflection-Namespace-%5BFSharp%5D.md)

