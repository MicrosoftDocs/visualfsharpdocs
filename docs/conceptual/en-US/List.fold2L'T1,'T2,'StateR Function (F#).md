# List.fold2<'T1,'T2,'State> Function (F#)

Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is **f** and the elements are **i0...iN** and **j0...jN** then computes **f (... (f s i0 j0)...) iN jN**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.fold2 : ('State -> 'T1 -> 'T2 -> 'State) -> 'State -> 'T1 list -> 'T2 list -> 'State

// Usage:
List.fold2 folder state list1 list2


```



#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T1 -&gt; 'T2 -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**The final state value.****exceptions tag is not supported!!!!**

## CAPS_REMARKS_MD
This function is named **Fold2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.fold2.**


```



    // Use List.fold2 to perform computations over two lists (of equal size) at the same time.
    // Example: Sum the greater element at each list position.
    let sumGreatest list1 list2 = List.fold2 (fun acc elem1 elem2 ->
                                                  acc + max elem1 elem2) 0 list1 list2

    let sum = sumGreatest [1; 2; 3] [3; 2; 1]
    printfn "The sum of the greater of each pair of elements in the two lists is %d." sum


```



**Output**
**The sum of the greater of each pair of elements in the two lists is 8.****The following code example illustrates the use of List.fold2 to compute the ending balance in a bank account after a series of transactions. The two input lists represent the transaction type (deposit or withdrawal) and the transaction amount.**


```



// Discriminated union type that encodes the transaction type.
type Transaction =
    | Deposit
    | Withdrawal

let transactionTypes = [Deposit; Deposit; Withdrawal]
let transactionAmounts = [100.00; 1000.00; 95.00 ]
let initialBalance = 200.00

// Use fold2 to perform a calculation on the list to update the account balance.
let endingBalance = List.fold2 (fun acc elem1 elem2 ->
                                match elem1 with
                                | Deposit -> acc + elem2
                                | Withdrawal -> acc - elem2)
                                initialBalance
                                transactionTypes
                                transactionAmounts
printfn "%f" endingBalance


```



**Output**
**1205.000000**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

