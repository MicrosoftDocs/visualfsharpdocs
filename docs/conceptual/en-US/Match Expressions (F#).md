# Match Expressions (F#)

The **match** expression provides branching control that is based on the comparison of an expression with a set of patterns.


## CAPS_SYNTAX_MD

```
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

## CAPS_REMARKS_MD
The pattern matching expressions allow for complex branching based on the comparison of a test expression with a set of patterns. In the **match** expression, the *test-expression* is compared with each pattern in turn, and when a match is found, the corresponding *result-expression* is evaluated and the resulting value is returned as the value of the match expression.

The pattern matching function shown in the previous syntax is a lambda expression in which pattern matching is performed immediately on the argument. The pattern matching function shown in the previous syntax is equivalent to the following.

fun *arg* -&gt;

match *arg* with

| *pattern1 *[ when *condition* ] -&gt; *result-expression1*

| *pattern2* [ when *condition* ]-&gt; *result-expression2*

| ...

For more information about lambda expressions, see [Lambda Expressions: The fun Keyword &#40;F&#35;&#41;](Lambda+Expressions+-+The+fun+Keyword+%28F%23%29.md).

The whole set of patterns should cover all the possible matches of the input variable. Frequently, you use the wildcard pattern (_) as the last pattern to match any previously unmatched input values.

The following code illustrates some of the ways in which the **match** expression is used. For a reference and examples of all the possible patterns that can be used, see [Pattern Matching &#40;F&#35;&#41;](Pattern+Matching+%28F%23%29.md).

```

let list1 = [ 1; 5; 100; 450; 788 ]

// Pattern matching by using the cons pattern and a list
// pattern that tests for an empty list.
let rec printList listx =
    match listx with
    | head :: tail -> printf "%d " head; printList tail
    | [] -> printfn ""
  
printList list1

// Pattern matching with multiple alternatives on the same line.  
let filter123 x =
    match x with
    | 1 | 2 | 3 -> printfn "Found 1, 2, or 3!"
    | a -> printfn "%d" a

// The same function written with the pattern matching
// function syntax.
let filterNumbers =
    function | 1 | 2 | 3 -> printfn "Found 1, 2, or 3!"
             | a -> printfn "%d" a
```

    
## Guards on Patterns
You can use a **when** clause to specify an additional condition that the variable must satisfy to match a pattern. Such a clause is referred to as a *guard*. The expression following the **when** keyword is not evaluated unless a match is made to the pattern associated with that guard.

The following example illustrates the use of a guard to specify a numeric range for a variable pattern. Note that multiple conditions are combined by using Boolean operators.

```

let rangeTest testValue mid size =
    match testValue with
    | var1 when var1 >= mid - size/2 && var1 <= mid + size/2 -> printfn "The test value is in range."
    | _ -> printfn "The test value is out of range."

rangeTest 10 20 5
rangeTest 10 20 10
rangeTest 10 20 40
```

    Note that because values other than literals cannot be used in the pattern, you must use a **when** clause if you have to compare some part of the input against a value. This is shown in the following code.

```

// This example uses patterns that have when guards.
let detectValue point target =
    match point with
    | (a, b) when a = target && b = target -> printfn "Both values match target %d." target
    | (a, b) when a = target -> printfn "First value matched target in (%d, %d)" target b
    | (a, b) when b = target -> printfn "Second value matched target in (%d, %d)" a target
    | _ -> printfn "Neither value matches target."
detectValue (0, 0) 0
detectValue (1, 0) 0
detectValue (0, 10) 0
detectValue (10, 15) 0
```

    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Active Patterns &#40;F&#35;&#41;](Active+Patterns+%28F%23%29.md)

