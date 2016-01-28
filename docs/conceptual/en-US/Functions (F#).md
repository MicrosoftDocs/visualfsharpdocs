# Functions (F#)

Functions are the fundamental unit of program execution in any programming language. As in other languages, an F# function has a name, can have parameters and take arguments, and has a body. F# also supports functional programming constructs such as treating functions as values, using unnamed functions in expressions, composition of functions to form new functions, curried functions, and the implicit definition of functions by way of the partial application of function arguments.

You define functions by using the **let** keyword, or, if the function is recursive, the **let rec** keyword combination.


## CAPS_SYNTAX_MD

```
// Non-recursive function definition.
let [inline] function-nameparameter-list [ : return-type ] = function-body
// Recursive function definition.
let rec function-nameparameter-list = recursive-function-body
```

## CAPS_REMARKS_MD
The *function-name* is an identifier that represents the function. The *parameter-list* consists of successive parameters that are separated by spaces. You can specify an explicit type for each parameter, as described in the Parameters section. If you do not specify a specific argument type, the compiler attempts to infer the type from the function body. The *function-body* consists of an expression. The expression that makes up the function body is typically a compound expression consisting of a number of expressions that culminate in a final expression that is the return value. The *return-type* is a colon followed by a type and is optional. If you do not specify the type of the return value explicitly, the compiler determines the return type from the final expression.

A simple function definition resembles the following:


```f#
let f x = x + 1
```
In the previous example, the function name is **f**, the argument is **x**, which has type **int**, the function body is **x + 1**, and the return value is of type **int**.

The inline specifier is a hint to the compiler that the function is small and that the code for the function can be integrated into the body of the caller.


## Scope
At any level of scope other than module scope, it is not an error to reuse a value or function name. If you reuse a name, the name declared later shadows the name declared earlier. However, at the top level scope in a module, names must be unique. For example, the following code produces an error when it appears at module scope, but not when it appears inside a function:

```

 let list1 = [ 1; 2; 3]
 // Error: duplicate definition.
 let list1 = []  
 let function1 =
    let list1 = [1; 2; 3]
    let list1 = []
    list1
```

    But the following code is acceptable at any level of scope:

```

 let list1 = [ 1; 2; 3]
 let sumPlus x =
 // OK: inner list1 hides the outer list1.
    let list1 = [1; 5; 10]  
    x + List.sum list1
```

    
#### CAPS_PARAMETERS_MD
Names of parameters are listed after the function name. You can specify a type for a parameter, as shown in the following example:


```f#
let f (x : int) = x + 1
```
If you specify a type, it follows the name of the parameter and is separated from the name by a colon. If you omit the type for the parameter, the parameter type is inferred by the compiler. For example, in the following function definition, the argument **x** is inferred to be of type **int** because 1 is of type **int**.


```f#
let f x = x + 1
```
However, the compiler will attempt to make the function as generic as possible. For example, note the following code:


```f#
let f x = (x, x)
```
The function creates a tuple from one argument of any type. Because the type is not specified, the function can be used with any argument type. For more information, see [Automatic Generalization &#40;F&#35;&#41;](Automatic+Generalization+%28F%23%29.md).


## Function Bodies
A function body can contain definitions of local variables and functions. Such variables and functions are in scope in the body of the current function but not outside it. When you have the lightweight syntax option enabled, you must use indentation to indicate that a definition is in a function body, as shown in the following example:

```

 let cylinderVolume radius length =
     // Define a local value pi.
     let pi = 3.14159
     length * pi * radius * radius
```

    For more information, see [Code Formatting Guidelines &#40;F&#35;&#41;](Code+Formatting+Guidelines+%28F%23%29.md) and [Verbose Syntax &#40;F&#35;&#41;](Verbose+Syntax+%28F%23%29.md).


## Return Values
The compiler uses the final expression in a function body to determine the return value and type. The compiler might infer the type of the final expression from previous expressions. In the function **cylinderVolume**, shown in the previous section, the type of **pi** is determined from the type of the literal **3.14159** to be **float**. The compiler uses the type of **pi** to determine the type of the expression **h &#42; pi &#42; r &#42; r** to be **float**. Therefore, the overall return type of the function is **float**.

To specify the return value explicitly, write the code as follows:

```


 let cylinderVolume radius length : float =
    // Define a local value pi.
    let pi = 3.14159
    length * pi * radius * radius
```

    As the code is written above, the compiler applies **float** to the entire function; if you mean to apply it to the parameter types as well, use the following code:


```f#
let cylinderVolume (radius : float) (length : float) : float
```

## Calling a Function
You call functions by specifying the function name followed by a space and then any arguments separated by spaces. For example, to call the function **cylinderVolume** and assign the result to the value **vol**, you write the following code:


```f#
let vol = cylinderVolume 2.0 3.0
```

## Partial Application of Arguments
If you supply fewer than the specified number of arguments, you create a new function that expects the remaining arguments. This method of handling arguments is referred to as *currying* and is a characteristic of functional programming languages like F#. For example, suppose you are working with two sizes of pipe: one has a radius of **2.0** and the other has a radius of **3.0**. You could create functions that determine the volume of pipe as follows:

```

 let smallPipeRadius = 2.0
 let bigPipeRadius = 3.0

 // These define functions that take the length as a remaining
 // argument:

 let smallPipeVolume = cylinderVolume smallPipeRadius
 let bigPipeVolume = cylinderVolume bigPipeRadius
```

    You would then supply the additional argument as needed for various lengths of pipe of the two different sizes:

```

 let length1 = 30.0
 let length2 = 40.0
 let smallPipeVol1 = smallPipeVolume length1
 let smallPipeVol2 = smallPipeVolume length2
 let bigPipeVol1 = bigPipeVolume length1
 let bigPipeVol2 = bigPipeVolume length2
```

    
## Recursive Functions
*Recursive functions* are functions that call themselves. They require that you specify the **rec** keyword following the **let** keyword. Invoke the recursive function from within the body of the function just as you would invoke any function call. The following recursive function computes the *n*th Fibonacci number. The Fibonacci number sequence has been known since antiquity and is a sequence in which each successive number is the sum of the previous two numbers in the sequence.

```

 let rec fib n = if n < 2 then 1 else fib (n - 1) + fib (n - 2)
```

    Some recursive functions might overflow the program stack or perform inefficiently if you do not write them with care and with awareness of special techniques, such as the use of accumulators and continuations.


## Function Values
In F#, all functions are considered values; in fact, they are known as *function values*. Because functions are values, they can be used as arguments to other functions or in other contexts where values are used. Following is an example of a function that takes a function value as an argument:

```

 let apply1 (transform : int -> int ) y = transform y
```

    You specify the type of a function value by using the **-&gt;** token. On the left side of this token is the type of the argument, and on the right side is the return value. In the previous example, **apply1** is a function that takes a function **transform** as an argument, where **transform** is a function that takes an integer and returns another integer. The following code shows how to use **apply1**:

```

 let increment x = x + 1

 let result1 = apply1 increment 100
```

    The value of **result** will be 101 after the previous code runs.

Multiple arguments are separated by successive **-&gt;** tokens, as shown in the following example:

```

 let apply2 ( f: int -> int -> int) x y = f x y

 let mul x y = x * y
  
 let result2 = apply2 mul 10 20
```

    The result is 200.


## Lambda Expressions
A *lambda expression* is an unnamed function. In the previous examples, instead of defining named functions **increment** and **mul**, you could use lambda expressions as follows:

```

 let result3 = apply1 (fun x -> x + 1) 100

 let result4 = apply2 (fun x y -> x * y ) 10 20
```

    You define lambda expressions by using the **fun** keyword. A lambda expression resembles a function definition, except that instead of the **=** token, the **-&gt;** token is used to separate the argument list from the function body. As in a regular function definition, the argument types can be inferred or specified explicitly, and the return type of the lambda expression is inferred from the type of the last expression in the body. For more information, see [Lambda Expressions: The fun Keyword &#40;F&#35;&#41;](Lambda+Expressions+-+The+fun+Keyword+%28F%23%29.md).


## Function Composition and Pipelining
Functions in F# can be composed from other functions. The composition of two functions **function1** and **function2** is another function that represents the application of **function1** followed the application of **function2**:

```

 let function1 x = x + 1
 let function2 x = x * 2
 let h = function1 >> function2
 let result5 = h 100
```

    The result is 202.

Pipelining enables function calls to be chained together as successive operations. Pipelining works as follows:


```f#
let result = 100 |> function1 |> function2
```
The result is again 202.

The composition operators take two functions and return a function; by contrast, the pipeline operators take a function and an argument and return a value. The following code example shows the difference between the pipeline and composition operators by showing the differences in the function signatures and usage.


```f#
// Function composition and pipeline operators compared.

let addOne x = x + 1
let timesTwo x = 2 * x

// Composition operator
// ( >> ) : ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3
let Compose2 = addOne >> timesTwo

// Backward composition operator
// ( << ) : ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3
let Compose1 = addOne << timesTwo

// Result is 5
let result1 = Compose1 2

// Result is 6
let result2 = Compose2 2

// Pipelining
// Pipeline operator
// ( <| ) : ('T -> 'U) -> 'T -> 'U
let Pipeline1 x = addOne <| timesTwo x

// Backward pipeline operator
// ( |> ) : 'T1 -> ('T1 -> 'U) -> 'U
let Pipeline2 x = addOne x |> timesTwo

// Result is 5
let result3 = Pipeline1 2

// Result is 6
let result4 = Pipeline2 2
```

## Overloading Functions
You can overload methods of a type but not functions. For more information, see [Methods &#40;F&#35;&#41;](Methods+%28F%23%29.md).


## See Also
[Values &#40;F&#35;&#41;](Values+%28F%23%29.md)

[F&#35; Language Reference](F%23+Language+Reference.md)

