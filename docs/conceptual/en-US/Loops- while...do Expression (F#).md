# Loops: while...do Expression (F#)

The **while...do** expression is used to perform iterative execution (looping) while a specified test condition is true.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
while test-expression do
body-expression
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The *test-expression* is evaluated; if it is **true**, the *body-expression* is executed and the test expression is evaluated again. The *body-expression* must have type **unit**. If the test expression is **false**, the iteration ends.

The following example illustrates the use of the **while...do** expression.

[!CODE [FsLangRef2#5301](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/loops3.fs#5301)]
    The output of the previous code is a stream of random numbers between 1 and 20, the last of which is 10.


```
13 19 8 18 16 2 10
Found a 10!
```

>[!NOTE] {You can use **while...do** in sequence expressions and other computation expressions, in which case a customized version of the **while...do** expression is used. For more information, see [Sequences &#40;F&#35;&#41;](Sequences+28%F%2329%.md), [Asynchronous Workflows &#40;F&#35;&#41;](Asynchronous+Workflows+28%F%2329%.md), and [Computation Expressions &#40;F&#35;&#41;](Computation+Expressions+28%F%2329%.md).

}

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Loops: for...in Expression &#40;F&#35;&#41;](Loops%3A+for...in+Expression+28%F%2329%.md)

[Loops: for...to Expression &#40;F&#35;&#41;](Loops%3A+for...to+Expression+28%F%2329%.md)

