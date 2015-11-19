# External Functions (F#)

This topic describes F# language support for calling functions in native code.


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
[<DllImport( arguments )>]
extern declaration
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
In the previous syntax, *arguments* represents arguments that are supplied to the **T:System.Runtime.InteropServices.DllImportAttribute** attribute. The first argument is a string that represents the name of the DLL that contains this function, without the .dll extension. Additional arguments can be supplied for any of the public properties of the **T:System.Runtime.InteropServices.DllImportAttribute** class, such as the calling convention.

Assume you have a native C++ DLL that contains the following exported function.


```cpp#
#include <stdio.h>
extern "C" void __declspec(dllexport) HelloWorld()
{
printf("Hello world, invoked by F#!\n");
}
```
You can call this function from F# by using the following code.


```f#
open System.Runtime.InteropServices

module InteropWithNative =
[<DllImport(@"C:\bin\nativedll", CallingConvention = CallingConvention.Cdecl)>]
extern void HelloWorld()

InteropWithNative.HelloWorld()
```
Interoperability with native code is referred to as *platform invoke* and is a feature of the CLR. For more information, see [Interoperating with Unmanaged Code](Interoperating+with+Unmanaged+Code.md). The information in that section is applicable to F#.


## See Also
[Functions &#40;F&#35;&#41;](Functions+28%F%2329%.md)

