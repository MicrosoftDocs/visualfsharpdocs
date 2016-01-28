# Null Values (F#)

This topic describes how the null value is used in F#.


## Null Value
The null value is not normally used in F# for values or variables. However, null appears as an abnormal value in certain situations. If a type is defined in F#, null is not permitted as a regular value unless the [AllowNullLiteral](http://msdn.microsoft.com/en-us/library/4f315196-f444-4cca-ba07-1176ff71eb0f) attribute is applied to the type. If a type is defined in some other .NET language, null is a possible value, and when you are interoperating with such types, your F# code might encounter null values.

For a type defined in F# and used strictly from F#, the only way to create a null value using the F# library directly is to use [Unchecked.defaultof](http://msdn.microsoft.com/en-us/library/9ff97f2a-1bd4-4f4c-afbe-5886a74ab977) or [Array.zeroCreate](http://msdn.microsoft.com/en-us/library/fa5b8e7a-1b5b-411c-8622-b58d7a14d3b2). However, for an F# type that is used from other .NET languages, or if you are using that type with an API that is not written in F#, such as the .NET Framework, null values can occur.

You can use the **option** type in F# when you might use a reference variable with a possible null value in another .NET language. Instead of null, with an F# **option** type, you use the option value **None** if there is no object. You use the option value **Some(obj)** with an object **obj** when there is an object. For more information, see [Options &#40;F&#35;&#41;](Options+%28F%23%29.md).

The **null** keyword is a valid keyword in the F# language, and you have to use it when you are working with .NET Framework APIs or other APIs that are written in another .NET language. The two situations in which you might need a null value are when you call a .NET API and pass a null value as an argument, and when you interpret the return value or an output parameter from a .NET method call.

To pass a null value to a .NET method, just use the **null** keyword in the calling code. The following code example illustrates this.

```

open System

// Pass a null value to a .NET method.
let ParseDateTime (str: string) =
    let (success, res) = DateTime.TryParse(str, null, System.Globalization.DateTimeStyles.AssumeUniversal)
    if success then
        Some(res)
    else
        None

```

    To interpret a null value that is obtained from a .NET method, use pattern matching if you can. The following code example shows how to use pattern matching to interpret the null value that is returned from **ReadLine** when it tries to read past the end of an input stream.

```

// Open a file and create a stream reader.
let fileStream1 =
    try
        System.IO.File.OpenRead("TextFile1.txt")
    with 
        | :? System.IO.FileNotFoundException -> printfn "Error: TextFile1.txt not found."; exit(1)

let streamReader = new System.IO.StreamReader(fileStream1)

// ProcessNextLine returns false when there is no more input;
// it returns true when there is more input.
let ProcessNextLine nextLine =
    match nextLine with
    | null -> false
    | inputString ->
        match ParseDateTime inputString with
        | Some(date) -> printfn "%s" (date.ToLocalTime().ToString())
        | None -> printfn "Failed to parse the input."
        true

// A null value returned from .NET method ReadLine when there is
// no more input.
while ProcessNextLine (streamReader.ReadLine()) do ()
```

    Null values for F# types can also be generated in other ways, such as when you use **Array.zeroCreate**, which calls **Unchecked.defaultof**. You must be careful with such code to keep the null values encapsulated. In a library intended only for F#, you do not have to check for null values in every function. If you are writing a library for interoperation with other .NET languages, you might have to add checks for null input parameters and throw an **ArgumentNullException**, just as you do in C# or Visual Basic code.

You can use the following code to check if an arbitrary value is null.

```

match box value with
| null -> printf "The value is null."
| _ -> printf "The value is not null."
```

    
## See Also
[Values &#40;F&#35;&#41;](Values+%28F%23%29.md)

[Match Expressions &#40;F&#35;&#41;](Match+Expressions+%28F%23%29.md)

