---
title: External Functions (F#)
description: External Functions (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: c26b6124-ceaa-471c-9dc9-861b4dfa332a
redirect_url: https://docs.microsoft.com/dotnet/articles/fsharp/language-reference/functions/external-functions 
---

# External Functions (F#)

This topic describes F# language support for calling functions in native code.

## Syntax

```fsharp
[<DllImport( arguments )>]
extern declaration
```

## Remarks

In the previous syntax, *arguments* represents arguments that are supplied to the `System.Runtime.InteropServices.DllImportAttribute` attribute. The first argument is a string that represents the name of the DLL that contains this function, without the .dll extension. Additional arguments can be supplied for any of the public properties of the `System.Runtime.InteropServices.DllImportAttribute` class, such as the calling convention.

Assume you have a native C++ DLL that contains the following exported function.

```cpp
#include <stdio.h>
extern "C" void __declspec(dllexport) HelloWorld()
{
printf("Hello world, invoked by F#!\n");
}
```

You can call this function from F# by using the following code.

```fsharp
open System.Runtime.InteropServices

module InteropWithNative =
    [<DllImport(@"C:\bin\nativedll", CallingConvention = CallingConvention.Cdecl)>]
    extern void HelloWorld()

InteropWithNative.HelloWorld()
```

Interoperability with native code is referred to as *platform invoke* and is a feature of the CLR. For more information, see [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/sd10k43k.aspx). The information in that section is applicable to F#.


## See Also

[Functions &#40;F&#35;&#41;](Functions-%5BFSharp%5D.md)