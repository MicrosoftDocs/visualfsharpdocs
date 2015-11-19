# Core.EqualityConditionalOnAttribute Class (F#)

This attribute is used to indicate a generic container type satisfies the F# equality constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter **'T** on a type definition **C&lt;'T&gt;** means that a type **C&lt;X&gt;** only supports equality if the type **X** also supports equality and all other conditions for **C&lt;X&gt;** to support equality are also met. The type **C&lt;'T&gt;** can still be used with other type arguments, but a type such as **C&lt;(int -&gt; int)&gt;** will not support equality because the type **(int -&gt; int)** is an F# function type and does not support equality.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<AttributeUsage(AttributeTargets.GenericParameter, AllowMultiple = false)>]
[<Sealed>]
type EqualityConditionalOnAttribute =
class
new EqualityConditionalOnAttribute : unit -> EqualityConditionalOnAttribute
end
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This attribute will be ignored if it is used on the generic parameters of functions or methods.

You can also use the short form of the name, **EqualityConditionalOn**.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/7fd67389-8d84-4376-bc9c-fc02ab507305)|Creates an instance of the attribute|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

