# Lambda Expressions: The fun Keyword (F#)

The **fun** keyword is used to define a lambda expression, that is, an anonymous function.


## CAPS_SYNTAX_MD

```
fun parameter-list -> expression
```

## CAPS_REMARKS_MD
The *parameter-list* typically consists of names and, optionally, types of parameters. More generally, the *parameter-list* can be composed of any F# patterns. For a full list of possible patterns, see [Pattern Matching &#40;F&#35;&#41;](Pattern+Matching+%28F%23%29.md). Lists of valid parameters include the following examples.


```f#
// Lambda expressions with parameter lists.
fun a b c -> ...
fun (a: int) b c -> ...
fun (a : int) (b : string) (c:float) -> ...

// A lambda expression with a tuple pattern.
fun (a, b) -> …

// A lambda expression with a list pattern.
fun head :: tail -> …
```
The *expression* is the body of the function, the last expression of which generates a return value. Examples of valid lambda expressions include the following:

```

fun x -> x + 1
fun a b c -> printfn "%A %A %A" a b c
fun (a: int) (b: int) (c: int) -> a + b * c
fun x y -> let swap (a, b) = (b, a) in swap (x, y)
```

    
## Using Lambda Expressions
Lambda expressions are especially useful when you want to perform operations on a list or other collection and want to avoid the extra work of defining a function. Many F# library functions take function values as arguments, and it can be especially convenient to use a lambda expression in those cases. The following code applies a lambda expression to elements of a list. In this case, the anonymous function adds 1 to every element of a list.

```

let list = List.map (fun i -> i + 1) [1;2;3]
printfn "%A" list
```

    
## See Also
[Functions &#40;F&#35;&#41;](Functions+%28F%23%29.md)

