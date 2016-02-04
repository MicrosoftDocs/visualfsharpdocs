# ExtraTopLevelOperators.fprintf<'T> Function (F#)

The fprintf functions prints to a file using the given format.

**Namespace/Module Path**: Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
fprintf : TextWriter -> TextWriterFormat<'T> -> 'T

// Usage:
fprintf textWriter format


```



#### CAPS_PARAMETERS_MD
*textWriter*
Type: **T:System.IO.TextWriter**


*format*
Type: [TextWriterFormat](http://msdn.microsoft.com/en-us/library/2080c4a5-7bdd-4a01-8e01-10b498af92de)**&lt;'T&gt;**




## CAPS_REMARKS_MD
This function is named **PrintFormatToTextWriter** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following example demonstrates the use of fprintf.**


```



   let printNumbersToFile fileName n =
      // "use" will cause the file to be closed when it
      // goes out of scope.
      use file = System.IO.File.CreateText(fileName)
      [ 1 .. n ]
      |> List.iter (fun elem -> fprintf file "%d " elem)
      fprintfn file ""
   printNumbersToFile "1to100.txt" 100


```



**The resulting file 1to100.txt contains the following data.**
**1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

