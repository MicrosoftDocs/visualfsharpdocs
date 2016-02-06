
let multiplicationTable max = seq { for i in 1 .. max -> [| for j in 1 .. max -> (i, j, i*j) |] }
printfn "%A" (Array.concat (multiplicationTable 3))