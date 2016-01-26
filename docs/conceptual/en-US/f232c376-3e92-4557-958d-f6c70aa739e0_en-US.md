# NativePtr.set<'T> Function (F#)

Assigns a value into the memory location referenced by the typed native pointer computed by adding to the given input pointer.

**Namespace/Module Path:** Microsoft.FSharp.NativeInterop.NativePtr

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
NativePtr.set : nativeptr<'T> -> int -> 'T -> unit (requires unmanaged)

// Usage:
NativePtr.set address index value
```

#### CAPS_PARAMETERS_MD
*address*
Type: [nativeptr](http://msdn.microsoft.com/en-us/library/6e74c8e5-f2ff-4e56-ab05-c337b0618d73)**&lt;'T&gt;**


The input pointer.


*index*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The index by which to offset the pointer.


*value*
Type: **'T**


The value to assign.




## CAPS_REMARKS_MD
The pointer is offset by **index &#42; sizeof&lt;'T&gt;**.

This function is named **SetPointerInlined** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[NativeInterop.NativePtr Module &#40;F&#35;&#41;](NativeInterop.NativePtr+Module+%28F%23%29.md)

[Microsoft.FSharp.NativeInterop Namespace &#40;F&#35;&#41;](Microsoft.FSharp.NativeInterop+Namespace+%28F%23%29.md)

