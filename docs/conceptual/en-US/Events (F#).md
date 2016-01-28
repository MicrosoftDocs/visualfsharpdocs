# Events (F#)

Events enable you to associate function calls with user actions and are important in GUI programming. Events can also be triggered by your applications or by the operating system.


## Handling Events
When you use a GUI library like Windows Forms or Windows Presentation Foundation (WPF), much of the code in your application runs in response to events that are predefined by the library. These predefined events are members of GUI classes such as forms and controls. You can add custom behavior to a preexisting event, such as a button click, by referencing the specific named event of interest (for example, the **Click** event of the **Form** class) and invoking the **Add** method, as shown in the following code. If you run this from F# Interactive, omit the call to **M:System.Windows.Forms.Application.Run(System.Windows.Forms.Form)**.

```

open System.Windows.Forms

let form = new Form(Text="F# Windows Form",
                    Visible = true,
                    TopMost = true)

form.Click.Add(fun evArgs -> System.Console.Beep())
Application.Run(form)
```

    The type of the **Add** method is **('a -&gt; unit) -&gt; unit**. Therefore, the event handler method takes one parameter, typically the event arguments, and returns **unit**. The previous example shows the event handler as a lambda expression. The event handler can also be a function value, as in the following code example. The following code example also shows the use of the event handler parameters, which provide information specific to the type of event. For a **MouseMove** event, the system passes a **T:System.Windows.Forms.MouseEventArgs** object, which contains the **X** and **Y** position of the pointer.

```

    open System.Windows.Forms

    let Beep evArgs =
        System.Console.Beep( )  
        

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)
                            
    let MouseMoveEventHandler (evArgs : System.Windows.Forms.MouseEventArgs) =
        form.Text <- System.String.Format("{0},{1}", evArgs.X, evArgs.Y)

    form.Click.Add(Beep)
    form.MouseMove.Add(MouseMoveEventHandler)
    Application.Run(form)
```

    
## Creating Custom Events
F# events are represented by the F# [Event](http://msdn.microsoft.com/en-us/library/f3b47c8a-4ee5-4ce8-9a72-ad305a17c4b9) class, which implements the [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862) interface. **IEvent** is itself an interface that combines the functionality of two other interfaces, **T:System.IObservable&#96;1** and [IDelegateEvent](http://msdn.microsoft.com/en-us/library/3d849465-6b8e-4fc5-b36c-2941d734268a). Therefore, **Event**s have the equivalent functionality of delegates in other languages, plus the additional functionality from **IObservable**, which means that F# events support event filtering and using F# first-class functions and lambda expressions as event handlers. This functionality is provided in the [Event module](http://msdn.microsoft.com/en-us/library/8b883baa-a460-4840-9baa-de8260351bc7).

To create an event on a class that acts just like any other .NET Framework event, add to the class a **let** binding that defines an **Event** as a field in a class. You can specify the desired event argument type as the type argument, or leave it blank and have the compiler infer the appropriate type. You also must define an event member that exposes the event as a CLI event. This member should have the [CLIEvent](http://msdn.microsoft.com/en-us/library/d359f1dd-ffa5-42fb-8808-b4c8131a0333) attribute. It is declared like a property and its implementation is just a call to the [Publish](http://msdn.microsoft.com/en-us/library/b0fdaad5-25e5-43d0-9c0c-ce37c4aeb68e) property of the event. Users of your class can use the **Add** method of the published event to add a handler. The argument for the **Add** method can be a lambda expression. You can use the **Trigger** property of the event to raise the event, passing the arguments to the handler function. The following code example illustrates this. In this example, the inferred type argument for the event is a tuple, which represents the arguments for the lambda expression.

```

open System.Collections.Generic

type MyClassWithCLIEvent() =

    let event1 = new Event<_>()

    [<CLIEvent>]
    member this.Event1 = event1.Publish

    member this.TestEvent(arg) =
        event1.Trigger(this, arg)

let classWithEvent = new MyClassWithCLIEvent()
classWithEvent.Event1.Add(fun (sender, arg) -> 
        printfn "Event1 occurred! Object data: %s" arg)

classWithEvent.TestEvent("Hello World!")

System.Console.ReadLine() |> ignore
```

    The output is as follows.


```
Event1 occurred! Object data: Hello World!
```
The additional functionality provided by the **Event** module is illustrated here. The following code example illustrates the basic use of **Event.create** to create an event and a trigger method, add two event handlers in the form of lambda expressions, and then trigger the event to execute both lambda expressions.

```

type MyType() =
    let myEvent = new Event<_>()

    member this.AddHandlers() =
       Event.add (fun string1 -> printfn "%s" string1) myEvent.Publish
       Event.add (fun string1 -> printfn "Given a value: %s" string1) myEvent.Publish

    member this.Trigger(message) =
       myEvent.Trigger(message)

let myMyType = MyType()
myMyType.AddHandlers()
myMyType.Trigger("Event occurred.")
```

    The output of the previous code is as follows.


```
Event occurred.
Given a value: Event occurred.
```

## Processing Event Streams
Instead of just adding an event handler for an event by using the [Event.add](http://msdn.microsoft.com/en-us/library/10670d3b-8d47-4f6e-b8df-ebc6f64ef4fd) function, you can use the functions in the **Event** module to process streams of events in highly customized ways. To do this, you use the forward pipe (**|&gt;**) together with the event as the first value in a series of function calls, and the **Event** module functions as subsequent function calls.

The following code example shows how to set up an event for which the handler is only called under certain conditions.

```

    let form = new Form(Text = "F# Windows Form",
                        Visible = true,
                        TopMost = true)
    form.MouseMove
        |> Event.filter ( fun evArgs -> evArgs.X > 100 && evArgs.Y > 100)
        |> Event.add ( fun evArgs ->
            form.BackColor <- System.Drawing.Color.FromArgb(
                evArgs.X, evArgs.Y, evArgs.X ^^^ evArgs.Y) )
```

    The [Observable module](http://msdn.microsoft.com/en-us/library/16b8610b-b30a-4df7-aa99-d9d352276227) contains similar functions that operate on observable objects. Observable objects are similar to events but only actively subscribe to events if they themselves are being subscribed to.


## Implementing an Interface Event
As you develop UI components, you often start by creating a new form or a new control that inherits from an existing form or control. Events are frequently defined on an interface, and, in that case, you must implement the interface to implement the event. The **T:System.ComponentModel.INotifyPropertyChanged** interface defines a single **E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged** event. The following code illustrates how to implement the event that this inherited interface defined:


```f#
module CustomForm

open System.Windows.Forms
open System.ComponentModel

type AppForm() as this =
inherit Form()

// Define the propertyChanged event.
let propertyChanged = Event<PropertyChangedEventHandler, PropertyChangedEventArgs>()
let mutable underlyingValue = "text0"

// Set up a click event to change the properties.
do
this.Click |> Event.add(fun evArgs -> this.Property1 <- "text2"
this.Property2 <- "text3")

// This property does not have the property-changed event set.
member val Property1 : string = "text" with get, set

// This property has the property-changed event set.
member this.Property2
with get() = underlyingValue
and set(newValue) =
underlyingValue <- newValue
propertyChanged.Trigger(this, new PropertyChangedEventArgs("Property2"))

// Expose the PropertyChanged event as a first class .NET event.
[<CLIEvent>]
member this.PropertyChanged = propertyChanged.Publish


// Define the add and remove methods to implement this interface.
interface INotifyPropertyChanged with
member this.add_PropertyChanged(handler) = propertyChanged.Publish.AddHandler(handler)
member this.remove_PropertyChanged(handler) = propertyChanged.Publish.RemoveHandler(handler)

// This is the event-handler method.
member this.OnPropertyChanged(args : PropertyChangedEventArgs) =
let newProperty = this.GetType().GetProperty(args.PropertyName)
let newValue = newProperty.GetValue(this :> obj) :?> string
printfn "Property %s changed its value to %s" args.PropertyName newValue

// Create a form, hook up the event handler, and start the application.
let appForm = new AppForm()
let inpc = appForm :> INotifyPropertyChanged
inpc.PropertyChanged.Add(appForm.OnPropertyChanged)
Application.Run(appForm)
```
If you want to hook up the event in the constructor, the code is a bit more complicated because the event hookup must be in a **then** block in an additional constructor, as in the following example:


```f#
module CustomForm

open System.Windows.Forms
open System.ComponentModel

// Create a private constructor with a dummy argument so that the public
// constructor can have no arguments.
type AppForm private (dummy) as this =
inherit Form()

// Define the propertyChanged event.
let propertyChanged = Event<PropertyChangedEventHandler, PropertyChangedEventArgs>()
let mutable underlyingValue = "text0"

// Set up a click event to change the properties.
do
this.Click |> Event.add(fun evArgs -> this.Property1 <- "text2"
this.Property2 <- "text3")


// This property does not have the property changed event set.
member val Property1 : string = "text" with get, set

// This property has the property changed event set.
member this.Property2
with get() = underlyingValue
and set(newValue) =
underlyingValue <- newValue
propertyChanged.Trigger(this, new PropertyChangedEventArgs("Property2"))

[<CLIEvent>]
member this.PropertyChanged = propertyChanged.Publish

// Define the add and remove methods to implement this interface.
interface INotifyPropertyChanged with
member this.add_PropertyChanged(handler) = this.PropertyChanged.AddHandler(handler)
member this.remove_PropertyChanged(handler) = this.PropertyChanged.RemoveHandler(handler)

// This is the event handler method.
member this.OnPropertyChanged(args : PropertyChangedEventArgs) =
let newProperty = this.GetType().GetProperty(args.PropertyName)
let newValue = newProperty.GetValue(this :> obj) :?> string
printfn "Property %s changed its value to %s" args.PropertyName newValue

new() as this =
new AppForm(0)
then
let inpc = this :> INotifyPropertyChanged
inpc.PropertyChanged.Add(this.OnPropertyChanged)


// Create a form, hook up the event handler, and start the application.
let appForm = new AppForm()
Application.Run(appForm)
```

## See Also
[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

[Handling and Raising Events](Handling+and+Raising+Events.md)

[Lambda Expressions: The fun Keyword &#40;F&#35;&#41;](Lambda+Expressions+-+The+fun+Keyword+%28F%23%29.md)

[Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+%28F%23%29.md)

[Control.Event&#60;'T&#62; Class &#40;F&#35;&#41;](Control.EventL%27TR+Class+%28F%23%29.md)

[Control.Event&#60;'Delegate,'Args&#62; Class &#40;F&#35;&#41;](Control.EventL%27Delegate%2C%27ArgsR+Class+%28F%23%29.md)

