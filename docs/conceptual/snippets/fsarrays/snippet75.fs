let inputArray = [| -5 .. 10 |]
let printArray arr1 = 
    arr1
    |> Array.iter (printf "%A ")
    printfn ""
printfn "Original array: "
printArray inputArray
printfn "\nArray with distinct absolute values: "
let arrDistinctAbsoluteValue = Array.distinctBy (fun elem -> abs elem) inputArray
arrDistinctAbsoluteValue |> printArray