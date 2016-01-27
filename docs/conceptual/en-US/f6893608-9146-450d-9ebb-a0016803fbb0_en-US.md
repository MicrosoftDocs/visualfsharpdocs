# Array.scan<'T,'State> Function (F#)

Like [Array.fold](http://msdn.microsoft.com/en-us/library/5ed9dd3b-3694-4567-94d0-fd9a24474e09), but returns the intermediate and final results.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.scan : ('State -> 'T -> 'State) -> 'State -> 'T [] -> 'State []

// Usage:
Array.scan folder state array
```

#### CAPS_PARAMETERS_MD
*folder*
Type: **'State -&gt; 'T -&gt; 'State**


The function to update the state given the input elements.


*state*
Type: **'State**


The initial state.


*array*
Type: **'T**[[]](http://msdn.microsoft.com/en-us/library/def20292-9aae-4596-9275-b94e594f8493)


The input array.



**The array of state values.**
## CAPS_REMARKS_MD
This function is named **Scan** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.scan.**
```

    let initialBalance = 1122.73
    let transactions = [| -100.00; +450.34; -62.34; -127.00; -13.50; -12.92 |]
    let balances =
        Array.scan (fun balance transactionAmount -> balance + transactionAmount) initialBalance transactions
    printfn "Initial balance:\n $%10.2f" initialBalance
    printfn "Transaction   Balance"
    for i in 0 .. Array.length transactions - 1 do
        printfn "$%10.2f $%10.2f" transactions.[i] balances.[i]
    printfn "Final balance:\n $%10.2f" balances.[ Array.length balances - 1]
```

**Output**
**Initial balance:**
**$   1122.73**
**Transaction   Balance**
**$   -100.00 $   1122.73**
**$    450.34 $   1022.73**
**$    -62.34 $   1473.07**
**$   -127.00 $   1410.73**
**$    -13.50 $   1283.73**
**$    -12.92 $   1270.23**
**Final balance:**
**$   1257.31**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

