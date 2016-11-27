// Use Seq.fold2 to perform computations over two lists (of equal size) at the same time.
// Example: Sum the greater element at each sequence position.
let sumGreatest seq1 seq2 = Seq.fold2 (fun acc elem1 elem2 ->
                                              acc + max elem1 elem2) 0 seq1 seq2

let seq1 = seq { 3..-1..1} 
let seq2 = seq { 1..1..3 }

let sum = sumGreatest seq1 seq2
printfn "The sum of the greater of each pair of elements in the two sequences is %d." sum

let seq3 = seq { 1..1..4} 
let seq4 = seq { 5..-1..1} // This sequence has more elements than seq3
let sum1 = sumGreatest seq3 seq4
// The calculation performed is 5 + 4 + 3 + 4 and the final element of seq4 is ignored
printfn "The sum of the greater of each pair of elements in the two sequences is %d." sum1