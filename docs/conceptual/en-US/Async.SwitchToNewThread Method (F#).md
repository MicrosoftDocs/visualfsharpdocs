# Async.SwitchToNewThread Method (F#)

Creates an asynchronous computation that creates a new thread and runs its continuation in that thread.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member SwitchToNewThread : unit -> Async<unit>

// Usage:
Async.SwitchToNewThread ()
```
**A computation that will execute on a new thread.**
## CAPS_REMARKS_MD
**The following code example shows how to use Async.SwitchToNewThread and [Async.SwitchToThreadPool](http://msdn.microsoft.com/en-us/library/c2708739-5389-487a-a3c9-490f417bcdc6) to wrap a synchronous method call as an asynchronous method.**
```

    open System
    open System.IO

    let asyncMethod f = 
        async {  
            do! Async.SwitchToNewThread() 
            let result = f() 
            do! Async.SwitchToThreadPool() 
            return result
        } 

    let GetFilesAsync(path) = asyncMethod (fun () -> Directory.GetFiles(path))

    let listFiles path =
        async {
            let! files = GetFilesAsync(path)
            Array.iter (fun elem -> printfn "%s" elem) files
        }

    printfn "Here we go..."
    // The output is interleaved, which shows that these are both 
    // running simultaneously.
    Async.Start(listFiles ".")
    Async.Start(listFiles ".")
    Console.WriteLine("Press a key to continue...")
    Console.ReadLine() |> ignore
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

