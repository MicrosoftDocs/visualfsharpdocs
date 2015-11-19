# Async.StartChild<'T> Method (F#)

Starts a child computation within an asynchronous workflow. This allows multiple asynchronous computations to be executed simultaneously.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
static member StartChild : Async<'T> * ?int -> Async<Async<'T>>

// Usage:
Async.StartChild (computation)
Async.StartChild (computation, millisecondsTimeout = millisecondsTimeout)
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*computation*
Type: [Async](http://msdn.microsoft.com/en-us/library/e0b28ea2-dea5-4021-b2b9-d7d4761babde)**&lt;'T&gt;**


The child computation.


*millisecondsTimeout*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The timeout value in milliseconds. If one is not provided then the default value is -1, which corresponds to **F:System.Threading.Timeout.Infinite**.



**A new computation that waits for the input computation to finish.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This method should normally be used as the immediate right-hand-side of a **let!** binding in an F# asynchronous workflow, that is:


```f#
async { 
...
let! completor1 = childComputation1
|> Async.StartChild
let! completor2 = childComputation2
|> Async.StartChild
... 
let! result1 = completor1
let! result2 = completor2
... }
```
When used in this way, each use of **StartChild** starts an instance of **childComputation** and returns a **completor** object representing a computation to wait for the completion of the operation. When executed, the **completor** awaits the completion of **childComputation**.

**The following code example illustrates the use of Async.StartChild.**
**[!CODE [FsAsyncAPIs#4](../CodeSnippet/VS_Snippets_Fsharp/fsasyncapis/FSharp/fs/program.fs#4)]**
**Sample Output**
**The output is interleaved because the jobs are running simultaneously.**
**ComplParent job start.**
**eted execution.**
**Child job start: Child job slongoutput1.dat**
**tart: longoutput2.dat**
**Child job end: longoutput2.dat**
**Child job end: longoutput1.dat**
**Parent job end.**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+28%F%2329%.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

