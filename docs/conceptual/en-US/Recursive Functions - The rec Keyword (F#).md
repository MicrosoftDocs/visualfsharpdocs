# Recursive Functions: The rec Keyword (F#)

The **rec** keyword is used together with the **let** keyword to define a recursive function.


## CAPS_SYNTAX_MD



```


// Recursive function:
let rec function-nameparameter-list = 
function-body

// Mutually recursive functions:
let rec function1-nameparameter-list =
function1-body
and function2-nameparameter-list =
function2-body
...


```



## CAPS_REMARKS_MD
Recursive functions, functions that call themselves, are identified explicitly in the F# language. This makes the identifer that is being defined available in the scope of the function.

The following code illustrates a recursive function that computes the *n*th Fibonacci number.



```



let rec fib n =
   if n <= 2 then 1
   else fib (n - 1) + fib (n - 2)


```



    
>[!NOTE] {In practice, code like that above is wasteful of memory and processor time because it involves the recomputation of previously computed values.

}
Methods are implicitly recursive within the type; there is no need to add the **rec** keyword. Let bindings within classes are not implicitly recursive.


## Mutually Recursive Functions
Sometimes functions are *mutually recursive*, meaning that calls form a circle, where one function calls another which in turn calls the first, with any number of calls in between. You must define such functions together in the one **let** binding, using the **and** keyword to link them together.

The following example shows two mutually recursive functions.



```



let rec Even x =
   if x = 0 then true
   else Odd (x - 1)
and Odd x =
   if x = 1 then true
   else Even (x - 1)


```



    
## See Also
[Functions &#40;F&#35;&#41;](Functions+%28F%23%29.md)

