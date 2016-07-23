// Discriminated union type that encodes the transaction type.
type Transaction =
    | Deposit
    | Withdrawal

let transactionTypes = seq { yield Deposit; yield Deposit; yield Withdrawal }
let transactionAmounts = seq { yield 100.00; yield 1000.00; yield 95.00}
let initialBalance = 200.00

// Use fold2 to perform a calculation on the list to update the account balance.
let endingBalance = Seq.fold2 (fun acc elem1 elem2 ->
                                match elem1 with
                                | Deposit -> acc + elem2
                                | Withdrawal -> acc - elem2)
                                initialBalance
                                transactionTypes
                                transactionAmounts
printfn "%f" endingBalance