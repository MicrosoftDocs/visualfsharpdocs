# Functions as First-Class Values (F#)

A defining characteristic of functional programming languages is the elevation of functions to first-class status. You should be able to do with a function whatever you can do with values of the other built-in types, and be able to do so with a comparable degree of effort.

Typical measures of first-class status include the following:


- Can you bind an identifier to the value? That is, can you give it a name?
<br />

- Can you store the value in a data structure, such as a list?
<br />

- Can you pass the value as an argument in a function call?
<br />

- Can you return the value as the value of a function call?
<br />

The last two measures define what are known as *higher-order operations* or *higher-order functions*. Higher-order functions accept functions as arguments and return functions as the value of function calls. These operations support such mainstays of functional programming as mapping functions and composition of functions.


## Give the Value a Name
If a function is a first-class value, you must be able to name it, just as you can name integers, strings, and other built-in types. This is referred to in functional programming literature as binding an identifier to a value. F# uses [let expressions](http://msdn.microsoft.com/en-us/library/c3b2cc64-04e1-4366-bfba-e8c71b96d86c) to bind names to values: **let &lt;identifier&gt; = &lt;value&gt;**. The following code shows two examples.



```



// Integer and string.
let num = 10
let str = "F#"


```



    You can name a function just as easily. The following example defines a function named **squareIt** by binding the identifier **squareIt** to the [lambda expression](http://msdn.microsoft.com/en-us/library/556283bc-c82d-4cb5-b20a-d24b346b619d)**fun n -&gt; n &#42; n**. Function **squareIt** has one parameter, **n**, and it returns the square of that parameter.



```



let squareIt = fun n -> n * n


```



    F# provides the following more concise syntax to achieve the same result with less typing.



```



let squareIt2 n = n * n


```



    The examples that follow mostly use the first style, **let &lt;function-name&gt; = &lt;lambda-expression&gt;**, to emphasize the similarities between the declaration of functions and the declaration of other types of values. However, all the named functions can also be written with the concise syntax. Some of the examples are written in both ways.


## Store the Value in a Data Structure
A first-class value can be stored in a data structure. The following code shows examples that store values in lists and in tuples.



```



// Lists.

// Storing integers and strings.
let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
let stringList = [ "one"; "two"; "three" ]

// You cannot mix types in a list. The following declaration causes a 
// type-mismatch compiler error.
//let failedList = [ 5; "six" ]

// In F#, functions can be stored in a list, as long as the functions 
// have the same signature.

// Function doubleIt has the same signature as squareIt, declared previously.
//let squareIt = fun n -> n * n
let doubleIt = fun n -> 2 * n

// Functions squareIt and doubleIt can be stored together in a list.
let funList = [ squareIt; doubleIt ]

// Function squareIt cannot be stored in a list together with a function
// that has a different signature, such as the following body mass 
// index (BMI) calculator.
let BMICalculator = fun ht wt -> 
                    (float wt / float (squareIt ht)) * 703.0

// The following expression causes a type-mismatch compiler error.
//let failedFunList = [ squareIt; BMICalculator ]


// Tuples.

// Integers and strings.
let integerTuple = ( 1, -7 )
let stringTuple = ( "one", "two", "three" )

// A tuple does not require its elements to be of the same type.
let mixedTuple = ( 1, "two", 3.3 )

// Similarly, function elements in tuples can have different signatures.
let funTuple = ( squareIt, BMICalculator )

// Functions can be mixed with integers, strings, and other types in
// a tuple. Identifier num was declared previously.
//let num = 10
let moreMixedTuple = ( num, "two", 3.3, squareIt )


```



    To verify that a function name stored in a tuple does in fact evaluate to a function, the following example uses the **fst** and **snd** operators to extract the first and second elements from tuple **funAndArgTuple**. The first element in the tuple is **squareIt** and the second element is **num**. Identifier **num** is bound in a previous example to integer 10, a valid argument for the **squareIt** function. The second expression applies the first element in the tuple to the second element in the tuple: **squareIt num**.



```



// You can pull a function out of a tuple and apply it. Both squareIt and num
// were defined previously.
let funAndArgTuple = (squareIt, num)

// The following expression applies squareIt to num, returns 100, and 
// then displays 100.
System.Console.WriteLine((fst funAndArgTuple)(snd funAndArgTuple))


```



    Similarly, just as identifier **num** and integer 10 can be used interchangeably, so can identifier **squareIt** and lambda expression **fun n -&gt; n &#42; n**.



```



// Make a list of values instead of identifiers.
let funAndArgTuple2 = ((fun n -> n * n), 10)

// The following expression applies a squaring function to 10, returns
// 100, and then displays 100.
System.Console.WriteLine((fst funAndArgTuple2)(snd funAndArgTuple2))


```



    
## Pass the Value as an Argument
If a value has first-class status in a language, you can pass it as an argument to a function. For example, it is common to pass integers and strings as arguments. The following code shows integers and strings passed as arguments in F#.



```



// An integer is passed to squareIt. Both squareIt and num are defined in 
// previous examples.
//let num = 10
//let squareIt = fun n -> n * n
System.Console.WriteLine(squareIt num)

// String.
// Function repeatString concatenates a string with itself.
let repeatString = fun s -> s + s

// A string is passed to repeatString. HelloHello is returned and displayed.
let greeting = "Hello"
System.Console.WriteLine(repeatString greeting)


```



    If functions have first-class status, you must be able to pass them as arguments in the same way. Remember that this is the first characteristic of higher-order functions.

In the following example, function **applyIt** has two parameters, **op** and **arg**. If you send in a function that has one parameter for **op** and an appropriate argument for the function to **arg**, the function returns the result of applying **op** to **arg**. In the following example, both the function argument and the integer argument are sent in the same way, by using their names.



```



// Define the function, again using lambda expression syntax.
let applyIt = fun op arg -> op arg

// Send squareIt for the function, op, and num for the argument you want to 
// apply squareIt to, arg. Both squareIt and num are defined in previous 
// examples. The result returned and displayed is 100.
System.Console.WriteLine(applyIt squareIt num)

// The following expression shows the concise syntax for the previous function
// definition.
let applyIt2 op arg = op arg
// The following line also displays 100.
System.Console.WriteLine(applyIt2 squareIt num)


```



    The ability to send a function as an argument to another function underlies common abstractions in functional programming languages, such as map or filter operations. A map operation, for example, is a higher-order function that captures the computation shared by functions that step through a list, do something to each element, and then return a list of the results. You might want to increment each element in a list of integers, or to square each element, or to change each element in a list of strings to uppercase. The error-prone part of the computation is the recursive process that steps through the list and builds a list of the results to return. That part is captured in the mapping function. All you have to write for a particular application is the function that you want to apply to each list element individually (adding, squaring, changing case). That function is sent as an argument to the mapping function, just as **squareIt** is sent to **applyIt** in the previous example.

F# provides map methods for most collection types, including [lists](http://msdn.microsoft.com/en-us/library/a2264ba3-2d45-40dd-9040-4f7aa2ad9788), [arrays](http://msdn.microsoft.com/en-us/library/0cda8040-9396-40dd-8dcd-cf48542165a1), and [sets](http://msdn.microsoft.com/en-us/library/61efa732-d55d-4c32-993f-628e2f98e6a0). The following examples use lists. The syntax is **List.map &lt;the function&gt; &lt;the list&gt;**.



```



// List integerList was defined previously:
//let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]

// You can send the function argument by name, if an appropriate function
// is available. The following expression uses squareIt.
let squareAll = List.map squareIt integerList

// The following line displays [1; 4; 9; 16; 25; 36; 49]
printfn "%A" squareAll

// Or you can define the action to apply to each list element inline.
// For example, no function that tests for even integers has been defined,
// so the following expression defines the appropriate function inline.
// The function returns true if n is even; otherwise it returns false.
let evenOrNot = List.map (fun n -> n % 2 = 0) integerList

// The following line displays [false; true; false; true; false; true; false]
printfn "%A" evenOrNot


```



    For more information, see [Lists &#40;F&#35;&#41;](Lists+%28F%23%29.md).


## Return the Value from a Function Call
Finally, if a function has first-class status in a language, you must be able to return it as the value of a function call, just as you return other types, such as integers and strings.

The following function calls return integers and display them.



```



// Function doubleIt is defined in a previous example.
//let doubleIt = fun n -> 2 * n
System.Console.WriteLine(doubleIt 3)
System.Console.WriteLine(squareIt 4)


```



    The following function call returns a string.



```



// str is defined in a previous section.
//let str = "F#"
let lowercase = str.ToLower()


```



    The following function call, declared inline, returns a Boolean value. The value displayed is **True**.



```



System.Console.WriteLine((fun n -> n % 2 = 1) 15)


```



    The ability to return a function as the value of a function call is the second characteristic of higher-order functions. In the following example, **checkFor** is defined to be a function that takes one argument, **item**, and returns a new function as its value. The returned function takes a list as its argument, **lst**, and searches for **item** in **lst**. If **item** is present, the function returns **true**. If **item** is not present, the function returns **false**. As in the previous section, the following code uses a provided list function, [List.exists](http://msdn.microsoft.com/en-us/library/15a3ebd5-98f0-44c0-8220-7dedec3e68a8), to search the list.



```



let checkFor item = 
    let functionToReturn = fun lst ->
                           List.exists (fun a -> a = item) lst
    functionToReturn


```



    The following code uses **checkFor** to create a new function that takes one argument, a list, and searches for 7 in the list.



```



// integerList and stringList were defined earlier.
//let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
//let stringList = [ "one"; "two"; "three" ]

// The returned function is given the name checkFor7. 
let checkFor7 = checkFor 7

// The result displayed when checkFor7 is applied to integerList is True.
System.Console.WriteLine(checkFor7 integerList)

// The following code repeats the process for "seven" in stringList.
let checkForSeven = checkFor "seven"

// The result displayed is False.
System.Console.WriteLine(checkForSeven stringList)


```



    The following example uses the first-class status of functions in F# to declare a function, **compose**, that returns a composition of two function arguments.



```



// Function compose takes two arguments. Each argument is a function 
// that takes one argument of the same type. The following declaration
// uses lambda expresson syntax.
let compose = 
    fun op1 op2 ->
        fun n ->
            op1 (op2 n)

// To clarify what you are returning, use a nested let expression:
let compose2 = 
    fun op1 op2 ->
        // Use a let expression to build the function that will be returned.
        let funToReturn = fun n ->
                            op1 (op2 n)
        // Then just return it.
        funToReturn

// Or, integrating the more concise syntax:
let compose3 op1 op2 =
    let funToReturn = fun n ->
                        op1 (op2 n)
    funToReturn


```



    
>[!NOTE] {For an even shorter version, see the following section, "Curried Functions."

}
The following code sends two functions as arguments to **compose**, both of which take a single argument of the same type. The return value is a new function that is a composition of the two function arguments.



```



// Functions squareIt and doubleIt were defined in a previous example.
let doubleAndSquare = compose squareIt doubleIt
// The following expression doubles 3, squares 6, and returns and
// displays 36.
System.Console.WriteLine(doubleAndSquare 3)

let squareAndDouble = compose doubleIt squareIt
// The following expression squares 3, doubles 9, returns 18, and
// then displays 18.
System.Console.WriteLine(squareAndDouble 3)


```



    
>[!NOTE] {F# provides two operators, **&lt;&lt;** and **&gt;&gt;**, that compose functions. For example, **let squareAndDouble2 = doubleIt &lt;&lt; squareIt** is equivalent to **let squareAndDouble = compose doubleIt squareIt** in the previous example.

}
The following example of returning a function as the value of a function call creates a simple guessing game. To create a game, call **makeGame** with the value that you want someone to guess sent in for **target**. The return value from function **makeGame** is a function that takes one argument (the guess) and reports whether the guess is correct.



```



let makeGame target = 
    // Build a lambda expression that is the function that plays the game.
    let game = fun guess -> 
                   if guess = target then
                      System.Console.WriteLine("You win!")
                   else 
                      System.Console.WriteLine("Wrong. Try again.")
    // Now just return it.
    game


```



    The following code calls **makeGame**, sending the value **7** for **target**. Identifier **playGame** is bound to the returned lambda expression. Therefore, **playGame** is a function that takes as its one argument a value for **guess**.



```



let playGame = makeGame 7
// Send in some guesses.
playGame 2
playGame 9
playGame 7

// Output:
// Wrong. Try again.
// Wrong. Try again.
// You win!

// The following game specifies a character instead of an integer for target. 
let alphaGame = makeGame 'q'
alphaGame 'c'
alphaGame 'r'
alphaGame 'j'
alphaGame 'q'

// Output:
// Wrong. Try again.
// Wrong. Try again.
// Wrong. Try again.
// You win!


```



    
## Curried Functions
Many of the examples in the previous section can be written more concisely by taking advantage of the implicit *currying* in F# function declarations. Currying is a process that transforms a function that has more than one parameter into a series of embedded functions, each of which has a single parameter. In F#, functions that have more than one parameter are inherently curried. For example, **compose** from the previous section can be written as shown in the following concise style, with three parameters.



```



let compose4 op1 op2 n = op1 (op2 n)


```



    However, the result is a function of one parameter that returns a function of one parameter that in turn returns another function of one parameter, as shown in **compose4curried**.



```



let compose4curried =
    fun op1 ->
        fun op2 ->
            fun n -> op1 (op2 n)


```



    You can access this function in several ways. Each of the following examples returns and displays 18. You can replace **compose4** with **compose4curried** in any of the examples.



```



// Access one layer at a time.
System.Console.WriteLine(((compose4 doubleIt) squareIt) 3)

// Access as in the original compose examples, sending arguments for 
// op1 and op2, then applying the resulting function to a value.
System.Console.WriteLine((compose4 doubleIt squareIt) 3)

// Access by sending all three arguments at the same time.
System.Console.WriteLine(compose4 doubleIt squareIt 3)


```



    To verify that the function still works as it did before, try the original test cases again.



```



let doubleAndSquare4 = compose4 squareIt doubleIt
// The following expression returns and displays 36.
System.Console.WriteLine(doubleAndSquare4 3)

let squareAndDouble4 = compose4 doubleIt squareIt
// The following expression returns and displays 18.
System.Console.WriteLine(squareAndDouble4 3)


```



    
>[!NOTE] {You can restrict currying by enclosing parameters in tuples. For more information, see "Parameter Patterns" in [Parameters and Arguments &#40;F&#35;&#41;](Parameters+and+Arguments+%28F%23%29.md).

}
The following example uses implicit currying to write a shorter version of **makeGame**. The details of how **makeGame** constructs and returns the **game** function are less explicit in this format, but you can verify by using the original test cases that the result is the same.



```



let makeGame2 target guess =
    if guess = target then
       System.Console.WriteLine("You win!")
    else 
       System.Console.WriteLine("Wrong. Try again.")
        
let playGame2 = makeGame2 7
playGame2 2
playGame2 9
playGame2 7

let alphaGame2 = makeGame2 'q'
alphaGame2 'c'
alphaGame2 'r'
alphaGame2 'j'
alphaGame2 'q'


```



    For more information about currying, see "Partial Application of Arguments" in [Functions &#40;F&#35;&#41;](Functions+%28F%23%29.md).


## Identifier and Function Definition Are Interchangeable
The variable name **num** in the previous examples evaluates to the integer 10, and it is no surprise that where **num** is valid, 10 is also valid. The same is true of function identifiers and their values: anywhere the name of the function can be used, the lambda expression to which it is bound can be used.

The following example defines a **Boolean** function called **isNegative**, and then uses the name of the function and the definition of the function interchangeably. The next three examples all return and display **False**.



```



let isNegative = fun n -> n < 0

// This example uses the names of the function argument and the integer
// argument. Identifier num is defined in a previous example.
//let num = 10
System.Console.WriteLine(applyIt isNegative num)

// This example substitutes the value that num is bound to for num, and the
// value that isNegative is bound to for isNegative.
System.Console.WriteLine(applyIt (fun n -> n < 0) 10) 


```



    To take it one step further, substitute the value that **applyIt** is bound to for **applyIt**.



```



System.Console.WriteLine((fun op arg -> op arg) (fun n -> n < 0)  10)


```



    
## Functions Are First-Class Values in F#
The examples in the previous sections demonstrate that functions in F# satisfy the criteria for being first-class values in F#:


- You can bind an identifier to a function definition.


```



let squareIt = fun n -> n * n


```




- You can store a function in a data structure.


```



let funTuple2 = ( BMICalculator, fun n -> n * n )


```




- You can pass a function as an argument.


```



let increments = List.map (fun n -> n + 1) [ 1; 2; 3; 4; 5; 6; 7 ]


```




- You can return a function as the value of a function call.


```



let checkFor item = 
    let functionToReturn = fun lst ->
                           List.exists (fun a -> a = item) lst
    functionToReturn


```




For more information about F#, see [F&#35; Language Reference](F%23+Language+Reference.md).


## Example

### Description
The following code contains all the examples in this topic.


### Code


```




// ** GIVE THE VALUE A NAME **


// Integer and string.
let num = 10
let str = "F#"



let squareIt = fun n -> n * n



let squareIt2 n = n * n



// ** STORE THE VALUE IN A DATA STRUCTURE **


// Lists.

// Storing integers and strings.
let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
let stringList = [ "one"; "two"; "three" ]

// You cannot mix types in a list. The following declaration causes a 
// type-mismatch compiler error.
//let failedList = [ 5; "six" ]

// In F#, functions can be stored in a list, as long as the functions 
// have the same signature.

// Function doubleIt has the same signature as squareIt, declared previously.
//let squareIt = fun n -> n * n
let doubleIt = fun n -> 2 * n

// Functions squareIt and doubleIt can be stored together in a list.
let funList = [ squareIt; doubleIt ]

// Function squareIt cannot be stored in a list together with a function
// that has a different signature, such as the following body mass 
// index (BMI) calculator.
let BMICalculator = fun ht wt -> 
                    (float wt / float (squareIt ht)) * 703.0

// The following expression causes a type-mismatch compiler error.
//let failedFunList = [ squareIt; BMICalculator ]


// Tuples.

// Integers and strings.
let integerTuple = ( 1, -7 )
let stringTuple = ( "one", "two", "three" )

// A tuple does not require its elements to be of the same type.
let mixedTuple = ( 1, "two", 3.3 )

// Similarly, function elements in tuples can have different signatures.
let funTuple = ( squareIt, BMICalculator )

// Functions can be mixed with integers, strings, and other types in
// a tuple. Identifier num was declared previously.
//let num = 10
let moreMixedTuple = ( num, "two", 3.3, squareIt )



// You can pull a function out of a tuple and apply it. Both squareIt and num
// were defined previously.
let funAndArgTuple = (squareIt, num)

// The following expression applies squareIt to num, returns 100, and 
// then displays 100.
System.Console.WriteLine((fst funAndArgTuple)(snd funAndArgTuple))



// Make a list of values instead of identifiers.
let funAndArgTuple2 = ((fun n -> n * n), 10)

// The following expression applies a squaring function to 10, returns
// 100, and then displays 100.
System.Console.WriteLine((fst funAndArgTuple2)(snd funAndArgTuple2))



// ** PASS THE VALUE AS AN ARGUMENT **


// An integer is passed to squareIt. Both squareIt and num are defined in 
// previous examples.
//let num = 10
//let squareIt = fun n -> n * n
System.Console.WriteLine(squareIt num)

// String.
// Function repeatString concatenates a string with itself.
let repeatString = fun s -> s + s

// A string is passed to repeatString. HelloHello is returned and displayed.
let greeting = "Hello"
System.Console.WriteLine(repeatString greeting)



// Define the function, again using lambda expression syntax.
let applyIt = fun op arg -> op arg

// Send squareIt for the function, op, and num for the argument you want to 
// apply squareIt to, arg. Both squareIt and num are defined in previous 
// examples. The result returned and displayed is 100.
System.Console.WriteLine(applyIt squareIt num)

// The following expression shows the concise syntax for the previous function
// definition.
let applyIt2 op arg = op arg
// The following line also displays 100.
System.Console.WriteLine(applyIt2 squareIt num)



// List integerList was defined previously:
//let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]

// You can send the function argument by name, if an appropriate function
// is available. The following expression uses squareIt.
let squareAll = List.map squareIt integerList

// The following line displays [1; 4; 9; 16; 25; 36; 49]
printfn "%A" squareAll

// Or you can define the action to apply to each list element inline.
// For example, no function that tests for even integers has been defined,
// so the following expression defines the appropriate function inline.
// The function returns true if n is even; otherwise it returns false.
let evenOrNot = List.map (fun n -> n % 2 = 0) integerList

// The following line displays [false; true; false; true; false; true; false]
printfn "%A" evenOrNot



// ** RETURN THE VALUE FROM A FUNCTION CALL **


// Function doubleIt is defined in a previous example.
//let doubleIt = fun n -> 2 * n
System.Console.WriteLine(doubleIt 3)
System.Console.WriteLine(squareIt 4)


// The following function call returns a string:

// str is defined in a previous section.
//let str = "F#"
let lowercase = str.ToLower()



System.Console.WriteLine((fun n -> n % 2 = 1) 15)

 

let checkFor item = 
    let functionToReturn = fun lst ->
                           List.exists (fun a -> a = item) lst
    functionToReturn



// integerList and stringList were defined earlier.
//let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
//let stringList = [ "one"; "two"; "three" ]

// The returned function is given the name checkFor7. 
let checkFor7 = checkFor 7

// The result displayed when checkFor7 is applied to integerList is True.
System.Console.WriteLine(checkFor7 integerList)

// The following code repeats the process for "seven" in stringList.
let checkForSeven = checkFor "seven"

// The result displayed is False.
System.Console.WriteLine(checkForSeven stringList)



// Function compose takes two arguments. Each argument is a function 
// that takes one argument of the same type. The following declaration
// uses lambda expresson syntax.
let compose = 
    fun op1 op2 ->
        fun n ->
            op1 (op2 n)

// To clarify what you are returning, use a nested let expression:
let compose2 = 
    fun op1 op2 ->
        // Use a let expression to build the function that will be returned.
        let funToReturn = fun n ->
                            op1 (op2 n)
        // Then just return it.
        funToReturn

// Or, integrating the more concise syntax:
let compose3 op1 op2 =
    let funToReturn = fun n ->
                        op1 (op2 n)
    funToReturn



// Functions squareIt and doubleIt were defined in a previous example.
let doubleAndSquare = compose squareIt doubleIt
// The following expression doubles 3, squares 6, and returns and
// displays 36.
System.Console.WriteLine(doubleAndSquare 3)

let squareAndDouble = compose doubleIt squareIt
// The following expression squares 3, doubles 9, returns 18, and
// then displays 18.
System.Console.WriteLine(squareAndDouble 3)



let makeGame target = 
    // Build a lambda expression that is the function that plays the game.
    let game = fun guess -> 
                   if guess = target then
                      System.Console.WriteLine("You win!")
                   else 
                      System.Console.WriteLine("Wrong. Try again.")
    // Now just return it.
    game



let playGame = makeGame 7
// Send in some guesses.
playGame 2
playGame 9
playGame 7

// Output:
// Wrong. Try again.
// Wrong. Try again.
// You win!

// The following game specifies a character instead of an integer for target. 
let alphaGame = makeGame 'q'
alphaGame 'c'
alphaGame 'r'
alphaGame 'j'
alphaGame 'q'

// Output:
// Wrong. Try again.
// Wrong. Try again.
// Wrong. Try again.
// You win!



// ** CURRIED FUNCTIONS **


let compose4 op1 op2 n = op1 (op2 n)



let compose4curried =
    fun op1 ->
        fun op2 ->
            fun n -> op1 (op2 n)

  

// Access one layer at a time.
System.Console.WriteLine(((compose4 doubleIt) squareIt) 3)

// Access as in the original compose examples, sending arguments for 
// op1 and op2, then applying the resulting function to a value.
System.Console.WriteLine((compose4 doubleIt squareIt) 3)

// Access by sending all three arguments at the same time.
System.Console.WriteLine(compose4 doubleIt squareIt 3)



let doubleAndSquare4 = compose4 squareIt doubleIt
// The following expression returns and displays 36.
System.Console.WriteLine(doubleAndSquare4 3)

let squareAndDouble4 = compose4 doubleIt squareIt
// The following expression returns and displays 18.
System.Console.WriteLine(squareAndDouble4 3)



let makeGame2 target guess =
    if guess = target then
       System.Console.WriteLine("You win!")
    else 
       System.Console.WriteLine("Wrong. Try again.")
        
let playGame2 = makeGame2 7
playGame2 2
playGame2 9
playGame2 7

let alphaGame2 = makeGame2 'q'
alphaGame2 'c'
alphaGame2 'r'
alphaGame2 'j'
alphaGame2 'q'



// ** IDENTIFIER AND FUNCTION DEFINITION ARE INTERCHANGEABLE **


let isNegative = fun n -> n < 0

// This example uses the names of the function argument and the integer
// argument. Identifier num is defined in a previous example.
//let num = 10
System.Console.WriteLine(applyIt isNegative num)

// This example substitutes the value that num is bound to for num, and the
// value that isNegative is bound to for isNegative.
System.Console.WriteLine(applyIt (fun n -> n < 0) 10) 



System.Console.WriteLine((fun op arg -> op arg) (fun n -> n < 0)  10)



// ** FUNCTIONS ARE FIRST-CLASS VALUES IN F# **

//let squareIt = fun n -> n * n


let funTuple2 = ( BMICalculator, fun n -> n * n )



let increments = List.map (fun n -> n + 1) [ 1; 2; 3; 4; 5; 6; 7 ]


//let checkFor item = 
//    let functionToReturn = fun lst ->
//                           List.exists (fun a -> a = item) lst
//    functionToReturn


```



    
## See Also
[Lists &#40;F&#35;&#41;](Lists+%28F%23%29.md)

[Tuples &#40;F&#35;&#41;](Tuples+%28F%23%29.md)

[Functions &#40;F&#35;&#41;](Functions+%28F%23%29.md)

[let Bindings &#40;F&#35;&#41;](let+Bindings+%28F%23%29.md)

[Lambda Expressions: The fun Keyword &#40;F&#35;&#41;](Lambda+Expressions+-+The+fun+Keyword+%28F%23%29.md)

