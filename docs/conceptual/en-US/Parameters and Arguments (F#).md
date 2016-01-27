# Parameters and Arguments (F#)

This topic describes language support for defining parameters and passing arguments to functions, methods, and properties. It includes information about how to pass by reference, and how to define and use methods that can take a variable number of arguments.


## Parameters and Arguments
The term *parameter* is used to describe the names for values that are expected to be supplied. The term *argument* is used for the values provided for each parameter.

Parameters can be specified in tuple or curried form, or in some combination of the two. You can pass arguments by using an explicit parameter name. Parameters of methods can be specified as optional and given a default value.


## Parameter Patterns
Parameters supplied to functions and methods are, in general, patterns separated by spaces. This means that, in principle, any of the patterns described in [Match Expressions &#40;F&#35;&#41;](Match+Expressions+%28F%23%29.md) can be used in a parameter list for a function or member.

Methods usually use the tuple form of passing arguments. This achieves a clearer result from the perspective of other .NET languages because the tuple form matches the way arguments are passed in .NET methods.

The curried form is most often used with functions created by using **let** bindings.

The following pseudocode shows examples of tuple and curried arguments.


```f#
// Tuple form.
member this.SomeMethod(param1, param2) = ...
// Curried form.
let function1 param1 param2 = ...
```
Combined forms are possible when some arguments are in tuples and some are not.


```f#
let function2 param1 (param2a, param2b) param3 = ...
```
Other patterns can also be used in parameter lists, but if the parameter pattern does not match all possible inputs, there might be an incomplete match at run time. The exception **MatchFailureException** is generated when the value of an argument does not match the patterns specified in the parameter list. The compiler issues a warning when a parameter pattern allows for incomplete matches. At least one other pattern is commonly useful for parameter lists, and that is the wildcard pattern. You use the wildcard pattern in a parameter list when you simply want to ignore any arguments that are supplied. The following code illustrates the use of the wildcard pattern in an argument list.

```

let makeList _ = [ for i in 1 .. 100 -> i * i ]
// The arguments 100 and 200 are ignored.
let list1 = makeList 100
let list2 = makeList 200
```

    The wildcard pattern can be useful whenever you do not need the arguments passed in, such as in the main entry point to a program, when you are not interested in the command-line arguments that are normally supplied as a string array, as in the following code.

```

[<EntryPoint>]
let main _ =
    printfn "Entry point!"
    0
```

    Other patterns that are sometimes used in arguments are the **as** pattern, and identifier patterns associated with discriminated unions and active patterns. You can use the single-case discriminated union pattern as follows.

```

type Slice = Slice of int * int * string

let GetSubstring1 (Slice(p0, p1, text)) = 
    printfn "Data begins at %d and ends at %d in string %s" p0 p1 text
    text.[p0..p1]

let substring = GetSubstring1 (Slice(0, 4, "Et tu, Brute?"))
printfn "Substring: %s" substring
```

    The output is as follows.


```
Data begins at 0 and ends at 4 in string Et tu, Brute?
Et tu
```
Active patterns can be useful as parameters, for example, when transforming an argument into a desired format, as in the following example:


```
type Point = { x : float; y : float }
let (| Polar |) { x = x; y = y} =
( sqrt (x*x + y*y), System.Math.Atan (y/ x) )

let radius (Polar(r, _)) = r
let angle (Polar(_, theta)) = theta
```
You can use the **as** pattern to store a matched value as a local value, as is shown in the following line of code.

```

let GetSubstring2 (Slice(p0, p1, text) as s) = s
```

    Another pattern that is used occasionally is a function that leaves the last argument unnamed by providing, as the body of the function, a lambda expression that immediately performs a pattern match on the implicit argument. An example of this is the following line of code.

```

let isNil = function [] -> true | _::_ -> false
```

    This code defines a function that takes a generic list and returns **true** if the list is empty, and **false** otherwise. The use of such techniques can make code more difficult to read.

Occasionally, patterns that involve incomplete matches are useful, for example, if you know that the lists in your program have only three elements, you might use a pattern like the following in a parameter list.

```

let sum [a; b; c;] = a + b + c
```

    The use of patterns that have incomplete matches is best reserved for quick prototyping and other temporary uses. The compiler will issue a warning for such code. Such patterns cannot cover the general case of all possible inputs and therefore are not suitable for component APIs.


## Named Arguments
Arguments for methods can be specified by position in a comma-separated argument list, or they can be passed to a method explicitly by providing the name, followed by an equal sign and the value to be passed in. If specified by providing the name, they can appear in a different order from that used in the declaration.

Named arguments can make code more readable and more adaptable to certain types of changes in the API, such as a reordering of method parameters.

Named arguments are allowed only for methods, not for **let**-bound functions, function values, or lambda expressions.

The following code example demonstrates the use of named arguments.

```

type SpeedingTicket() =
    member this.GetMPHOver(speed: int, limit: int) = speed - limit
   
let CalculateFine (ticket : SpeedingTicket) =
    let delta = ticket.GetMPHOver(limit = 55, speed = 70)
    if delta < 20 then 50.0 else 100.0

let ticket1 : SpeedingTicket = SpeedingTicket()
printfn "%f" (CalculateFine ticket1)
```

    In a call to a class constructor, you can set the values of properties of the class by using a syntax similar to that of named arguments. The following example shows this syntax.

```

  type Account() =
     let mutable balance = 0.0
     let mutable number = 0
     let mutable firstName = ""
     let mutable lastName = ""
     member this.AccountNumber
        with get() = number
        and set(value) = number <- value
     member this.FirstName
        with get() = firstName
        and set(value) = firstName <- value
     member this.LastName
        with get() = lastName
        and set(value) = lastName <- value
     member this.Balance
        with get() = balance
        and set(value) = balance <- value
     member this.Deposit(amount: float) = this.Balance <- this.Balance + amount
     member this.Withdraw(amount: float) = this.Balance <- this.Balance - amount
    
   
 let account1 = new Account(AccountNumber=8782108, 
                            FirstName="Darren", LastName="Parker",
                            Balance=1543.33)
```

    For more information, see [Constructors (F#)](http://msdn.microsoft.com/en-us/library/2cd0ed07-d214-4125-8317-4f288af99f05).


## Optional Parameters
You can specify an optional parameter for a method by using a question mark in front of the parameter name. Optional parameters are interpreted as the F# option type, so you can query them in the regular way that option types are queried, by using a **match** expression with **Some** and **None**. Optional parameters are permitted only on members, not on functions created by using **let** bindings.

You can also use a function **defaultArg**, which sets a default value of an optional argument. The **defaultArg** function takes the optional parameter as the first argument and the default value as the second.

The following example illustrates the use of optional parameters.

```

type DuplexType =
    | Full
    | Half

type Connection(?rate0 : int, ?duplex0 : DuplexType, ?parity0 : bool) =
    let duplex = defaultArg duplex0 Full
    let parity = defaultArg parity0 false
    let mutable rate = match rate0 with
                        | Some rate1 -> rate1
                        | None -> match duplex with
                                  | Full -> 9600
                                  | Half -> 4800
    do printfn "Baud Rate: %d Duplex: %A Parity: %b" rate duplex parity
   
let conn1 = Connection(duplex0 = Full)
let conn2 = Connection(duplex0 = Half)
let conn3 = Connection(300, Half, true)
```

    The output is as follows.


```
Baud Rate: 9600 Duplex: Full Parity: false
Baud Rate: 4800 Duplex: Half Parity: false
Baud Rate: 300 Duplex: Half Parity: true
```

## Passing by Reference
F# supports the **byref** keyword, which specifies that a parameter is passed by reference. This means that any changes to the value are retained after the execution of the function. Values provided to a **byref** parameter must be mutable. Alternatively, you can pass reference cells of the appropriate type.

Passing by reference in .NET languages evolved as a way to return more than one value from a function. In F#, you can return a tuple for this purpose, or use a mutable reference cell as a parameter. The **byref** parameter is mainly provided for interoperability with .NET libraries.

The following examples illustrate the use of the **byref** keyword. Note that when you use a reference cell as a parameter, you must create a reference cell as a named value and use that as the parameter, not just add the **ref** operator as shown in the first call to **Increment** in the following code. Because creating a reference cell creates a copy of the underlying value, the first call just increments a temporary value.

```

type Incrementor(z) =
    member this.Increment(i : int byref) =
       i <- i + z

let incrementor = new Incrementor(1)
let mutable x = 10
// Not recommended: Does not actually increment the variable.
incrementor.Increment(ref x)
// Prints 10.
printfn "%d" x  

let mutable y = 10
incrementor.Increment(&y)
// Prints 11.
printfn "%d" y 

let refInt = ref 10
incrementor.Increment(refInt)
// Prints 11.
printfn "%d" !refInt  
```

    You can use a tuple as a return value to store any **out** parameters in .NET library methods. Alternatively, you can treat the **out** parameter as a **byref** parameter. The following code example illustrates both ways.

```

// TryParse has a second parameter that is an out parameter
// of type System.DateTime.
let (b, dt) = System.DateTime.TryParse("12-20-04 12:21:00")

printfn "%b %A" b dt

// The same call, using an address of operator.
let mutable dt2 = System.DateTime.Now
let b2 = System.DateTime.TryParse("12-20-04 12:21:00", &dt2)

printfn "%b %A" b2 dt2
```

    
## Parameter Arrays
Occasionally it is necessary to define a function that takes an arbitrary number of parameters of heterogeneous type. It would not be practical to create all the possible overloaded methods to account for all the types that could be used. The .NET platform provides support for such methods through the parameter array feature. A method that takes a parameter array in its signature can be provided with an arbitrary number of parameters. The parameters are put into an array. The type of the array elements determines the parameter types that can be passed to the function. If you define the parameter array with **T:System.Object** as the element type, then client code can pass values of any type.

In F#, parameter arrays can only be defined in methods. They cannot be used in standalone functions or functions that are defined in modules.

You define a parameter array by using the ParamArray attribute. The ParamArray attribute can only be applied to the last parameter.

The following code illustrates both calling a .NET method that takes a parameter array and the definition of a type in F# that has a method that takes a parameter array.

```

open System
       
type X() =
    member this.F([<ParamArray>] args: Object[]) =
        for arg in args do
            printfn "%A" arg

[<EntryPoint>]
let main _ =
    // call a .NET method that takes a parameter array, passing values of various types
    Console.WriteLine("a {0} {1} {2} {3} {4}", 1, 10.0, "Hello world", 1u, true)

    let xobj = new X()
    // call an F# method that takes a parameter array, passing values of various types
    xobj.F("a", 1, 10.0, "Hello world", 1u, true)
    0
```

    When run in a project, the output of the previous code is as follows:


```
a 1 10 Hello world 1 True
"a"
1
10.0
"Hello world"
1u
true
```

## See Also
[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

