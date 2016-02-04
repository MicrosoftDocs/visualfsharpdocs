# Operators.( <||| )<'T1,'T2,'T3,'U> Function (F#)

Apply a function to three values, the values being a triple on the right, the function on the left

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( <||| ) : ('T1 -> 'T2 -> 'T3 -> 'U) -> 'T1 * 'T2 * 'T3 -> 'U

// Usage:
func <||| (arg1, arg2, arg3)


```



#### CAPS_PARAMETERS_MD
*func*
Type: **'T1 -&gt; 'T2 -&gt; 'T3 -&gt; 'U**


The function.


*arg1*
Type: **'T1**


The first argument.


*arg2*
Type: **'T2**


The second argument.


*arg3*
Type: **'T3**


The third argument.



**The function result.**
## CAPS_REMARKS_MD
**The following code demonstrates the use of the &lt;||| operator.**


```



     let append4 string1 string2 string3 = string1 + "." + string2 + "." + string3

     // The <||| operator
     let result3 = append4 <||| ("abc", "def", "ghi")
     printfn "append4 <||| (\"abc\", \"def\", \"ghi\") gives  %A" result3


```



**append4 &lt;||| ("abc", "def", "ghi") gives  "abc.def.ghi"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

