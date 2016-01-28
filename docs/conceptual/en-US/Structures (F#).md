# Structures (F#)

A *structure* is a compact object type that can be more efficient than a class for types that have a small amount of data and simple behavior.


## CAPS_SYNTAX_MD

```
[ attributes ]
type [accessibility-modifier] type-name =
struct
type-definition-elements
end
// or
[ attributes ]
[<StructAttribute>]
type [accessibility-modifier] type-name =
type-definition-elements
```

## CAPS_REMARKS_MD
Structures are *value types*, which means that they are stored directly on the stack or, when they are used as fields or array elements, inline in the parent type. Unlike classes and records, structures have pass-by-value semantics. This means that they are useful primarily for small aggregates of data that are accessed and copied frequently.

In the previous syntax, two forms are shown. The first is not the lightweight syntax, but it is nevertheless frequently used because, when you use the **struct** and **end** keywords, you can omit the **StructAttribute** attribute, which appears in the second form. You can abbreviate **StructAttribute** to just **Struct**.

The *type-definition-elements* in the previous syntax represents member declarations and definitions. Structures can have constructors and mutable and immutable fields, and they can declare members and interface implementations. For more information, see [Members &#40;F&#35;&#41;](Members+%28F%23%29.md).

Structures cannot participate in inheritance, cannot contain **let** or **do** bindings, and cannot recursively contain fields of their own type (although they can contain reference cells that reference their own type).

Because structures do not allow **let** bindings, you must declare fields in structures by using the **val** keyword. The **val** keyword defines a field and its type but does not allow initialization. Instead, **val** declarations are initialized to zero or null. For this reason, structures that have an implicit constructor (that is, parameters that are given immediately after the structure name in the declaration) require that **val** declarations be annotated with the **DefaultValue** attribute. Structures that have a defined constructor still support zero-initialization. Therefore, the **DefaultValue** attribute is a declaration that such a zero value is valid for the field. Implicit constructors for structures do not perform any actions because **let** and **do** bindings aren’t allowed on the type, but the implicit constructor parameter values passed in are available as private fields.

Explicit constructors might involve initialization of field values. When you have a structure that has an explicit constructor, it still supports zero-initialization; however, you do not use the **DefaultValue** attribute on the **val** declarations because it conflicts with the explicit constructor. For more information about **val** declarations, see [Explicit Fields: The val Keyword &#40;F&#35;&#41;](Explicit+Fields+-+The+val+Keyword+%28F%23%29.md).

Attributes and accessibility modifiers are allowed on structures, and follow the same rules as those for other types. For more information, see [Attributes &#40;F&#35;&#41;](Attributes+%28F%23%29.md) and [Access Control &#40;F&#35;&#41;](Access+Control+%28F%23%29.md).

The following code examples illustrate structure definitions.

```

// In Point3D, three immutable values are defined.
// x, y, and z will be initialized to 0.0.
type Point3D =
   struct
      val x: float
      val y: float
      val z: float
   end

// In Point2D, two immutable values are defined.
// Point2D has an explicit constructor.
// You can create zero-initialized instances of Point2D, or you can
// pass in arguments to initialize the values.
type Point2D =
   struct
      val X: float
      val Y: float
      new(x: float, y: float) = { X = x; Y = y }
   end
```

    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Classes &#40;F&#35;&#41;](Classes+%28F%23%29.md)

[Records &#40;F&#35;&#41;](Records+%28F%23%29.md)

[Members &#40;F&#35;&#41;](Members+%28F%23%29.md)

