# Options (F#)

The option type in F# is used when an actual value might not exist for a named value or variable. An option has an underlying type and can hold a value of that type, or it might not have a value.


## CAPS_REMARKS_MD
The following code illustrates the use of the option type.



```



let keepIfPositive (a : int) = if a > 0 then Some(a) else None


```



    The value **None** is used when an option does not have an actual value. Otherwise, the expression **Some( ... )** gives the option a value. The values **Some** and **None** are useful in pattern matching, as in the following function **exists**, which returns **true** if the option has a value and **false** if it does not.



```



let exists (x : int option) = 
    match x with
    | Some(x) -> true
    | None -> false


```



    
## Using Options
Options are commonly used when a search does not return a matching result, as shown in the following code.



```



let rec tryFindMatch pred list =
    match list with
    | head :: tail -> if pred(head)
                        then Some(head)
                        else tryFindMatch pred tail
    | [] -> None

// result1 is Some 100 and its type is int option.
let result1 = tryFindMatch (fun elem -> elem = 100) [ 200; 100; 50; 25 ] 

// result2 is None and its type is int option.
let result2 = tryFindMatch (fun elem -> elem = 26) [ 200; 100; 50; 25 ]


```



    In the previous code, a list is searched recursively. The function **tryFindMatch** takes a predicate function **pred** that returns a Boolean value, and a list to search. If an element that satisfies the predicate is found, the recursion ends and the function returns the value as an option in the expression **Some(head)**. The recursion ends when the empty list is matched. At that point the value **head** has not been found, and **None** is returned.

Many F# library functions that search a collection for a value that may or may not exist return the **option** type. By convention, these functions begin with the **try** prefix, for example, [Seq.tryFindIndex](http://msdn.microsoft.com/en-us/library/c357b221-edf6-4f68-bf40-82a3156d945a).

Options can also be useful when a value might not exist, for example if it is possible that an exception will be thrown when you try to construct a value. The following code example illustrates this.



```



open System.IO
let openFile filename =
    try
        let file = File.Open (filename, FileMode.Create)
        Some(file)
    with
        | ex -> eprintf "An exception occurred with message %s" ex.Message
                None    


```



    The **openFile** function in the previous example has type **string -&gt; File option** because it returns a **File** object if the file opens successfully and **None** if an exception occurs. Depending on the situation, it may not be an appropriate design choice to catch an exception rather than allowing it to propagate.


## Option Properties and Methods
The option type supports the following properties and methods.



|Property or method|Type|Description|
|------------------|----|-----------|
|[None](http://msdn.microsoft.com/en-us/library/83ef260a-aa33-4e6f-aee6-b9bf0a461476)|**'T option**|A static property that enables you to create an option value that has the **None** value.|
|[IsNone](http://msdn.microsoft.com/en-us/library/f08532ca-1716-4f60-ae59-8ef6256df234)|**bool**|Returns **true** if the option has the **None** value.|
|[IsSome](http://msdn.microsoft.com/en-us/library/c5088d51-c5d7-425f-a77f-12c379bb356f)|**bool**|Returns **true** if the option has a value that is not **None**.|
|[Some](http://msdn.microsoft.com/en-us/library/12f048d2-e293-4596-accb-de036ecd63fc)|**'T option**|A static member that creates an option that has a value that is not **None**.|
|[Value](http://msdn.microsoft.com/en-us/library/c79f68e8-11fd-45b1-a053-e8fc38b56df7)|**'T**|Returns the underlying value, or throws a **T:System.NullReferenceException** if the value is **None**.|

## Option Module
There is a module, [Option](http://msdn.microsoft.com/en-us/library/e615e4d3-bbbb-49ba-addc-6061ea2e2f4c), that contains useful functions that perform operations on options. Some functions repeat the functionality of the properties but are useful in contexts where a function is needed. [Option.isSome](http://msdn.microsoft.com/en-us/library/41ad0857-5672-4326-84b5-c33dc43dcf79) and [Option.isNone](http://msdn.microsoft.com/en-us/library/73db6a53-15e7-40a6-94f9-a0049e5f4819) are both module functions that test whether an option holds a value. [Option.get](http://msdn.microsoft.com/en-us/library/803e9fcb-6edd-4910-808c-25f08cbc55ea) obtains the value, if there is one. If there is no value, it throws **T:System.ArgumentException**.

The [Option.bind](http://msdn.microsoft.com/en-us/library/c3406192-24ac-49b5-bc3b-8f805187f1c0) function executes a function on the value, if there is a value. The function must take exactly one argument, and its parameter type must be the option type. The return value of the function is another option type.

The option module also includes functions that correspond to the functions that are available for lists, arrays, sequences, and other collection types. These functions include [Option.map](http://msdn.microsoft.com/en-us/library/91a20385-7e73-40c2-9adc-635e86d6a622), [Option.iter](http://msdn.microsoft.com/en-us/library/83389eef-3dff-4074-b4cc-f69581c25191), [Option.forall](http://msdn.microsoft.com/en-us/library/ba884586-5eae-49c5-9e36-05481c1c3428), [Option.exists](http://msdn.microsoft.com/en-us/library/a606d2d4-fddc-4eab-ab37-c6138fb7ad99), [Option.foldBack](http://msdn.microsoft.com/en-us/library/a882fbaf-c019-46f0-b4f5-b8c2b8b90ffb), [Option.fold](http://msdn.microsoft.com/en-us/library/af896794-3d53-406c-9411-316cd5c33ad8), and [Option.count](http://msdn.microsoft.com/en-us/library/2dac83a9-684e-4d0f-b50e-ff722a8bb876). These functions enable options to be used like a collection of zero or one elements. For more information and examples, see the discussion of collection functions in [Lists](http://msdn.microsoft.com/en-us/library/83102799-f251-42e1-93ef-64232e8c5b1d).


## Converting to Other Types
Options can be converted to lists or arrays. When an option is converted into either of these data structures, the resulting data structure has zero or one element. To convert an option to an array, use [Option.toArray](http://msdn.microsoft.com/en-us/library/c8044873-ba17-4b52-8231-eb1a28318c64). To convert an option to a list, use [Option.toList](http://msdn.microsoft.com/en-us/library/5f1af295-9fa9-40ad-b4a1-3578d94d44e1).


## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[F&#35; Types](F%23+Types.md)

