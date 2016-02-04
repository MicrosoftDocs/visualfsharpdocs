# Async.FromBeginEnd<'T> Method (F#)

Creates an asynchronous computation in terms of a Begin/End pair of actions in the style used in CLI APIs.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
static member FromBeginEnd : (AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * ?(unit -> unit) -> Async<'T>

// Usage:
Async.FromBeginEnd (beginAction, endAction)
Async.FromBeginEnd (beginAction, endAction, cancelAction = cancelAction)


```



#### CAPS_PARAMETERS_MD
*beginAction*
Type: **T:System.AsyncCallback****&#42;**[obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7)**-&gt;****T:System.IAsyncResult**


The function initiating a traditional CLI asynchronous operation.


*endAction*
Type: **T:System.IAsyncResult****-&gt; 'T**


The function completing a traditional CLI asynchronous operation.


*cancelAction*
Type: **(**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**-&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)**)**


An optional function to be executed when a cancellation is requested.



**An asynchronous computation wrapping the given Begin/End functions.**
## CAPS_REMARKS_MD
For example, the following code creates an asynchronous computation that wraps a web service call.




```

f#
Async.FromBeginEnd(ws.BeginGetWeather,ws.EndGetWeather)


```


When the computation is run, *beginFunc* is executed, with a callback which represents the continuation of the computation. When the callback is invoked, the overall result is fetched using *endFunc*.

The computation will respond to cancellation while waiting for the completion of the operation. If a cancellation occurs, and *cancelAction* is specified, then it is executed, and the computation continues to wait for the completion of the operation. If *cancelAction* is not specified, cancellation causes the computation to stop immediately, and subsequent invocations of the callback are ignored.

**The following code example shows how to create an F# asynchronous computation from a .NET asynchronous API that uses the Begin/End pattern. The example uses the .NET socket API in System.Net.Sockets. It is an implementation of a simple server application that accepts a connection, receives data from a client, and sends a response.**


```



module SocketServer =

    open System.Net
    open System.Net.Sockets
    open System.Collections.Generic

    let toIList<'T> (data : 'T array) =
        let segment = new System.ArraySegment<'T>(data)
        let data = new List<System.ArraySegment<'T>>() :> IList<System.ArraySegment<'T>>
        data.Add(segment)
        data

    type Socket with
        member this.MyAcceptAsync() =
            Async.FromBeginEnd((fun (callback, state) -> this.BeginAccept(callback, state)),
                               this.EndAccept)
        member this.MyConnectAsync(ipAddress : IPAddress, port : int) =
            Async.FromBeginEnd(ipAddress, port,
                               (fun (ipAddress:IPAddress, port, callback, state) ->
                                   this.BeginConnect(ipAddress, port, callback, state)),
                               this.EndConnect)
        member this.MySendAsync(data : byte array, flags : SocketFlags) =
            Async.FromBeginEnd(toIList data, flags, 
                               (fun (data : IList<System.ArraySegment<byte>>,
                                     flags : SocketFlags, callback, state) ->
                                         this.BeginSend(data, flags, callback, state)),
                               this.EndSend)
        member this.MyReceiveAsync(data : byte array, flags : SocketFlags) =
            Async.FromBeginEnd(toIList data, flags, 
                               (fun (data : IList<System.ArraySegment<byte>>,
                                     flags : SocketFlags, callback, state) ->
                                         this.BeginReceive(data, flags, callback, state)),
                               this.EndReceive)

    let port = 11000

    let socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    let ipHostInfo = Dns.Resolve(Dns.GetHostName())
    let localIPAddress = ipHostInfo.AddressList.[0]
    let localEndPoint = new IPEndPoint(localIPAddress, port)
    socket.Bind(localEndPoint)


    let connectSendReceive (socket : Socket) =
        async {
            do! socket.MyConnectAsync(ipHostInfo.AddressList.[0], 11000)
            let buffer1 = [| 0uy .. 255uy |]
            let buffer2 = Array.zeroCreate<byte> 255
            let flags = new SocketFlags()
            let! flag = socket.MySendAsync(buffer1, flags)
            let! result = socket.MyReceiveAsync(buffer2, flags)
            return buffer2
        }

    let acceptReceiveSend (socket : Socket) =
        async {
            printfn "Listening..."
            socket.Listen(10)
            printfn "Accepting..."
            let! socket = socket.MyAcceptAsync()
            
            let buffer1 = Array.zeroCreate<byte> 256
            let flags = new SocketFlags()
            printfn "Receiving..."
            let! nBytes = socket.MyReceiveAsync(buffer1, flags)
            printfn "Received %d bytes from client computer." nBytes
            let buffer2 = Array.rev buffer1
            printfn "Sending..."
            let! flag = socket.MySendAsync(buffer2, flags)
            printfn "Completed."
            return buffer2
        }

    let taskServer = Async.StartAsTask(acceptReceiveSend(socket))    
    taskServer.Wait()
    socket.Close()


