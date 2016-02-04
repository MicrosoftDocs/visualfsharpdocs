# Operators.( <| )<'T,'U> Function (F#)

Applies a function to a value, the value being on the right, the function on the left.

**Namespace/Module Path:** Microsoft.FSharp.Core.Operators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( <| ) : ('T -> 'U) -> 'T -> 'U

// Usage:
func <| arg1


```



#### CAPS_PARAMETERS_MD
*func*
Type: **'T -&gt; 'U**


The function.


*arg1*
Type: **'T**


The argument.



**The function result.**
## CAPS_REMARKS_MD
The function is referred to as the *backward* or *reverse pipe operator*.

**The following example demonstrates the use of the &lt;| operator.**


```



    let append1 string1 = string1 + ".append1"
    let append2 string1 = string1 + ".append2"

    let result1 = append1 <| "abc"
    printfn "append1 <| \"abc\" gives %A" result1

    // Reverse pipelines require parentheses.
    let result2 :string = append2 <| (append1 <| "abc")
    printfn "result2: %A" result2

    // Reverse pipelines can be used to eliminate the need for
    // parentheses in some expressions.
    raise <| new System.Exception("A failure occurred.")


```



**append1 &lt;| "abc" gives "abc.append1"**
**result2: "abc.append1.append2"**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

