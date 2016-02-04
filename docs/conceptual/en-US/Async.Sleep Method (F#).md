# Async.Sleep Method (F#)

Creates an asynchronous computation that will sleep for the given time. This is scheduled using a **T:System.Threading.Timer** object. The operation will not block operating system threads for the duration of the wait.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
static member Sleep : int -> Async<unit>

// Usage:
Async.Sleep (millisecondsDueTime)


```



#### CAPS_PARAMETERS_MD
*millisecondsDueTime*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The number of milliseconds to sleep.



**exceptions tag is not supported!!!!**
**An asynchronous computation that will sleep for the given time.**
## CAPS_REMARKS_MD
**The following code example shows how to use Async.Sleep to simulate computations that run for specific durations.**


```



let simulatedJob id time =
    let timestamp() = System.DateTime.Now.Ticks
    async {
       printfn "Job %d start" id
       let timestamp1 = timestamp()
       do! Async.Sleep(time * 1000)
       let timestamp2 = timestamp()
       let timespan = System.TimeSpan(timestamp2 - timestamp1)
       printfn "Job %d end %s" id (timespan.ToString("G"))
    }

[ 1 .. 10]
|> List.mapi (fun index time -> simulatedJob index time)
|> Async.Parallel
|> Async.RunSynchronously
|> ignore


```



**Sample Output**
**The output is interleaved, because there are multiple threads running at the same time.**
**Job Job 0 start**
**1 start**
**Job 2 starJob 3 start**
**Job 4 start**
**Job 5 start**
**Job 6 start**
**Job 7 start**
**Job 8 start**
**Job 9 start**
**t**
**Job 0 end 0:00:00:01.0091009**
**Job 1 end 0:00:00:02.0102010**
**Job 2 end 0:00:00:03.0033003**
**Job 3 end 0:00:00:04.0074007**
**Job 4 end 0:00:00:05.0065006**
**Job 5 end 0:00:00:06.0076007**
**Job 6 end 0:00:00:07.0007000**
**Job 7 end 0:00:00:07.9957995**
**Job 8 end 0:00:00:08.9928992**
**Job 9 end 0:00:00:09.9919991**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

