let sumArrayBack array = Array.foldBack (fun elem acc -> acc + elem) array 0
let array1 = [| 1 .. 3 |]
printfn "%d" (sumArrayBack array1)

// For a calculation in which the order of traversal is important, fold and foldBack have different
// results. For example, replacing foldBack with fold in the subtractArrayBack function produces a function 
// that gives the negative of the result of subtractArrayBack when the input array
// has an even number of elements.
// Note the difference in parameter ordering
let subtractArrayBack array = Array.foldBack (fun elem acc -> elem - acc ) array 0
let subtractArray array = Array.fold (fun acc elem -> elem - acc ) 0 array

let array2 = [| 1 .. 9 |]
let array3 = [| 1 .. 10 |]
printfn "%A" (subtractArrayBack array2) // 5
printfn "%A" (subtractArray array2) // 5

// Computes 1-(2-(3-(4-(5-(6-(7-(8-(9-(10-0))))))))) = -5
printfn "%A" (subtractArrayBack array3)

// Computes 10-(9-(8-(7-(6-(5-(4-(3-(2-(1-0))))))))) = 5
printfn "%A" (subtractArray array3)
