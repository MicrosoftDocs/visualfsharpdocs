# Operators.( ||> )<'T1,'T2,'U> Function (F#)

Apply a function to two values, the values being a pair on the left, the function on the right.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( ||> ) : 'T1 * 'T2 -> ('T1 -> 'T2 -> 'U) -> 'U

// Usage:
(arg1, arg2) ||> func


```



#### CAPS_PARAMETERS_MD
*arg1*
Type: **'T1**


The first argument.


*arg2*
Type: **'T2**


The second argument.


*func*
Type: **'T1 -&gt; 'T2 -&gt; 'U**


The function.



**The function result.**
## CAPS_REMARKS_MD
**The following example demonstrates the use of the ||&gt; operator.**


```



    let append string1 string2 = string1 + "." + string2

    let result1 = ("abc", "def") ||> append
    printfn "(\"abc\", \"def\") ||> append gives %A" result1

    let toUpper (string1:string) (string2:string) = string1.ToUpper(), string2.ToUpper()

    let result2 = ("abc", "def")
                   ||> toUpper
                   ||> append

    printfn "result2: %A" result2


```



**("abc", "def") ||&gt; append gives "abc.def"**
**result2: "ABC.DEF"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

