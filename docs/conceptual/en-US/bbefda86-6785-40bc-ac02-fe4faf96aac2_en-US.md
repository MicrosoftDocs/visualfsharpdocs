# Loops: for...to Expression (F#)

The **for...to** expression is used to iterate in a loop over a range of values of a loop variable.


## CAPS_SYNTAX_MD

```
for identifier = start [ to | downto ] finish do
body-expression
```

## CAPS_REMARKS_MD
The type of the identifier is inferred from the type of the *start* and *finish* expressions. Types for these expressions must be 32-bit integers.

Although technically an expression, **for...to** is more like a traditional statement in an imperative programming language. The return type for the *body-expression* must be **unit**. The following examples show various uses of the **for...to** expression.

```

// A simple for...to loop.
let function1() =
  for i = 1 to 10 do
    printf "%d " i
  printfn ""

// A for...to loop that counts in reverse.
let function2() =
  for i = 10 downto 1 do
    printf "%d " i
  printfn ""

function1()
function2()

// A for...to loop that uses functions as the start and finish expressions.
let beginning x y = x - 2*y
let ending x y = x + 2*y

let function3 x y =
  for i = (beginning x y) to (ending x y) do
     printf "%d " i
  printfn ""

function3 10 4
```

    The output of the previous code is as follows.


```
1 2 3 4 5 6 7 8 9 10
10 9 8 7 6 5 4 3 2 1
2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18
```

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Loops: for...in Expression &#40;F&#35;&#41;](Loops%3A+for...in+Expression+%28F%23%29.md)

[Loops: while...do Expression &#40;F&#35;&#41;](Loops%3A+while...do+Expression+%28F%23%29.md)

