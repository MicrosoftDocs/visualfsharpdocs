# Array.create<'T> Function (F#)

Creates an array whose elements are all initially the given value.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Array

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Array.create : int -> 'T -> 'T []

// Usage:
Array.create count value
```

#### CAPS_PARAMETERS_MD
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The length of the array to create.


*value*
Type: **'T**


The value for the elements.



**The created array.**
## CAPS_REMARKS_MD
This function is named **Create** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of Array.create as well as setting and getting array values.**
```

    let array1 = Array.create 10 ""
    for i in 0 .. array1.Length - 1 do
        Array.set array1 i (i.ToString())
    for i in 0 .. array1.Length - 1 do
        printf "%s " (Array.get array1 i)
```

**0 1 2 3 4 5 6 7 8 9**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Array Module &#40;F&#35;&#41;](Collections.Array+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

