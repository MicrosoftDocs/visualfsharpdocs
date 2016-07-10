let list1 = [ 1 .. 100 ]
let printList alist = Seq.iter (printf "%A ") alist; printfn ""
let listResult = Seq.countBy (fun elem ->
    if (elem % 2 = 0) then 0 else 1) list1

printList listResult