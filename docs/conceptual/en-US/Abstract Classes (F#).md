# Abstract Classes (F#)

*Abstract classes* are classes that leave some or all members unimplemented, so that implementations can be provided by derived classes.


## CAPS_SYNTAX_MD



```


// Abstract class syntax.
[<AbstractClass>]
type [ accessibility-modifier ] abstract-class-name =
[ inherit base-class-or-interface-name ]
[ abstract-member-declarations-and-member-definitions ]

// Abstract member syntax.
abstract member member-name : type-signature


```



## CAPS_REMARKS_MD
In object-oriented programming, an abstract class is used as a base class of a hierarchy, and represents common functionality of a diverse set of object types. As the name "abstract" implies, abstract classes often do not correspond directly onto concrete entities in the problem domain. However, they do represent what many different concrete entities have in common.

Abstract classes must have the **AbstractClass** attribute. They can have implemented and unimplemented members. The use of the term *abstract* when applied to a class is the same as in other .NET languages; however, the use of the term *abstract* when applied to methods (and properties) is a little different in F# from its use in other .NET languages. In F#, when a method is marked with the **abstract** keyword, this indicates that a member has an entry, known as a *virtual dispatch slot*, in the internal table of virtual functions for that type. In other words, the method is virtual, although the **virtual** keyword is not used in the F# language. The keyword **abstract** is used on virtual methods regardless of whether the method is implemented. The declaration of a virtual dispatch slot is separate from the definition of a method for that dispatch slot. Therefore, the F# equivalent of a virtual method declaration and definition in another .NET language is a combination of both an abstract method declaration and a separate definition, with either the **default** keyword or the **override** keyword. For more information and examples, see [Methods &#40;F&#35;&#41;](Methods+%28F%23%29.md).

A class is considered abstract only if there are abstract methods that are declared but not defined. Therefore, classes that have abstract methods are not necessarily abstract classes. Unless a class has undefined abstract methods, do not use the **AbstractClass** attribute.

In the previous syntax, *accessibility-modifier* can be **public**, **private** or **internal**. For more information, see [Access Control &#40;F&#35;&#41;](Access+Control+%28F%23%29.md).

As with other types, abstract classes can have a base class and one or more base interfaces. Each base class or interface appears on a separate line together with the **inherit** keyword.

The type definition of an abstract class can contain fully defined members, but it can also contain abstract members. The syntax for abstract members is shown separately in the previous syntax. In this syntax, the *type signature* of a member is a list that contains the parameter types in order and the return types, separated by **-&gt;** tokens and/or **&#42;** tokens as appropriate for curried and tupled parameters. The syntax for abstract member type signatures is the same as that used in signature files and that shown by IntelliSense in the Visual Studio Code Editor.

**The following code illustrates an abstract class Shape, which has two non-abstract derived classes, Square and Circle. The example shows how to use abstract classes, methods, and properties. In the example, the abstract class Shape represents the common elements of the concrete entities circle and square. The common features of all shapes (in a two-dimensional coordinate system) are abstracted out into the Shape class: the position on the grid, an angle of rotation, and the area and perimeter properties. These can be overridden, except for position, the behavior of which individual shapes cannot change.**
**The rotation method can be overridden, as in the Circle class, which is rotation invariant because of its symmetry. So in the Circle class, the rotation method is replaced by a method that does nothing.**


```



// An abstract class that has some methods and properties defined
// and some left abstract.
[<AbstractClass>]
type Shape2D(x0 : float, y0 : float) =
    let mutable x, y = x0, y0
    let mutable rotAngle = 0.0

    // These properties are not declared abstract. They
    // cannot be overriden.
    member this.CenterX with get() = x and set xval = x <- xval
    member this.CenterY with get() = y and set yval = y <- yval

    // These properties are abstract, and no default implementation
    // is provided. Non-abstract derived classes must implement these.
    abstract Area : float with get
    abstract Perimeter : float  with get
    abstract Name : string with get

    // This method is not declared abstract. It cannot be
    // overriden.
    member this.Move dx dy =
       x <- x + dx
       y <- y + dy
  
    // An abstract method that is given a default implementation
    // is equivalent to a virtual method in other .NET languages.
    // Rotate changes the internal angle of rotation of the square.
    // Angle is assumed to be in degrees.
    abstract member Rotate: float -> unit
    default this.Rotate(angle) = rotAngle <- rotAngle + angle

type Square(x, y, sideLengthIn) =
    inherit Shape2D(x, y)
    member this.SideLength = sideLengthIn
    override this.Area = this.SideLength * this.SideLength
    override this.Perimeter = this.SideLength * 4.
    override this.Name = "Square"

type Circle(x, y, radius) =
    inherit Shape2D(x, y)
    let PI = 3.141592654
    member this.Radius = radius
    override this.Area = PI * this.Radius * this.Radius
    override this.Perimeter = 2. * PI * this.Radius
    // Rotating a circle does nothing, so use the wildcard
    // character to discard the unused argument and 
    // evaluate to unit.
    override this.Rotate(_) = ()
    override this.Name = "Circle"

let square1 = new Square(0.0, 0.0, 10.0)
let circle1 = new Circle(0.0, 0.0, 5.0)
circle1.CenterX <- 1.0
circle1.CenterY <- -2.0
square1.Move -1.0 2.0
square1.Rotate 45.0
circle1.Rotate 45.0
printfn "Perimeter of square with side length %f is %f, %f"
        (square1.SideLength) (square1.Area) (square1.Perimeter)
printfn "Circumference of circle with radius %f is %f, %f"
        (circle1.Radius) (circle1.Area) (circle1.Perimeter)

let shapeList : list<Shape2D> = [ (square1 :> Shape2D);
                                  (circle1 :> Shape2D) ]
List.iter (fun (elem : Shape2D) ->
              printfn "Area of %s: %f" (elem.Name) (elem.Area))
          shapeList


```



**// Output:**
**Perimeter of square with side length 10.000000 is 40.000000**
**Circumference of circle with radius 5.000000 is 31.415927**
**Area of Square: 100.000000**
**Area of Circle: 78.539816**
## See Also
[Classes &#40;F&#35;&#41;](Classes+%28F%23%29.md)

[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

[Methods &#40;F&#35;&#41;](Methods+%28F%23%29.md)

[Properties &#40;F&#35;&#41;](Properties+%28F%23%29.md)

