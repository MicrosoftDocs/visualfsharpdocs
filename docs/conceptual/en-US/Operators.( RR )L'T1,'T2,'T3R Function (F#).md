# Operators.( >> )<'T1,'T2,'T3> Function (F#)

Composes two functions, the function on the left being applied first

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( >> ) : ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3

// Usage:
func1 >> func2


```



#### CAPS_PARAMETERS_MD
*func1*
Type: **'T1 -&gt; 'T2**


The first function to apply.


*func2*
Type: **'T2 -&gt; 'T3**


The second function to apply.



**The composition of the input functions.**
## CAPS_REMARKS_MD
**The following example demonstrates the use of the composition operator (&gt;&gt;).**


```



    let append1 string1 = string1 + ".append1"
    let append2 string1 = string1 + ".append2"

    // Composition of two functions.
    let appendBoth = append1 >> append2
    printfn "%s" (appendBoth "abc")

    // Composition of three functions.
    let append3 string1 = string1 + ".append3"
    printfn "%s" ((append1 >> append2 >> append3) "abc")

    // Composition of functions with more than one parameter.
    let appendString (string1:string) (string2:string) = string1 + string2

    let appendFileExtension extension =
        appendString "." >> appendString extension
    printfn "%s" (appendFileExtension "myfile" "txt")


```



**abc.append1.append2**
**abc.append1.append2.append3**
**myfile.txt**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

