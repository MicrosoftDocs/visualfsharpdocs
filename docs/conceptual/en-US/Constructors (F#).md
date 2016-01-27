# Constructors (F#)

This topic describes how to define and use constructors to create and initialize class and structure objects.


## Construction of Class Objects
Objects of class types have constructors. There are two kinds of constructors. One is the primary constructor, whose parameters appear in parentheses just after the type name. You specify other, optional additional constructors by using the **new** keyword. Any such additional constructors must call the primary constructor.

The primary constructor contains **let** and **do** bindings that appear at the start of the class definition. A **let** binding declares private fields and methods of the class; a **do** binding executes code. For more information about **let** bindings in class constructors, see [let Bindings in Classes &#40;F&#35;&#41;](let+Bindings+in+Classes+%28F%23%29.md). For more information about **do** bindings in constructors, see [do Bindings in Classes &#40;F&#35;&#41;](do+Bindings+in+Classes+%28F%23%29.md).

Regardless of whether the constructor you want to call is a primary constructor or an additional constructor, you can create objects by using a **new** expression, with or without the optional **new** keyword. You initialize your objects together with constructor arguments, either by listing the arguments in order and separated by commas and enclosed in parentheses, or by using named arguments and values in parentheses. You can also set properties on an object during the construction of the object by using the property names and assigning values just as you use named constructor arguments.

The following code illustrates a class that has a constructor and various ways of creating objects.

```

 // This class has a primary constructor that takes three arguments
 // and an additional constructor that calls the primary constructor.
 type MyClass(x0, y0, z0) =
     let mutable x = x0
     let mutable y = y0
     let mutable z = z0
     do
         printfn "Initialized object that has coordinates (%d, %d, %d)" x y z
     member this.X with get() = x and set(value) = x <- value
     member this.Y with get() = y and set(value) = y <- value
     member this.Z with get() = z and set(value) = z <- value
     new() = MyClass(0, 0, 0)

 // Create by using the new keyword.
 let myObject1 = new MyClass(1, 2, 3)
 // Create without using the new keyword.
 let myObject2 = MyClass(4, 5, 6)
 // Create by using named arguments.
 let myObject3 = MyClass(x0 = 7, y0 = 8, z0 = 9)
 // Create by using the additional constructor.
 let myObject4 = MyClass()
```

    The output is as follows.


```
Initialized object that has coordinates (1, 2, 3)
Initialized object that has coordinates (4, 5, 6)
Initialized object that has coordinates (7, 8, 9)
Initialized object that has coordinates (0, 0, 0)
```

## Construction of Structures
Structures follow all the rules of classes. Therefore, you can have a primary constructor, and you can provide additional constructors by using **new**. However, there is one important difference between structures and classes: structures can have a default constructor (that is, one with no arguments) even if no primary constructor is defined. The default constructor initializes all the fields to the default value for that type, usually zero or its equivalent. Any constructors that you define for structures must have at least one argument so that they do not conflict with the default constructor.

Also, structures often have fields that are created by using the **val** keyword; classes can also have these fields. Structures and classes that have fields defined by using the **val** keyword can also be initialized in additional constructors by using record expressions, as shown in the following code.

```

 type MyStruct =
     struct
        val X : int
        val Y : int
        val Z : int
        new(x, y, z) = { X = x; Y = y; Z = z }
     end

 let myStructure1 = new MyStruct(1, 2, 3) 
```

    For more information, see [Explicit Fields: The val Keyword &#40;F&#35;&#41;](Explicit+Fields%3A+The+val+Keyword+%28F%23%29.md).


## Executing Side Effects in Constructors
A primary constructor in a class can execute code in a **do** binding. However, what if you have to execute code in an additional constructor, without a **do** binding? To do this, you use the **then** keyword.

```

  // Executing side effects in the primary constructor and
 // additional constructors.
 type Person(nameIn : string, idIn : int) =
     let mutable name = nameIn
     let mutable id = idIn
     do printfn "Created a person object."
     member this.Name with get() = name and set(v) = name <- v
     member this.ID with get() = id and set(v) = id <- v
     new() = 
         Person("Invalid Name", -1)
         then
             printfn "Created an invalid person object."

 let person1 = new Person("Humberto Acevedo", 123458734)
 let person2 = new Person()
```

    The side effects of the primary constructor still execute. Therefore, the output is as follows.


```
Created a person object.
Created a person object.
Created an invalid person object.
```

## Self Identifiers in Constructors
In other members, you provide a name for the current object in the definition of each member. You can also put the self identifier on the first line of the class definition by using the **as** keyword immediately following the constructor parameters. The following example illustrates this syntax.

```

 type MyClass1(x) as this =
     // This use of the self identifier produces a warning - avoid.
     let x1 = this.X
     // This use of the self identifier is acceptable.
     do printfn "Initializing object with X =%d" this.X
     member this.X = x
```

    In additional constructors, you can also define a self identifier by putting the **as** clause right after the constructor parameters. The following example illustrates this syntax.

```

 type MyClass2(x : int) =
     member this.X = x
     new() as this = MyClass2(0) then printfn "Initializing with X = %d" this.X
```

    Problems can occur when you try to use an object before it is fully defined. Therefore, uses of the self identifier can cause the compiler to emit a warning and insert additional checks to ensure the members of an object are not accessed before the object is initialized. You should only use the self identifier in the **do** bindings of the primary constructor, or after the **then** keyword in additional constructors.

The name of the self identifier does not have to be **this**. It can be any valid identifier.


## Assigning Values to Properties at Initialization
You can assign values to the properties of a class object in the initialization code by appending a list of assignments of the form **property = value** to the argument list for a constructor. This is shown in the following code example.

```

  type Account() =
     let mutable balance = 0.0
     let mutable number = 0
     let mutable firstName = ""
     let mutable lastName = ""
     member this.AccountNumber
        with get() = number
        and set(value) = number <- value
     member this.FirstName
        with get() = firstName
        and set(value) = firstName <- value
     member this.LastName
        with get() = lastName
        and set(value) = lastName <- value
     member this.Balance
        with get() = balance
        and set(value) = balance <- value
     member this.Deposit(amount: float) = this.Balance <- this.Balance + amount
     member this.Withdraw(amount: float) = this.Balance <- this.Balance - amount
    
   
 let account1 = new Account(AccountNumber=8782108, 
                            FirstName="Darren", LastName="Parker",
                            Balance=1543.33)
```

    The following version of the previous code illustrates the combination of ordinary arguments, optional arguments, and property settings in one constructor call.

```

  type Account(accountNumber : int, ?first: string, ?last: string, ?bal : float) =
     let mutable balance = defaultArg bal 0.0
     let mutable number = accountNumber
     let mutable firstName = defaultArg first ""
     let mutable lastName = defaultArg last ""
     member this.AccountNumber
        with get() = number
        and set(value) = number <- value
     member this.FirstName
        with get() = firstName
        and set(value) = firstName <- value
     member this.LastName
        with get() = lastName
        and set(value) = lastName <- value
     member this.Balance
        with get() = balance
        and set(value) = balance <- value
     member this.Deposit(amount: float) = this.Balance <- this.Balance + amount
     member this.Withdraw(amount: float) = this.Balance <- this.Balance - amount
   
   
  let account1 = new Account(8782108, bal = 543.33,
                            FirstName="Raman", LastName="Iyer")
```

    
## Static Constructors or Type Constructors
In addition to specifying code for creating objects, static **let** and **do** bindings can be authored in class types that execute before the type is first used to perform initialization at the type level. For more information, see [let Bindings in Classes &#40;F&#35;&#41;](let+Bindings+in+Classes+%28F%23%29.md) and [do Bindings in Classes &#40;F&#35;&#41;](do+Bindings+in+Classes+%28F%23%29.md).


## See Also
[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

