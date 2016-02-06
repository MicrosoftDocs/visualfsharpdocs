
    Map.ofList [ (1, "one"); (2, "two"); (3, "three") ]
    |> Map.add(0) "zero"
    |> Map.iter (fun key value -> printfn "key: %d value: %s" key value)