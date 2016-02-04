# Source Line, File, and Path Identifiers (F#)

The identifiers **__LINE__**, **__SOURCE_DIRECTORY__** and **__SOURCE_FILE__** are built-in values that enable you to access the source line number, directory and file name in your code.


## CAPS_SYNTAX_MD



```


__LINE__
__SOURCE_DIRECTORY__
__SOURCE_FILE__


```



## CAPS_REMARKS_MD
Each of these values has type **string**.

The following table summarizes the source line, file, and path identifiers that are available in F#. These identifiers are not preprocessor macros; they are built-in values that are recognized by the compiler.



|Predefined identifier|Description|
|---------------------|-----------|
|**__LINE__**|Evaluates to the current line number, considering **#line** directives.|
|**__SOURCE_DIRECTORY__**|Evaluates to the current full path of the source directory, considering **#line** directives.|
|**__SOURCE_FILE__**|Evaluates to the current source file name and its path, considering **#line** directives.|
For more information about the **#line** directive, see [Compiler Directives &#40;F&#35;&#41;](Compiler+Directives+%28F%23%29.md).

The following code example demonstrates the use of these values.



```



let printSourceLocation() =
    printfn "Line: %s" __LINE__
    printfn "Source Directory: %s" __SOURCE_DIRECTORY__
    printfn "Source File: %s" __SOURCE_FILE__
printSourceLocation()


```



    Output:




```


Line: 4
Source Directory: C:\Users\username\Documents\Visual Studio 2010\Projects\SourceInfo\SourceInfo
Source File: C:\Users\username\Documents\Visual Studio 2010\Projects\SourceInfo\SourceInfo\Program.fs


```



## See Also
[Compiler Directives &#40;F&#35;&#41;](Compiler+Directives+%28F%23%29.md)

[F&#35; Language Reference](F%23+Language+Reference.md)

