# Control.MailboxProcessor<'Msg> Class (F#)

A message-processing agent which executes an asynchronous computation.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


[<Sealed>]
[<AutoSerializable(false)>]
type MailboxProcessor<'Msg> =
class
interface IDisposable
new MailboxProcessor : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>
member this.Post : 'Msg -> unit
member this.PostAndAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * int option -> Async<'Reply>
member this.PostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * int option -> 'Reply
member this.PostAndTryAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> Async<'Reply option>
member this.Receive : ?int -> Async<'Msg>
member this.Scan : ('Msg -> Async<'T> option) * ?int -> Async<'T>
member this.Start : unit -> unit
static member Start : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>
member this.TryPostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> 'Reply option
member this.TryReceive : ?int -> Async<'Msg option>
member this.TryScan : ('Msg -> Async<'T> option) * ?int -> Async<'T option>
member this.add_Error : Handler<Exception> -> unit
member this.CurrentQueueLength :  int
member this.DefaultTimeout :  int with get, set
member this.Error :  IEvent<Exception>
member this.remove_Error : Handler<Exception> -> unit
end


```



## CAPS_REMARKS_MD
The agent encapsulates a message queue that supports multiple-writers and a single reader agent. Writers send messages to the agent by using the Post method and its variations. The agent may wait for messages using the Receive or TryReceive methods or scan through all available messages using the Scan or TryScan method.

This type is named **FSharpMailboxProcessor** in the .NET assembly. If accessing the type from a .NET language other than F#, or through reflection, use this name.


## Constructors


|Member|Description|
|------|-----------|
|[new](http://msdn.microsoft.com/en-us/library/f13a40de-09c2-4446-9465-c1c476c57d1e)|Creates an agent. The **body** function is used to generate the asynchronous computation executed by the agent. This function is not executed until **Start** is called.|

## Instance Members


|Member|Description|
|------|-----------|
|[add_Error](http://msdn.microsoft.com/en-us/library/ecd8c707-7ef1-4db1-b847-0c9d9251fa53)|Occurs when the execution of the agent results in an exception.|
|[CurrentQueueLength](http://msdn.microsoft.com/en-us/library/bed32e01-5c56-4bce-985c-35f3244f3580)|Returns the number of unprocessed messages in the message queue of the agent.|
|[DefaultTimeout](http://msdn.microsoft.com/en-us/library/9f54edae-6167-4a68-acc5-fd444817fb1b)|Raises a timeout exception if a message not received in this amount of time. By default no timeout is used.|
|[Error](http://msdn.microsoft.com/en-us/library/f9bf8e54-a0bc-4cfa-9b2d-abdedde9b74e)|Occurs when the execution of the agent results in an exception.|
|[Post](http://msdn.microsoft.com/en-us/library/70597a62-6aa9-4565-9b37-c0877cd3283b)|Posts a message to the message queue of the MailboxProcessor, asynchronously.|
|[PostAndAsyncReply](http://msdn.microsoft.com/en-us/library/cd7d03c7-cc82-46f3-9f9a-ed689164e4a8)|Posts a message to an agent and await a reply on the channel, asynchronously.|
|[PostAndReply](http://msdn.microsoft.com/en-us/library/11842a52-ea51-45e8-86c4-72e887fedf71)|Posts a message to an agent and await a reply on the channel, synchronously.|
|[PostAndTryAsyncReply](http://msdn.microsoft.com/en-us/library/d1eba793-83b7-430c-ab83-81576ab670dd)|Like AsyncPostAndReply, but returns None if no reply within the timeout period.|
|[Receive](http://msdn.microsoft.com/en-us/library/46a1d8e6-3906-45c2-9722-0ddab574cc6a)|Waits for a message. This will consume the first message in arrival order.|
|[remove_Error](http://msdn.microsoft.com/en-us/library/bfbc587c-9317-4094-8091-8519d8a47a37)|Occurs when the execution of the agent results in an exception.|
|[Scan](http://msdn.microsoft.com/en-us/library/e86368a3-4f97-4b51-a487-4c6b5456fcbe)|Scans for a message by looking through messages in arrival order until **scanner** returns a Some value. Other messages remain in the queue.|
|[Start](http://msdn.microsoft.com/en-us/library/ebf18bf3-ba17-42b9-91ac-313a7eee6fa0)|Starts the agent.|
|[TryPostAndReply](http://msdn.microsoft.com/en-us/library/5c4a758b-aace-4cc1-950d-6105fd3652b9)|Like PostAndReply, but returns None if no reply within the timeout period.|
|[TryReceive](http://msdn.microsoft.com/en-us/library/edcb3930-cefd-4d88-935d-7dd6297355ee)|Waits for a message. This will consume the first message in arrival order.|
|[TryScan](http://msdn.microsoft.com/en-us/library/05aa6c91-fe9f-4830-a2d7-6dfa5a2ab376)|Scans for a message by looking through messages in arrival order until **scanner** returns a Some value. Other messages remain in the queue.|

## Static Members


|Member|Description|
|------|-----------|
|[Start](http://msdn.microsoft.com/en-us/library/ebf18bf3-ba17-42b9-91ac-313a7eee6fa0)|Creates and starts an agent. The **body** function is used to generate the asynchronous computation executed by the agent.|
**The following example shows the basic use of the MailboxProcessor class.**


```



    open System
    open Microsoft.FSharp.Control

    type Message(id, contents) =
        static let mutable count = 0
        member this.ID = id
        member this.Contents = contents
        static member CreateMessage(contents) =
            count <- count + 1
            Message(count, contents)

    let mailbox = new MailboxProcessor<Message>(fun inbox ->
        let rec loop count =
            async { printfn "Message count = %d. Waiting for next message." count
                    let! msg = inbox.Receive()
                    printfn "Message received. ID: %d Contents: %s" msg.ID msg.Contents
                    return! loop( count + 1) }
        loop 0)

    mailbox.Start()

    mailbox.Post(Message.CreateMessage("ABC"))
    mailbox.Post(Message.CreateMessage("XYZ"))


    Console.WriteLine("Press any key...")
    Console.ReadLine() |> ignore


