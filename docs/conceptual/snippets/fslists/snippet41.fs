let sumListBack list = List.foldBack (fun elem acc -> acc + elem) list 0
printfn "%d" (sumListBack [1; 2; 3])

// For a calculation in which the order of traversal is important, fold and foldBack have different
// results. For example, replacing foldBack with fold in the copyList function
// produces a function that reverses the list, rather than copying it.
// Note the difference in parameter ordering
let copyListBack list = List.foldBack (fun elem acc -> elem::acc) list []
let copyList list = List.fold (fun acc elem -> elem::acc) [] list
printfn "%A" (copyListBack [1 .. 10])
printfn "%A" (copyList [1 .. 10])