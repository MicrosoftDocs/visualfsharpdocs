---
title: Match Expressions (F#)
description: Match Expressions (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 8854b713-255a-408d-942a-e80ab52fd2a4
redirect_url: https://docs.microsoft.com/dotnet/articles/fsharp/language-reference/match-expressions
---

# Match Expressions (F#)

The `match` expression provides branching control that is based on the comparison of an expression with a set of patterns.

## Syntax

```fsharp
// Match expression.
match test-expression with
| pattern1 [ when condition ] -> result-expression1
| pattern2 [ when condition ] -> result-expression2
| ...

// Pattern matching function.
function
| pattern1 [ when condition ] -> result-expression1
| pattern2 [ when condition ] -> result-expression2
| ...
```

## Remarks

The pattern matching expressions allow for complex branching based on the comparison of a test expression with a set of patterns. In the `match` expression, the *test-expression* is compared with each pattern in turn, and when a match is found, the corresponding *result-expression* is evaluated and the resulting value is returned as the value of the match expression.

The pattern matching function shown in the previous syntax is a lambda expression in which pattern matching is performed immediately on the argument. The pattern matching function shown in the previous syntax is equivalent to the following.

```fsharp
fun arg ->
    match arg with
    | pattern1 [ when condition ] -> result-expression1
    | pattern2 [ when condition ] -> result-expression2
    | ...
```    

For more information about lambda expressions, see [Lambda Expressions: The fun Keyword &#40;F&#35;&#41;](Lambda-Expressions-The-fun-Keyword-%5BFSharp%5D.md).

The whole set of patterns should cover all the possible matches of the input variable. Frequently, you use the wildcard pattern (`_`) as the last pattern to match any previously unmatched input values.

The following code illustrates some of the ways in which the `match` expression is used. For a reference and examples of all the possible patterns that can be used, see [Pattern Matching &#40;F&#35;&#41;](Pattern-Matching-%5BFSharp%5D.md).

[!code-fsharp[Main](snippets/fslangref2/snippet4601.fs)]

## Guards on Patterns

You can use a `when` clause to specify an additional condition that the variable must satisfy to match a pattern. Such a clause is referred to as a *guard*. The expression following the `when` keyword is not evaluated unless a match is made to the pattern associated with that guard.

The following example illustrates the use of a guard to specify a numeric range for a variable pattern. Note that multiple conditions are combined by using Boolean operators.

[!code-fsharp[Main](snippets/fslangref2/snippet4602.fs)]

Note that because values other than literals cannot be used in the pattern, you must use a `when` clause if you have to compare some part of the input against a value. This is shown in the following code.

[!code-fsharp[Main](snippets/fslangref2/snippet4603.fs)]

## See Also

[F&#35; Language Reference](FSharp-Language-Reference.md)

[Active Patterns &#40;F&#35;&#41;](Active-Patterns-%5BFSharp%5D.md)
