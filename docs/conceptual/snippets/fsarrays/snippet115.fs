let array1 = [| 1 .. 100 |]
let printArray anarray = Array.iter (printf "%A ") anarray; printfn ""
let arrayResult = Array.countBy (fun elem ->
    if (elem % 2 = 0) then 0 else 1) array1

printArray arrayResult