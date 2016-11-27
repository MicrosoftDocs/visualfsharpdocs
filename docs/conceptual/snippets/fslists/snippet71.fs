let inputList = [ -5 .. 10 ]
let printList list1 = 
    list1
    |> List.iter (printf "%A ")
    printfn ""
printfn "Original list: "
printList inputList
printfn "\nList with distinct absolute values: "
let seqDistinctAbsoluteValue = List.distinctBy (fun elem -> abs elem) inputList
seqDistinctAbsoluteValue |> printList