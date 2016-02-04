# ExtraTopLevelOperators.Lazy<'T> Active Pattern (F#)

An active pattern to force the execution of values of type [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489).

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
( |Lazy| ) : Lazy<'T> -> 'T


```



#### CAPS_PARAMETERS_MD
*input*
Type: [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489)**&lt;'T&gt;**




## CAPS_REMARKS_MD
This function is named **LazyPattern** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code illustrates the use of the Lazy active pattern.**


```



    let rec factorial n = match n with 0 | 1 -> 1 | n -> n * (factorial (n-1))
    let lazyValue = lazy ( factorial (10) )
    // No computation occurs until the match expression executes.
    match lazyValue with
    | Lazy value -> printfn "10 factorial is %d" value


```



**Output**
**10 factorial is 3628800**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

