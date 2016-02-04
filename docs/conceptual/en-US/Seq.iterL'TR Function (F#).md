# Seq.iter<'T> Function (F#)

Applies the given function to each element of the collection.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
Seq.iter : ('T -> unit) -> seq<'T> -> unit

// Usage:
Seq.iter action source


```



#### CAPS_PARAMETERS_MD
*action*
Type: **'T -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


A function to apply to each element of the sequence.


*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**

## CAPS_REMARKS_MD
This function is named **Iterate** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example illustrates the use of Seq.iter.**


```



    printf "Seq.iter: "
    Seq.iter (fun (a,b) -> printf "(%d, %d) " a b) (seq { for i in 1..5 -> (i, i*i) })


```



**Seq.iter: (1, 1) (2, 4) (3, 9) (4, 16) (5, 25)****The following example illustrates the use of Seq.iter to work with CSV (Comma-Separated Value) files.**


```



    // Write a test file
    System.IO.File.WriteAllLines(@"test.csv", [| "Desmond, Barrow, Market Place, 2"; 
                                                 "Molly, Singer, Band, 12" |]);

    /// This function builds an IEnumerable<string list> object that enumerates the CSV-split
    /// lines of the given file on-demand 
    let CSVFileEnumerator(fileName) = 

        // The function is implemented using a sequence expression
        seq { use sr = System.IO.File.OpenText(fileName)
              while not sr.EndOfStream do
                 let line = sr.ReadLine() 
                 let words = line.Split [|',';' ';'\t'|] 
                 yield words }

    // Now test this out on our test file, iterating the entire file
    let test = CSVFileEnumerator(@"test.csv")  
    printfn "-------Enumeration 1------";
    test |> Seq.iter (string >> printfn "line %s");
    // Now do it again, this time determining the numer of entries on each line.
    // Note how the file is read from the start again, since each enumeration is 
    // independent.
    printfn "-------Enumeration 2------";
    test |> Seq.iter (Array.length >> printfn "line has %d entries");
    // Now do it again, this time determining the numer of entries on each line.
    // Note how the file is read from the start again, since each enumeration is 
    // independent.
    printfn "-------Enumeration 3------";
    test |> Seq.iter (Array.map (fun s -> s.Length) >> printfn "lengths of entries: %A")


```



**-------Enumeration 1------**
**line System.String[]**
**line System.String[]**
**-------Enumeration 2------**
**line has 8 entries**
**line has 7 entries**
**-------Enumeration 3------**
**lengths of entries: [|7; 0; 6; 0; 6; 5; 0; 1|]**
**lengths of entries: [|5; 0; 6; 0; 4; 0; 2|]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

