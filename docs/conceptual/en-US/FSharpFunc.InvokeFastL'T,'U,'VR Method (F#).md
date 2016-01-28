# FSharpFunc.InvokeFast<'T,'U,'V> Method (F#)

Invoke an F# first class function value with two curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member InvokeFast : FSharpFunc<'T,('U -> 'V)> * 'T * 'U -> 'V

// Usage:
FSharpFunc.InvokeFast (func, arg1, arg2)
```

#### CAPS_PARAMETERS_MD
*func*
Type: [FSharpFunc](http://msdn.microsoft.com/en-us/library/6fbc582c-a36a-4154-9bfe-296de5ecba53)**&lt;'T,('U -&gt; 'V)&gt;**


The input function.


*arg1*
Type: **'T**


The first arg.


*arg2*
Type: **'U**


The second arg.



**The function result.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.FSharpFunc&#60;'T,'U&#62; Class &#40;F&#35;&#41;](Core.FSharpFuncL%27T%2C%27UR+Class+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

