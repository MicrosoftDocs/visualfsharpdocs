# Enumerations (F#)

*Enumerations*, also known as *enums*, , are integral types where labels are assigned to a subset of the values. You can use them in place of literals to make code more readable and maintainable.


## CAPS_SYNTAX_MD

```
type enum-name =
| value1 = integer-literal1
| value2 = integer-literal2
...
```

## CAPS_REMARKS_MD
An enumeration looks much like a discriminated union that has simple values, except that the values can be specified. The values are typically integers that start at 0 or 1, or integers that represent bit positions. If an enumeration is intended to represent bit positions, you should also use the **T:System.FlagsAttribute** attribute.

The underlying type of the enumeration is determined from the literal that is used, so that, for example, you can use literals with a suffix, such as **1u**, **2u**, and so on, for an unsigned integer (**uint32**) type.

When you refer to the named values, you must use the name of the enumeration type itself as a qualifier, that is, **enum-name.value1**, not just **value1**. This behavior differs from that of discriminated unions. This is because enumerations always have the [RequireQualifiedAccess](http://msdn.microsoft.com/en-us/library/8b9b6ade-0471-4413-ac5d-638cd0de5f15) attribute.

The following code shows the declaration and use of an enumeration.

[!CODE [FsLangRef1#2101](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/enumerations.fs#2101)]
    You can easily convert enumerations to the underlying type by using the appropriate operator, as shown in the following code.

[!CODE [FsLangRef1#2102](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/enumerations.fs#2102)]
    Enumerated types can have one of the following underlying types: **sbyte**, **byte**, **int16**, **uint16**, **int32**, **uint32**, **int64**, **uint16**, **uint64**, and **char**. Enumeration types are represented in the .NET Framework as types that are inherited from **T:System.Enum**, which in turn is inherited from **T:System.ValueType**. Thus, they are value types that are located on the stack or inline in the containing object, and any value of the underlying type is a valid value of the enumeration. This is significant when pattern matching on enumeration values, because you have to provide a pattern that catches the unnamed values.

The **enum** function in the F# library can be used to generate an enumeration value, even a value other than one of the predefined, named values. You use the **enum** function as follows.

[!CODE [FsLangRef1#2103](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/enumerations.fs#2103)]
    The default **enum** function works with type **int32**. Therefore, it cannot be used with enumeration types that have other underlying types. Instead, use the following.

[!CODE [FsLangRef1#2104](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/enumerations.fs#2104)]
    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Casting and Conversions &#40;F&#35;&#41;](Casting+and+Conversions+%28F%23%29.md)

