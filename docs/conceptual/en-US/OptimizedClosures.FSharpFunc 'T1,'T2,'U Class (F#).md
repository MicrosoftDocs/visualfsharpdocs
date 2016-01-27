# OptimizedClosures.FSharpFunc<'T1,'T2,'U> Class (F#)

The .NET Framework type used to represent F# function values that accept two iterated (curried) arguments without intervening execution. This type should not typically used directly from either F# code or from other .NET Framework languages.

**Namespace/Module Path:** Microsoft.FSharp.Core.OptimizedClosures

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
[<AbstractClass>]
type FSharpFunc<'T1,'T2,'U> =
class
new FSharpFunc : unit -> FSharpFunc<'T1,'T2,'U>
static member FSharpFunc.Adapt : ('T1 -> 'T2 -> 'U) -> FSharpFunc<'T1,'T2,'U>
abstract this.Invoke : FSharpFunc<'T1,'T2,'U> -> 'T1 * 'T2 -> 'U
end
```

## CAPS_REMARKS_MD

## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/6bd2a7fb-34fe-412a-b051-431401959b3e)|Construct an optimized function value that can accept two curried arguments without intervening execution.|

## Instance Members


|Member|Description|
|------|-----------|
|[Invoke](http://msdn.microsoft.com/en-us/library/3373e0ad-8a6e-4998-b906-35fb92bc8ca4)|Invoke the optimized function value with two curried arguments|

## Static Members


|Member|Description|
|------|-----------|
|[Adapt](http://msdn.microsoft.com/en-us/library/17223c26-7923-4b96-8ee8-3c1ce77fdcf6)|Adapt an F# first class function value to be an optimized function value that can accept two curried arguments without intervening execution.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.OptimizedClosures Module &#40;F&#35;&#41;](Core.OptimizedClosures+Module+%28F%23%29.md)

