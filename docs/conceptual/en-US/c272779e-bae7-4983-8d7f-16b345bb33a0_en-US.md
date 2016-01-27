# List.fold<'T,'State> Function (F#)

Applies a function **f** to each element of the collection, threading an accumulator argument through the computation. The **fold** function takes the second argument, and applies the function **f** to it and the first element of the list. Then, it feeds this result into the function **f** along with the second element, and so on. It returns the final result. If the input function is **f** and the elements are **i0...iN**, then this function computes **f (... (f s i0) i1 ...) iN**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.fold : ('State -> 'T -> 'State) -> 'State -> 'T list -> 'State

// Usage:
List.fold folder state list
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*list*
Type: **'T**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The input list.



**The final state value.**
## CAPS_REMARKS_MD
This function is named **Fold** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of List.fold**
```

    let data = [("Cats",4);
                ("Dogs",5);
                ("Mice",3);
                ("Elephants",2)]
    let count = List.fold (fun acc (nm,x) -> acc+x) 0 data
    printfn "Total number of animals: %d" count
```

**Total number of animals: 14****The following code example illustrates additional uses of List.fold. Note that library functions exist that already encapsulate the functionality implemented below. For example, [List.sum](http://msdn.microsoft.com/en-us/library/54d47fe3-5ecf-4883-beb5-e915342a17f9) is available to add up all the elements of a list.**
```

    let sumList list = List.fold (fun acc elem -> acc + elem) 0 list
    printfn "Sum of the elements of list %A is %d." [ 1 .. 3 ] (sumList [ 1 .. 3 ])

    // The following example computes the average of a list.
    let averageList list = (List.fold (fun acc elem -> acc + float elem) 0.0 list / float list.Length)

    // The following example computes the standard deviation of a list.
    // The standard deviation is computed by taking the square root of the
    // sum of the variances, which are the differences between each value
    // and the average.
    let stdDevList list =
        let avg = averageList list
        sqrt (List.fold (fun acc elem -> acc + (float elem - avg) ** 2.0 ) 0.0 list / float list.Length)

    let testList listTest =
        printfn "List %A average: %f stddev: %f" listTest (averageList listTest) (stdDevList listTest)

    testList [1; 1; 1]
    testList [1; 2; 1]
    testList [1; 2; 3]

    // List.fold is the same as to List.iter when the accumulator is not used.
    let printList list = List.fold (fun acc elem -> printfn "%A" elem) () list
    printList [0.0; 1.0; 2.5; 5.1 ]

    // The following example uses List.fold to reverse a list.
    // The accumulator starts out as the empty list, and the function uses the cons operator
    // to add each successive element to the head of the accumulator list, resulting in a
    // reversed form of the list.
    let reverseList list = List.fold (fun acc elem -> elem::acc) [] list
    printfn "%A" (reverseList [1 .. 10])
```

**Output**
**Sum of the elements of list [1; 2; 3] is 6.**
**List [1; 1; 1] average: 1.000000 stddev: 0.000000**
**List [1; 2; 1] average: 1.333333 stddev: 0.471405**
**List [1; 2; 3] average: 2.000000 stddev: 0.816497**
**0.0**
**1.0**
**2.5**
**5.1**
**[10; 9; 8; 7; 6; 5; 4; 3; 2; 1]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

