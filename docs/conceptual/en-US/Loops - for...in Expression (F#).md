# Loops: for...in Expression (F#)

This looping construct is used to iterate over the matches of a pattern in an enumerable collection such as a range expression, sequence, list, array, or other construct that supports enumeration.


## CAPS_SYNTAX_MD



```


for pattern in enumerable-expression do
body-expression


```



## CAPS_REMARKS_MD
The **for…in** expression can be compared to the **for each** statement in other .NET languages because it is used to loop over the values in an enumerable collection. However, **for…in** also supports pattern matching over the collection instead of just iteration over the whole collection.

The enumerable expression can be specified as an enumerable collection or, by using the **..** operator, as a range on an integral type. Enumerable collections include lists, sequences, arrays, sets, maps, and so on. Any type that implements **T:System.Collections.IEnumerable** can be used.

When you express a range by using the **..** operator, you can use the following syntax.

*start* .. *finish*

You can also use a version that includes an increment called the *skip*, as in the following code.

*start* .. *skip* .. *finish*

When you use integral ranges and a simple counter variable as a pattern, the typical behavior is to increment the counter variable by 1 on each iteration, but if the range includes a skip value, the counter is incremented by the skip value instead.

Values matched in the pattern can also be used in the body expression.

The following code examples illustrate the use of the **for...in** expression.



```



// Looping over a list.
let list1 = [ 1; 5; 100; 450; 788 ]
for i in list1 do
   printfn "%d" i


```



    The output is as follows.




```


1
5
100
450
788


```


The following example shows how to loop over a sequence, and how to use a tuple pattern instead of a simple variable.



```



let seq1 = seq { for i in 1 .. 10 -> (i, i*i) }
for (a, asqr) in seq1 do
  printfn "%d squared is %d" a asqr


```



    The output is as follows.




```


1 squared is 1
2 squared is 4
3 squared is 9
4 squared is 16
5 squared is 25
6 squared is 36
7 squared is 49
8 squared is 64
9 squared is 81
10 squared is 100


```


The following example shows how to loop over a simple integer range.



```



let function1() =
  for i in 1 .. 10 do
    printf "%d " i
  printfn ""
function1()


```



    The output of function1 is as follows.




```


1 2 3 4 5 6 7 8 9 10


```


The following example shows how to loop over a range with a skip of 2, which includes every other element of the range.



```



let function2() =
  for i in 1 .. 2 .. 10 do
     printf "%d " i
  printfn ""
function2()


```



    The output of **function2** is as follows.




```


1 3 5 7 9


```


The following example shows how to use a character range.



```



let function3() =
  for c in 'a' .. 'z' do
    printf "%c " c
  printfn ""
function3()


```



    The output of **function3** is as follows.




```


a b c d e f g h i j k l m n o p q r s t u v w x y z


```


The following example shows how to use a negative skip value for a reverse iteration.



```



let function4() =
    for i in 10 .. -1 .. 1 do
        printf "%d " i
    printfn " ... Lift off!"
function4()


```



    The output of **function4** is as follows.




```


10 9 8 7 6 5 4 3 2 1 ... Lift off!


```


The beginning and ending of the range can also be expressions, such as functions, as in the following code.



```



let beginning x y = x - 2*y
let ending x y = x + 2*y

let function5 x y =
  for i in (beginning x y) .. (ending x y) do
     printf "%d " i
  printfn ""

function5 10 4


```



    The output of **function5** with this input is as follows.




```


2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18


```


The next example shows the use of a wildcard character (_) when the element is not needed in the loop.



```



let mutable count = 0
for _ in list1 do
   count <- count + 1
printfn "Number of elements in list1: %d" count


```



    The output is as follows.




```


Number of elements in list1: 5


```


**Note** You can use **for...in** in sequence expressions and other computation expressions, in which case a customized version of the **for...in** expression is used. For more information, see [Sequences &#40;F&#35;&#41;](Sequences+%28F%23%29.md), [Asynchronous Workflows &#40;F&#35;&#41;](Asynchronous+Workflows+%28F%23%29.md), and [Computation Expressions &#40;F&#35;&#41;](Computation+Expressions+%28F%23%29.md).


## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Loops: for...to Expression &#40;F&#35;&#41;](Loops+-+for...to+Expression+%28F%23%29.md)

[Loops: while...do Expression &#40;F&#35;&#41;](Loops+-+while...do+Expression+%28F%23%29.md)

