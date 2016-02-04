# Conditional Expressions: if... then...else (F#)

The **if...then...else** expression runs different branches of code and also evaluates to a different value depending on the Boolean expression given.


## CAPS_SYNTAX_MD



```


if Boolean-expression then expression1 [ else expression2 ]


```



## CAPS_REMARKS_MD
In the previous syntax, *expression1* runs when the Boolean expression evaluates to **true**; otherwise, *expression2* runs.

Unlike in other languages, the **if...then...else** construct is an expression, not a statement. That means that it produces a value, which is the value of the last expression in the branch that executes. The types of the values produced in each branch must match. If there is no explicit **else** branch, its type is **unit**. Therefore, if the type of the **then** branch is any type other than **unit**, there must be an **else** branch with the same return type. When chaining **if...then...else** expressions together, you can use the keyword **elif** instead of **else****if**; they are equivalent.

**The following example illustrates how to use the if...then...else expression.**


```



let test x y =
  if x = y then "equals"
  elif x < y then "is less than"
  else "is greater than"

printfn "%d %s %d." 10 (test 10 20) 20

printfn "What is your name? "
let nameString = System.Console.ReadLine()

printfn "What is your age? "
let ageString = System.Console.ReadLine()
let age = System.Int32.Parse(ageString)

if age < 10
then printfn "You are only %d years old and already learning F#? Wow!" age


```



**John**
**910 is less than 20**
**You are only 9 years old and already learning F#? Wow!**
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

