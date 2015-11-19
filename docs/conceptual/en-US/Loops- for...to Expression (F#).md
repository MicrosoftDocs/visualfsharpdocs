# Loops: for...to Expression (F#)

The **for...to** expression is used to iterate in a loop over a range of values of a loop variable.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
for identifier = start [ to | downto ] finish do
body-expression
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The type of the identifier is inferred from the type of the *start* and *finish* expressions. Types for these expressions must be 32-bit integers.

Although technically an expression, **for...to** is more like a traditional statement in an imperative programming language. The return type for the *body-expression* must be **unit**. The following examples show various uses of the **for...to** expression.

[!CODE [FsLangRef2#5101](../CodeSnippet/VS_Snippets_Fsharp/fslangref2/FSharp/fs/loops1.fs#5101)]
    The output of the previous code is as follows.


```
1 2 3 4 5 6 7 8 9 10
10 9 8 7 6 5 4 3 2 1
2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18
```

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Loops: for...in Expression &#40;F&#35;&#41;](Loops%3A+for...in+Expression+28%F%2329%.md)

[Loops: while...do Expression &#40;F&#35;&#41;](Loops%3A+while...do+Expression+28%F%2329%.md)

