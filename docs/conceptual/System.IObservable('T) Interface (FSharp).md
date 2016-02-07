# System.IObservable<'T> Interface (F#)

A source of observable results

**Namespace/Module Path**: System

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AllowNullLiteral>]
type IObservable<'T> =
interface
abstract this.Subscribe : IObserver<'T> -> IDisposable
end

```



## Remarks
This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, **T:System.IObservable&#96;1**.


## Instance Members


|Member|Description|
|------|-----------|
|[Subscribe](http://msdn.microsoft.com/en-us/library/e9c09e03-b1f9-4975-b992-1f222e8298ae)|Subscribe an observer to the source of results|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0




## See Also
[System Namespace &#40;F&#35;&#41;](System+Namespace+%28FSharp%29.md)

[Control.Observable Module &#40;F&#35;&#41;](Control.Observable+Module+%28FSharp%29.md)

