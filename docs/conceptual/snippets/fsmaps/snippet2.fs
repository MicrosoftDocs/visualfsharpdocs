
    let map1 = Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    let map2 = map1.Add(0, "zero")
    map2 |> Map.iter (fun key value -> printfn "key: %d value: %s" key value)