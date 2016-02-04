# Operators.( |||> )<'T1,'T2,'T3,'U> Function (F#)

Applies a function to three values, the values being a triple on the left, the function on the right.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( |||> ) : 'T1 * 'T2 * 'T3 -> ('T1 -> 'T2 -> 'T3 -> 'U) -> 'U

// Usage:
(arg1, arg2, arg3) |||> func


```



#### CAPS_PARAMETERS_MD
*arg1*
Type: **'T1**


The first argument.


*arg2*
Type: **'T2**


The second argument.


*arg3*
Type: **'T3**


The third argument.


*func*
Type: **'T1 -&gt; 'T2 -&gt; 'T3 -&gt; 'U**


The function.



**The function result.**
## CAPS_REMARKS_MD
**The following example demonstrates the use of the |||&gt; operator.**


```



    let append4 string1 string2 string3 = string1 + "." + string2 + "." + string3

    // The |||> operator
    let result3 = ("abc", "def", "ghi") |||> append4
    printfn "(\"abc\", \"def\", \"ghi\") |||> append4 gives  %A" result3


```



**("abc", "def", "ghi") |||&gt; append4 gives  "abc.def.ghi"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

