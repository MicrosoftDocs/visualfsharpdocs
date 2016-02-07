# Operator Overloading (F#)

This topic describes how to overload arithmetic operators in a class or record type, and at the global level.


## Syntax


```


// Overloading an operator as a class or record member. 
static member (operator-symbols) (parameter-list) = 
method-body
// Overloading an operator at the global level
let [inline] (operator-symbols) parameter-list =    function-body

```



## Remarks
In the previous syntax, the *operator-symbol* is one of **+**, **-**, **&#42;**, **/**, **=**, and so on. The *parameter-list* specifies the operands in the order they appear in the usual syntax for that operator. The *method-body* constructs the resulting value.

Operator overloads for operators must be static. Operator overloads for unary operators, such as **+** and **-**, must use a tilde (**~**) in the *operator-symbol* to indicate that the operator is a unary operator and not a binary operator, as shown in the following declaration.



```

f#
static member (~-) (v : Vector)

```


The following code illustrates a vector class that has just two operators, one for unary minus and one for multiplication by a scalar. In the example, two overloads for scalar multiplication are needed because the operator must work regardless of the order in which the vector and scalar appear.

[!code-fsharp[Main](snippets/fslangref2/snippet4001.fs)]
    
## Creating New Operators
You can overload all the standard operators, but you can also create new operators out of sequences of certain characters. Allowed operator characters are **!**, **%**, **&amp;**, **&#42;**, **+**, **-**, **.**, **/**, **&lt;**, **=**, **&gt;**, **?**, **@**, **^**, **|**, and **~**. The **~** character has the special meaning of making an operator unary, and is not part of the operator character sequence. Not all operators can be made unary, as is described in [Prefix and Infix Operators](http://msdn.microsoft.com/en-us/library/#prefix) later in this topic.

Depending on the exact character sequence you use, your operator will have a certain precedence and associativity. Associativity can be either left to right or right to left and is used whenever operators of the same level of precedence appear in sequence without parentheses.

The operator character **.** does not affect precedence, so that, for example, if you want to define your own version of multiplication that has the same precedence and associativity as ordinary multiplication, you could create operators such as **.&#42;**.

A table that shows the precedence of all operators in F# can be found in [Symbol and Operator Reference &#40;F&#35;&#41;](Symbol+and+Operator+Reference+%28FSharp%29.md).


## Overloaded Operator Names
When the F# compiler compiles an operator expression, it generates a method that has a compiler-generated name for that operator. This is the name that appears in the Microsoft intermediate language (MSIL) for the method, and also in reflection and IntelliSense. You do not normally need to use these names in F# code.

The following table shows the standard operators and their corresponding generated names.



|Operator|Generated name|
|--------|--------------|
|**[]**|**op_Nil**|
|**::**|**op_Cons**|
|**+**|**op_Addition**|
|**-**|**op_Subtraction**|
|**&#42;**|**op_Multiply**|
|**/**|**op_Division**|
|**@**|**op_Append**|
|**^**|**op_Concatenate**|
|**%**|**op_Modulus**|
|**&amp;&amp;&amp;**|**op_BitwiseAnd**|
|**&#124;&#124;&#124;**|**op_BitwiseOr**|
|**^^^**|**op_ExclusiveOr**|
|**&lt;&lt;&lt;**|**op_LeftShift**|
|**~~~**|**op_LogicalNot**|
|**&gt;&gt;&gt;**|**op_RightShift**|
|**~+**|**op_UnaryPlus**|
|**~-**|**op_UnaryNegation**|
|**=**|**op_Equality**|
|**&lt;=**|**op_LessThanOrEqual**|
|**&gt;=**|**op_GreaterThanOrEqual**|
|**&lt;**|**op_LessThan**|
|**&gt;**|**op_GreaterThan**|
|**?**|**op_Dynamic**|
|**?&lt;-**|**op_DynamicAssignment**|
|**&#124;&gt;**|**op_PipeRight**|
|**&lt;&#124;**|**op_PipeLeft**|
|**!**|**op_Dereference**|
|**&gt;&gt;**|**op_ComposeRight**|
|**&lt;&lt;**|**op_ComposeLeft**|
|**&lt;@ @&gt;**|**op_Quotation**|
|**&lt;@@ @@&gt;**|**op_QuotationUntyped**|
|**+=**|**op_AdditionAssignment**|
|**-=**|**op_SubtractionAssignment**|
|**&#42;=**|**op_MultiplyAssignment**|
|**/=**|**op_DivisionAssignment**|
|**..**|**op_Range**|
|**.. ..**|**op_RangeStep**|
Other combinations of operator characters that are not listed here can be used as operators and have names that are made up by concatenating names for the individual characters from the following table. For example, +! becomes **op_PlusBang**.



|Operator character|Name|
|------------------|----|
|**&gt;**|**Greater**|
|**&lt;**|**Less**|
|**+**|**Plus**|
|**-**|**Minus**|
|**&#42;**|**Multiply**|
|**/**|**Divide**|
|**=**|**Equals**|
|**~**|**Twiddle**|
|**%**|**Percent**|
|**.**|**Dot**|
|**&amp;**|**Amp**|
|**&#124;**|**Bar**|
|**@**|**At**|
|**^**|**Hat**|
|**!**|**Bang**|
|**?**|**Qmark**|
|**(**|**LParen**|
|**,**|**Comma**|
|**)**|**RParen**|
|**[**|**LBrack**|
|**]**|**RBrack**|

## <a name="prefix"> </a>

## Prefix and Infix Operators
*Prefix* operators are expected to be placed in front of an operand or operands, much like a function. *Infix* operators are expected to be placed between the two operands.

Only certain operators can be used as prefix operators. Some operators are always prefix operators, others can be infix or prefix, and the rest are always infix operators. Operators that begin with **!**, except **!=**, and the operator **~**, or repeated sequences of**~**, are always prefix operators. The operators **+**, **-**, **+.**, **-.**, **&amp;**, **&amp;&amp;**, **%**, and **%%** can be prefix operators or infix operators. You distinguish the prefix version of these operators from the infix version by adding a **~** at the beginning of a prefix operator when it is defined. The **~** is not used when you use the operator, only when it is defined.

**The following code illustrates the use of operator overloading to implement a fraction type. A fraction is represented by a numerator and a denominator. The function hcf is used to determine the highest common factor, which is used to reduce fractions.**
[!code-fsharp[Main](snippets/fslangref2/snippet4002.fs)]
**// Output:**
**3/4 + 1/2 = 5/4**
**3/4 - 1/2 = 1/4**
**3/4 &#42; 1/2 = 3/8**
**3/4 / 1/2 = 3/2**
**3/4 + 1 = 7/4**
## Operators at the Global Level
You can also define operators at the global level. The following code defines an operator +?.

[!code-fsharp[Main](snippets/fslangref2/snippet4003.fs)]
    The output of the above code is **12**.

You can redefine the regular arithmetic operators in this manner because the scoping rules for F# dictate that newly defined operators take precedence over the built-in operators.

The keyword **inline** is often used with global operators, which are often small functions that are best integrated into the calling code. Making operator functions inline also enables them to work with statically resolved type parameters to produce statically resolved generic code. For more information, see [Inline Functions &#40;F&#35;&#41;](Inline+Functions+%28FSharp%29.md) and [Statically Resolved Type Parameters &#40;F&#35;&#41;](Statically+Resolved+Type+Parameters+%28FSharp%29.md).


## See Also
[Members &#40;F&#35;&#41;](Members+%28FSharp%29.md)

