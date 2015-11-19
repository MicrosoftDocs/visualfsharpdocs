# Indexed Properties (F#)

*Indexed properties* are properties that provide array-like access to ordered data.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Indexed property that has both get and set defined.
member self-identifier.PropertyName
with get(index-variable) =
get-function-body
and set index-variablesvalue-variables =
set-function-body

// Indexed property that has get only.
member self-identifier.PropertyName(index-variable) =
get-function-body

// Alternative syntax for indexed property with get only
member self-identifier.PropertyName
with get(index-variables) =
get-function-body

// Indexed property that has set only.
member self-identifier.PropertyName
with set index-variablesvalue-variables = 
set-function-body
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The three forms of the previous syntax show how to define indexed properties that have both a **get** and a **set** method, have a **get** method only, or have a **set** method only. You can also combine both the syntax shown for get only and the syntax shown for set only, and produce a property that has both get and set. This latter form allows you to put different accessibility modifiers and attributes on the get and set methods.

When the *PropertyName* is **Item**, the compiler treats the property as a default indexed property. A *default indexed property* is a property that you can access by using array-like syntax on the object instance. For example, if **obj** is an object of the type that defines this property, the syntax **obj.[index]** is used to access the property.

The syntax for accessing a nondefault indexed property is to provide the name of the property and the index in parentheses. For example, if the property is **Ordinal**, you write **obj.Ordinal(index)** to access it.

Regardless of which form you use, you should always use the curried form for the **set** method on an indexed property. For information about curried functions, see [Functions &#40;F&#35;&#41;](Functions+28%F%2329%.md).

**The following code example illustrates the definition and use of default and non-default indexed properties that have get and set methods.**
**[!CODE [FsLangRef1#3301](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/indexedproperties.fs#3301)]**
## Output

```
ONE two three four five six seven eight nine ten
ONE first two second three third four fourth five fifth six 6th
seven seventh eight eighth nine ninth ten tenth
```

## Indexed Properties with Multiple Index Variables
Indexed properties can have more than one index variable. In that case, the variables are separated by commas when the property is used. The set method in such a property must have two curried arguments, the first of which is a tuple containing the keys, and the second of which is the value being set.

The following code demonstrates the use of an indexed property with multiple index variables.

[!CODE [FsLangRef1#3302](../CodeSnippet/VS_Snippets_Fsharp/fslangref1/FSharp/fs/indexedproperties.fs#3302)]
    
## See Also
[Members &#40;F&#35;&#41;](Members+28%F%2329%.md)

