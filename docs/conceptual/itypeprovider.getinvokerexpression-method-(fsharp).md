# ITypeProvider.GetInvokerExpression Method (F#)

Called by the compiler to ask for an Expression tree to replace the given MethodBase with.

**Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


// Signature:
abstract this.GetInvokerExpression : MethodBase * Quotations.Expr [] -> Quotations.Expr

// Usage:
iTypeProvider.GetInvokerExpression (syntheticMethodBase, parameters)

```



#### Parameters
*syntheticMethodBase*
Type: **T:System.Reflection.MethodBase**


MethodBase that was given to the compiler by a type returned by a GetType(s) call.


*parameters*
Type: [Quotations.Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65) []


Expressions that represent the parameters to this call.




## Return Value
An Expression tree that the compiler will use in place of the given method base.


## Remarks

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0Supported in: 4.0, Portable




## See Also
[CompilerServices.ITypeProvider Interface &#40;F&#35;&#41;](CompilerServices.ITypeProvider-Interface-%28FSharp%29.md)

[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices-Namespace-%28FSharp%29.md)