```



**Output**
**Listening...**
**Accepting...**
**Receiving...**
**Received 256 bytes from client computer.**
**Sending...**
**Completed.****The following code example shows the client code that can be used together with the server code in the previous example.**


```



module SocketClient =

    open System.Net
    open System.Net.Sockets
    open System.Collections.Generic

    let toIList<'T> (data : 'T array) =
        let segment = new System.ArraySegment<'T>(data)
        let data = new List<System.ArraySegment<'T>>() :> IList<System.ArraySegment<'T>>
        data.Add(segment)
        data

    type Socket with
        member this.MyAcceptAsync(receiveSize) =
            Async.FromBeginEnd(receiveSize,
                               (fun (receiveSize, callback, state) ->
                                   this.BeginAccept(receiveSize, callback, state)),
                               this.EndConnect)
        member this.MyConnectAsync(ipAddress : IPAddress, port : int) =
            Async.FromBeginEnd(ipAddress, port,
                               (fun (ipAddress:IPAddress, port, callback, state) ->
                                   this.BeginConnect(ipAddress, port, callback, state)),
                               this.EndConnect)
        member this.MySendAsync(data, flags : SocketFlags) =
            Async.FromBeginEnd(toIList data, flags, 
                               (fun (data : IList<System.ArraySegment<byte>>,
                                     flags : SocketFlags, callback, state) ->
                                         this.BeginSend(data, flags, callback, state)),
                               this.EndSend)
        member this.MyReceiveAsync(data, flags : SocketFlags) =
            Async.FromBeginEnd(toIList data, flags, 
                               (fun (data : IList<System.ArraySegment<byte>>,
                                     flags : SocketFlags, callback, state) ->
                                         this.BeginReceive(data, flags, callback, state)),
                               this.EndReceive)

    let port = 11000

    let socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    let ipHostEntry = Dns.Resolve("hostname.contoso.com")
    printfn "Server address: %s" (ipHostEntry.AddressList.[0].ToString())
    
    let connectSendReceive (socket : Socket) =
        async {
            do! socket.MyConnectAsync(ipHostEntry.AddressList.[0], 11000)
            printfn "Connected to remote host."
            let buffer1 = [| 0uy .. 255uy |]
            let buffer2 = Array.zeroCreate<byte> 255
            let flags = new SocketFlags()
            printfn "Sending data..."
            let! flag = socket.MySendAsync(buffer1, flags)
            printfn "Receiving data..."
            let! result = socket.MyReceiveAsync(buffer2, flags)
            printfn "Received data from remote host."
            return buffer2
        }

    let acceptReceiveSend (socket : Socket) =
        async {
            socket.Listen(1)
            do! socket.MyAcceptAsync(256)
            let buffer1 = Array.zeroCreate<byte> 255
            let flags = new SocketFlags()
            let! flag = socket.MyReceiveAsync(buffer1, flags)
            let buffer2 = Array.rev buffer1
            let! flag = socket.MySendAsync(buffer2, flags)
            return buffer2
        }

    let taskClient = Async.StartAsTask(connectSendReceive(socket))
    
    taskClient.Wait()
    taskClient.Result |> Array.iter (fun elem -> printf "%d " elem)


```



**Sample Output**
**Server address: 10.80.57.8**
**Connected to remote host.**
**Sending data...**
**Receiving data...**
**Received data from remote host.**
**255 254 253 252 251 250 249 248 247 246 ...**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async+Class+%28F%23%29.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

