# Operators.( << )<'T2,'T3,'T1> Function (F#)

Composes two functions, the function on the right being applied first.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
( << ) : ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3

// Usage:
func2 << func1
```

#### CAPS_PARAMETERS_MD
*func2*
Type: **'T2 -&gt; 'T3**


The second function to apply.


*func1*
Type: **'T1 -&gt; 'T2**


The first function to apply.



**The composition of the input functions.**
## CAPS_REMARKS_MD
This operator is referred to as the *backward* or *reverse composition operator*.

**The following example demonstrates the use of the reverse composition operator (&lt;&lt;).**
```

    let append1 string1 = string1 + ".append1"
    let append2 string1 = string1 + ".append2"

    // Reverse composition of two functions.
    let appendBothReverse = append1 << append2
    printfn "%s" (appendBothReverse "abc")

    // Reverse composition of three functions.
    let append3 string1 = string1 + ".append3"
    printfn "%s" ((append1 << append2 << append3) "abc")

    // Reverse composition of functions with more than one parameter.
    let appendString (string1:string) (string2:string) = string1 + string2

    let appendFileExtension extension =
        appendString extension << appendString "." 
    printfn "%s" (appendFileExtension "myfile" "txt")
```

**abc.append2.append1**
**abc.append3.append2.append1**
**myfile.txt**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

