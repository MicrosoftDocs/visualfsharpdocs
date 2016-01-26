# Boolean Operators (F#)

This topic describes the support for Boolean operators in the F# language.


## Summary of Boolean Operators
The following table summarizes the Boolean operators that are available in the F# language. The only type supported by these operators is the **bool** type.



|Operator|Description|
|--------|-----------|
|**not**|Boolean negation|
|**&#124;&#124;**|Boolean OR|
|**&amp;&amp;**|Boolean AND|
The Boolean AND and OR operators perform *short-circuit evaluation*, that is, they evaluate the expression on the right of the operator only when it is necessary to determine the overall result of the expression. The second expression of the **&amp;&amp;** operator is evaluated only if the first expression evaluates to **true**; the second expression of the **||** operator is evaluated only if the first expression evaluates to **false**.


## See Also
[Bitwise Operators &#40;F&#35;&#41;](Bitwise+Operators+%28F%23%29.md)

[Arithmetic Operators &#40;F&#35;&#41;](Arithmetic+Operators+%28F%23%29.md)

[Symbol and Operator Reference &#40;F&#35;&#41;](Symbol+and+Operator+Reference+%28F%23%29.md)