```



**Sample Output**
**Press any key...**
**Message count = 0. Waiting for next message.**
**Message received. ID: 1 Contents: ABC**
**Message count = 1. Waiting for next message.**
**Message received. ID: 2 Contents: XYZ**
**Message count = 2. Waiting for next message.****The following example shows how to use MailboxProcessor to create a simple agent that accepts various types of messages and returns appropriate replies. This server agent represents a market maker, which is a buying and selling agent on a stock exchange that sets bid and ask prices for assets. Clients can query for prices, or buy and sell shares.**


```



    open System

    type AssetCode = string

    type Asset(code, bid, ask, initialQuantity) =
        let mutable quantity = initialQuantity
        member this.AssetCode = code
        member this.Bid = bid
        member this.Ask = ask
        member this.Quantity with get() = quantity and set(value) = quantity <- value


    type OrderType =
        | Buy of AssetCode * int
        | Sell of AssetCode * int

    type Message =
        | Query of AssetCode * AsyncReplyChannel<Reply>
        | Order of OrderType * AsyncReplyChannel<Reply>
    and Reply =
        | Failure of string
        | Info of Asset
        | Notify of OrderType

    let assets = [| new Asset("AAA", 10.0, 10.05, 1000000);
                    new Asset("BBB", 20.0, 20.10, 1000000);
                    new Asset("CCC", 30.0, 30.15, 1000000) |]

    let codeAssetMap = assets
                       |> Array.map (fun asset -> (asset.AssetCode, asset))
                       |> Map.ofArray

    let mutable totalCash = 00.00
    let minCash = -1000000000.0
    let maxTransaction = 1000000.0

    let marketMaker = new MailboxProcessor<Message>(fun inbox ->
        let rec Loop() =
            async {
                let! message = inbox.Receive()
                match message with
                | Query(assetCode, replyChannel) ->
                    match (Map.tryFind assetCode codeAssetMap) with
                    | Some asset ->
                        printfn "Replying with Info for %s" (asset.AssetCode)
                        replyChannel.Reply(Info(asset))
                    | None -> replyChannel.Reply(Failure("Asset code not found."))
                | Order(order, replyChannel) ->
                    match order with
                    | Buy(assetCode, quantity) ->
                        match (Map.tryFind assetCode codeAssetMap) with
                        | Some asset ->
                            if (quantity < asset.Quantity) then
                                asset.Quantity <- asset.Quantity - quantity
                                totalCash <- totalCash + float quantity * asset.Ask
                                printfn "Replying with Notification:\nBought %d units of %s at price $%f. Total purchase $%f."
                                        quantity asset.AssetCode asset.Ask (asset.Ask * float quantity)
                                printfn "Marketmaker balance: $%10.2f" totalCash
                                replyChannel.Reply(Notify(Buy(asset.AssetCode, quantity)))
                            else
                                printfn "Insufficient shares to fulfill order for %d units of %s."
                                        quantity asset.AssetCode
                                replyChannel.Reply(Failure("Insufficient shares to fulfill order."))
                        | None -> replyChannel.Reply(Failure("Asset code not found."))
                    | Sell(assetCode, quantity) ->
                        match (Map.tryFind assetCode codeAssetMap) with
                        | Some asset ->
                            if (float quantity * asset.Bid <= maxTransaction && totalCash - float quantity * asset.Bid > minCash) then
                                asset.Quantity <- asset.Quantity + quantity
                                totalCash <- totalCash - float quantity * asset.Bid
                                printfn "Replying with Notification:\nSold %d units of %s at price $%f. Total sale $%f."
                                        quantity asset.AssetCode asset.Bid (asset.Bid * float quantity)
                                printfn "Marketmaker balance: $%10.2f" totalCash
                                replyChannel.Reply(Notify(Sell(asset.AssetCode, quantity)))
                            else
                                printfn "Insufficient cash to fulfill order for %d units of %s."
                                        quantity asset.AssetCode
                                replyChannel.Reply(Failure("Insufficient cash to cover order."))
                        | None -> replyChannel.Reply(Failure("Asset code not found."))
                do! Loop()
            }
        Loop())

    marketMaker.Start()

    // Query price.
    let reply1 = marketMaker.PostAndReply(fun replyChannel -> 
        printfn "Posting message for AAA"
        Query("AAA", replyChannel))
        
    // Test Buy Order.
    let reply2 = marketMaker.PostAndReply(fun replyChannel -> 
        printfn "Posting message for BBB"
        Order(Buy("BBB", 100), replyChannel))

    // Test Sell Order.
    let reply3 = marketMaker.PostAndReply(fun replyChannel -> 
        printfn "Posting message for CCC"
        Order(Sell("CCC", 100), replyChannel))

    // Test incorrect code.
    let reply4 = marketMaker.PostAndReply(fun replyChannel -> 
        printfn "Posting message for WrongCode"
        Order(Buy("WrongCode", 100), replyChannel))

    // Test too large a number of shares.

    let reply5 = marketMaker.PostAndReply(fun replyChannel ->
        printfn "Posting message with large number of shares of AAA."
        Order(Buy("AAA", 1000000000), replyChannel))

    // Too large an amount of money for one transaction.

    let reply6 = marketMaker.PostAndReply(fun replyChannel ->
        printfn "Posting message with too large of a monetary amount."
        Order(Sell("AAA", 100000000), replyChannel))

    let random = new Random()
    let nextTransaction() =
        let buyOrSell = random.Next(2)
        let asset = assets.[random.Next(3)]
        let quantity = Array.init 3 (fun _ -> random.Next(1000)) |> Array.sum
        match buyOrSell with
        | n when n % 2 = 0 -> Buy(asset.AssetCode, quantity)
        | _ -> Sell(asset.AssetCode, quantity)

    let simulateOne() =
       async {
           let! reply = marketMaker.PostAndAsyncReply(fun replyChannel ->
               let transaction = nextTransaction()
               match transaction with
               | Buy(assetCode, quantity) -> printfn "Posting BUY %s %d." assetCode quantity
               | Sell(assetCode, quantity) -> printfn "Posting SELL %s %d." assetCode quantity
               Order(transaction, replyChannel))
           printfn "%s" (reply.ToString())
        }

    let simulate =
        async {
            while (true) do
                do! simulateOne()
                // Insert a delay so that you can see the results more easily.
                do! Async.Sleep(1000)
        }

    Async.Start(simulate)

    Console.WriteLine("Press any key...")
    Console.ReadLine() |> ignore


```



**Sample Output**
**Posting message for AAA**
**Replying with Info for AAA**
**Posting message for BBB**
**Replying with Notification:**
**Bought 100 units of BBB at price $20.100000. Total purchase $2010.000000.**
**Marketmaker balance: $   2010.00**
**Posting message for CCC**
**Replying with Notification:**
**Sold 100 units of CCC at price $30.000000. Total sale $3000.000000.**
**Marketmaker balance: $   -990.00**
**Posting message for WrongCode**
**Posting message with large number of shares of AAA.**
**Insufficient shares to fulfill order for 1000000000 units of AAA.**
**Posting message with too large a monetary amount.**
**Insufficient cash to fulfill order for 100000000 units of AAA.**
**Press any key...**
**Posting BUY CCC 1338.**
**Replying with Notification:**
**Bought 1338 units of CCC at price $30.150000. Total purchase $40340.700000.**
**Marketmaker balance: $  39350.70**
**Program+Snippet3+Reply+Notify**
**Posting BUY BBB 1961.**
**Replying with Notification:**
**Bought 1961 units of BBB at price $20.100000. Total purchase $39416.100000.**
**Marketmaker balance: $  78766.80**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+%28F%23%29.md)

