let array1 = [| 1 .. 100 |]
let printArray anarray = Seq.iter (printf "%A ") anarray; printfn ""
let arrayResult = Seq.countBy (fun elem ->
    if (elem % 2 = 0) then 0 else 1) array1

printArray arrayResult