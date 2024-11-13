---
title: Boolean Operators (F#)
description: Boolean Operators (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: f79370b8-4bc2-4704-b514-d392c80942bd
redirect_url: https://docs.microsoft.com/dotnet/articles/fsharp/language-reference/symbol-and-operator-reference/boolean-operators 
---

# Boolean Operators (F#)

This topic describes the support for Boolean operators in the F# language.


## Summary of Boolean Operators
The following table summarizes the Boolean operators that are available in the F# language. The only type supported by these operators is the **bool** type.



|Operator|Description|
|--------|-----------|
|`not`|Boolean negation|
|<code>&#124;&#124;</code>|Boolean OR|
|`&&`|Boolean AND|

The Boolean AND and OR operators perform *short-circuit evaluation*, that is, they evaluate the expression on the right of the operator only when it is necessary to determine the overall result of the expression. The second expression of the `&&` operator is evaluated only if the first expression evaluates to `true`; the second expression of the `||` operator is evaluated only if the first expression evaluates to `false`.

## See Also
[Bitwise Operators &#40;F&#35;&#41;](Bitwise-Operators-%5BFSharp%5D.md)

[Arithmetic Operators &#40;F&#35;&#41;](Arithmetic-Operators-%5BFSharp%5D.md)

[Symbol and Operator Reference &#40;F&#35;&#41;](Symbol-and-Operator-Reference-%5BFSharp%5D.md)
