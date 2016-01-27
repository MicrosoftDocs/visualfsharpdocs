# Records (F#)

Records represent simple aggregates of named values, optionally with members.


## CAPS_SYNTAX_MD

```
[ attributes ]
type [accessibility-modifier] typename = { 
[ mutable ] label1 : type1;
[ mutable ] label2 : type2;
...
}
member-list
```

## CAPS_REMARKS_MD
In the previous syntax, *typename* is the name of the record type, *label1* and *label2* are names of values, referred to as *labels*, and *type1* and *type2* are the types of these values. *member-list* is the optional list of members for the type.

Following are some examples.

```

 type Point = { x : float; y: float; z: float; }
 type Customer = { First : string; Last: string; SSN: uint32; AccountNumber : uint32; }
```

    When each label is on a separate line, the semicolon is optional.

You can set values in expressions known as *record expressions*. The compiler infers the type from the labels used (if the labels are sufficiently distinct from those of other record types). Braces ({ }) enclose the record expression. The following code shows a record expression that initializes a record with three float elements with labels **x**, **y** and **z**.

```

    let mypoint = { x = 1.0; y = 1.0; z = -1.0; }
```

    Do not use the shortened form if there could be another type that also has the same labels.

```

 type Point = { x : float; y: float; z: float; }
 type Point3D = { x: float; y: float; z: float }
 // Ambiguity: Point or Point3D?
 let mypoint3D = { x = 1.0; y = 1.0; z = 0.0; }
```

    The labels of the most recently declared type take precedence over those of the previously declared type, so in the preceding example, **mypoint3D** is inferred to be **Point3D**. You can explicitly specify the record type, as in the following code.

```

    let myPoint1 = { Point.x = 1.0; y = 1.0; z = 0.0; }
```

    Methods can be defined for record types just as for class types.


## Creating Records by Using Record Expressions
You can initialize records by using the labels that are defined in the record. An expression that does this is referred to as a *record expression*. Use braces to enclose the record expression and use the semicolon as a delimiter.

The following example shows how to create a record.

```

 type MyRecord = {
     X: int;
     Y: int;
     Z: int 
     }

 let myRecord1 = { X = 1; Y = 2; Z = 3; }
```

    The semicolons after the last field in the record expression and in the type definition are optional, regardless of whether the fields are all in one line.

When you create a record, you must supply values for each field. You cannot refer to the values of other fields in the initialization expression for any field.

In the following code, the type of **myRecord2** is inferred from the names of the fields. Optionally, you can specify the type name explicitly.

```

 let myRecord2 = { MyRecord.X = 1; MyRecord.Y = 2; MyRecord.Z = 3 }
```

    Another form of record construction can be useful when you have to copy an existing record, and possibly change some of the field values. The following line of code illustrates this.

```

 let myRecord3 = { myRecord2 with Y = 100; Z = 2 }
```

    This form of the record expression is called the *copy and update record expression*.

Records are immutable by default; however, you can easily create modified records by using a copy and update expression. You can also explicitly specify a mutable field.

```

type Car = {
    Make : string
    Model : string
    mutable Odometer : int
    }
let myCar = { Make = "Fabrikam"; Model = "Coupe"; Odometer = 108112 }
myCar.Odometer <- myCar.Odometer + 21
```

    Don't use the DefaultValue attribute with record fields. A better approach is to define default instances of records with fields that are initialized to default values and then use a copy and update record expression to set any fields that differ from the default values.


```f#
// Rather than use [<DefaultValue>], define a default record.
type MyRecord =
{ 
field1 : int 
field2 : int
}

let defaultRecord1 = { field1 = 0; field2 = 0 }
let defaultRecord2 = { field1 = 1; field2 = 25 }

// Use the with keyword to populate only a few chosen fields
// and leave the rest with default values.
let rr3 = { defaultRecord1 with field2 = 42 }
```

## Pattern Matching with Records
Records can be used with pattern matching. You can specify some fields explicitly and provide variables for other fields that will be assigned when a match occurs. The following code example illustrates this.

```

type Point3D = { x: float; y: float; z: float }
let evaluatePoint (point: Point3D) =
    match point with
    | { x = 0.0; y = 0.0; z = 0.0 } -> printfn "Point is at the origin."
    | { x = xVal; y = 0.0; z = 0.0 } -> printfn "Point is on the x-axis. Value is %f." xVal
    | { x = 0.0; y = yVal; z = 0.0 } -> printfn "Point is on the y-axis. Value is %f." yVal
    | { x = 0.0; y = 0.0; z = zVal } -> printfn "Point is on the z-axis. Value is %f." zVal
    | { x = xVal; y = yVal; z = zVal } -> printfn "Point is at (%f, %f, %f)." xVal yVal zVal

evaluatePoint { x = 0.0; y = 0.0; z = 0.0 }
evaluatePoint { x = 100.0; y = 0.0; z = 0.0 }
evaluatePoint { x = 10.0; y = 0.0; z = -1.0 }
```

    The output of this code is as follows.


```
Point is at the origin.
Point is on the x-axis. Value is 100.000000.
Point is at (10.000000, 0.000000, -1.000000).
```

## Differences Between Records and Classes
Record fields differ from classes in that they are automatically exposed as properties, and they are used in the creation and copying of records. Record construction also differs from class construction. In a record type, you cannot define a constructor. Instead, the construction syntax described in this topic applies. Classes have no direct relationship between constructor parameters, fields, and properties.

Like union and structure types, records have structural equality semantics. Classes have reference equality semantics. The following code example demonstrates this.

```

type RecordTest = { X: int; Y: int }
let record1 = { X = 1; Y = 2 }
let record2 = { X = 1; Y = 2 }
if (record1 = record2) then
    printfn "The records are equal."
else
    printfn "The records are unequal."
```

    If you write the same code with classes, the two class objects would be unequal because the two values would represent two objects on the heap and only the addresses would be compared (unless the class type overrides the **System.Object.Equals** method).


## See Also
[F&#35; Types](F%23+Types.md)

[Classes &#40;F&#35;&#41;](Classes+%28F%23%29.md)

[F&#35; Language Reference](F%23+Language+Reference.md)

[Pattern Matching &#40;F&#35;&#41;](Pattern+Matching+%28F%23%29.md)

