# Async.RunSynchronously<'T> Method (F#)

Runs the provided asynchronous computation and awaits its result.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
static member RunSynchronously : Async<'T> * ?int * ?CancellationToken -> 'T

// Usage:
Async.RunSynchronously (computation)
Async.RunSynchronously (computation, timeout = timeout, cancellationToken = cancellationToken)
```

#### CAPS_PARAMETERS_MD
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The computation to run.


*timeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The amount of time in milliseconds to wait for the result of the computation before raising a **T:System.TimeoutException**. If no value is provided for timeout then a default of -1 is used to correspond to **F:System.Threading.Timeout.Infinite**.


*cancellationToken*
Type: [CancellationToken](http://msdn.microsoft.com/en-us/library/31a3eafe-b61b-46c4-927d-bc9a3ae357c2)


The cancellation token to be associated with the computation. If one is not supplied, the default cancellation token is used.



**The result of the computation.**
## CAPS_REMARKS_MD
If an exception occurs in the asynchronous computation then an exception is re-raised by this function. If no cancellation token is provided then the default cancellation token is used. The timeout parameter is given in milliseconds. A value of -1 is equivalent to **F:System.Threading.Timeout.Infinite**.

If you provide a cancelable cancellation token, the timeout is ignored. Instead, you can implement your own timeout by canceling the operation. A cancellation token is cancelable if its **P:System.Threading.CancellationToken.CanBeCanceled** property is set to **true**.

**Async.RunSynchronously** should not be used on the main thread in asynchronous programming environments, such as in Silverlight-based applications.

**The following example shows how to use Async.RunSynchronously to run an asynchronous computation created by using [Async.Parallel](http://msdn.microsoft.com/en-us/library/aa9b0355-2d55-4858-b943-cbe428de9dc4), with no timeout.**
```

    let bufferData (number:int) =
        [| for count in 1 .. 1000 -> byte (count % 256) |]
        |> Array.permute (fun index -> index)

    let writeFile fileName bufferData =
        async {
          use outputFile = System.IO.File.Create(fileName)
          do! outputFile.AsyncWrite(bufferData) 
        }

    Seq.init 1000 (fun num -> bufferData num)
    |> Seq.mapi (fun num value -> writeFile ("file" + num.ToString() + ".dat") value)
    |> Async.Parallel
    |> Async.RunSynchronously
    |> ignore
```

```

    let bufferData (number:int) =
        [| for i in 1 .. 1000 -> byte (i % 256) |]
        |> Array.permute (fun index -> index)

    // Create a counter as a reference cell that can be modified in parallel.
    let counter = ref 0

    // writeFileInner writes the data to an open stream
    // that represents the file. It also updates the counter.

    // The counter is locked because it will be accessed by
    // multiple asynchronous computations.

    // The counter must be updated as soon as the
    // AsyncWrite completes, in the same synchronous
    // program flow. There must not be a let! or do! between
    // the AsyncWrite call and the counter update.
    let writeFileInner (stream:System.IO.Stream) data =
        let result = stream.AsyncWrite(data)
        lock counter (fun () -> counter := !counter + 1)
        result

    // writeFile encapsulates the asynchronous write operation.
    // The do! includes both the file I/O operation and the
    // counter update in order to keep those operations
    // together.
    let writeFile fileName bufferData =
        async {
          use outputFile = System.IO.File.Create(fileName)
          do! writeFileInner outputFile bufferData
          // Updating the counter here would not be effective.
        }

    let async1 = Seq.init 1000 (fun num -> bufferData num)
                 |> Seq.mapi (fun num value ->
                     writeFile ("file" + num.ToString() + ".dat") value)
                 |> Async.Parallel
    try
        Async.RunSynchronously(async1, 100) |> ignore
    with
       | exc -> printfn "%s" exc.Message
                printfn "%d write operations completed successfully." !counter
```

**Sample Output**
**The operation has timed out.420 write operations completed successfully.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

