let sumSeqBack seq = Seq.foldBack (fun elem acc -> acc + elem) seq 0
let seq1 = seq { 1 .. 3 }
printfn "%d" (sumSeqBack seq1)

// For a calculation in which the order of traversal is important, fold and foldBack have different
// results. For example, replacing foldBack with fold in the subtractSeqBack function produces a function 
// that gives the negative of the result of subtractSeqBack when the input sequence
// has an even number of elements.
// Note the difference in parameter ordering
let subtractSeqBack seq = Seq.foldBack (fun elem acc -> elem - acc ) seq 0
let subtractSeq seq = Seq.fold (fun acc elem -> elem - acc ) 0 seq

let seq2 = seq { 1 .. 9 }
let seq3 = seq { 1 .. 10 }
printfn "%A" (subtractSeqBack seq2) // 5
printfn "%A" (subtractSeq seq2) // 5

// Computes 1-(2-(3-(4-(5-(6-(7-(8-(9-(10-0))))))))) = -5
printfn "%A" (subtractSeqBack seq3)

// Computes 10-(9-(8-(7-(6-(5-(4-(3-(2-(1-0))))))))) = 5
printfn "%A" (subtractSeq seq3)
