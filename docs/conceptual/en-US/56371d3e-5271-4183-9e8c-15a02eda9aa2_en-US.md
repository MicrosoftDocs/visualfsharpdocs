# List.foldBack2<'T1,'T2,'State> Function (F#)

Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is **f** and the elements are **i0...iN** and **j0...jN**, then this function computes **f i0 j0 (...(f iN jN s))**.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
List.foldBack2 : ('T1 -> 'T2 -> 'State -> 'State) -> 'T1 list -> 'T2 list -> 'State -> 'State

// Usage:
List.foldBack2 folder list1 list2 state
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'T1 -&gt; 'T2 -&gt; 'State -&gt; 'State**


The function to update the state given the input elements.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.


*state*
Type: **'State**


The initial state.



**The final state value.****exceptions tag is not supported!!!!**

## CAPS_REMARKS_MD
This function is named **FoldBack2** in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.

The following code examples illustrate the difference between [List.fold2](http://msdn.microsoft.com/en-us/library/6cfcd043-a65d-4423-805a-2ab234cb5343) and **List.foldBack2**.

```

type Transaction2 =
    | Deposit
    | Withdrawal
    | Interest

let transactionTypes2 = [Deposit; Deposit; Withdrawal; Interest]
let transactionAmounts2 = [100.00; 1000.00; 95.00; 0.05 / 12.0 ]
let initialBalance2 = 200.00

// Because fold2 processes the lists by starting at the head element,
// the interest is calculated last, on the balance of 1205.00.
let endingBalance2 = List.fold2 (fun acc elem1 elem2 ->
                                match elem1 with
                                | Deposit -> acc + elem2
                                | Withdrawal -> acc - elem2
                                | Interest -> acc * (1.0 + elem2))
                                initialBalance2
                                transactionTypes2
                                transactionAmounts2
printfn "%f" endingBalance2
```

**Output**
```

// Because foldBack2 processes the lists by starting at end of the list,
// the interest is calculated first, on the balance of only 200.00.
let endingBalance3 = List.foldBack2 (fun elem1 elem2 acc ->
                                match elem1 with
                                | Deposit -> acc + elem2
                                | Withdrawal -> acc - elem2
                                | Interest -> acc * (1.0 + elem2))
                                transactionTypes2
                                transactionAmounts2
                                initialBalance2
printfn "%f" endingBalance3
```

**Output**
**1205.833333**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

