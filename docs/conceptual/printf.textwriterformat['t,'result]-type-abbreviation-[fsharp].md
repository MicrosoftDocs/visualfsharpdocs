# Printf.TextWriterFormat<'T,'Result> Type Abbreviation (F#)

Represents a statically-analyzed format associated with writing to a **T:System.IO.TextWriter**. The first type parameter indicates the arguments of the format operation and the last the overall return type. This type is a type abbreviation for [Format&lt;'Printer,TextWriter,unit,'Result&gt;](http://msdn.microsoft.com/en-us/library/470f484f-a026-40af-8f8c-1e3aaf013bdc).

**Namespace/Module Path:** Microsoft.FSharp.Core.Printf

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


type TextWriterFormat<'T,'Result> = Format<'Printer,'State,'Residue,'Result>

```



## Remarks

## Platforms
Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Printf Module &#40;F&#35;&#41;](Core.Printf-Module-%5BFSharp%5D.md)

[Format&lt;'Printer,'State,'Residue,'Result&gt;](http://msdn.microsoft.com/en-us/library/470f484f-a026-40af-8f8c-1e3aaf013bdc)

