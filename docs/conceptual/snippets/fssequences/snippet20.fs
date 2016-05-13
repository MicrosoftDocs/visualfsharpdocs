
    let mySeq1 = seq { 1.. 100 }
    let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""
    let seqResult = Seq.countBy (fun elem ->
        if (elem % 2 = 0) then 0 else 1) mySeq1

    printSeq seqResult