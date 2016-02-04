# ExtraTopLevelOperators.sprintf<'T> Function (F#)

The sprintf function prints to a string using the given format.

**Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
sprintf : StringFormat<'T> -> 'T

// Usage:
sprintf format


```



#### CAPS_PARAMETERS_MD
*format*
Type: [StringFormat](http://msdn.microsoft.com/en-us/library/4226a2e7-9ebc-466f-8547-da79f0b05cd1)**&lt;'T&gt;**




## CAPS_REMARKS_MD
This function is named **PrintFormatToString** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of sprintf.**


```



    let printToString value =
        sprintf "Formatted string with value %d..." value
    printfn "%s" (printToString 109)


```



**Formatted string with value 109...**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

