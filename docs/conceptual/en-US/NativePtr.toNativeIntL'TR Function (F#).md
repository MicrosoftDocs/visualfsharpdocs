# NativePtr.toNativeInt<'T> Function (F#)

Returns a machine address for a given typed native pointer.

**Namespace/Module Path:** Microsoft.FSharp.NativeInterop.NativePtr

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
NativePtr.toNativeInt : nativeptr<'T> -> nativeint (requires unmanaged)

// Usage:
NativePtr.toNativeInt address
```

#### CAPS_PARAMETERS_MD
*address*
Type: [nativeptr](http://msdn.microsoft.com/en-us/library/6e74c8e5-f2ff-4e56-ab05-c337b0618d73)**&lt;'T&gt;**


The input pointer.



**The machine address.**
## CAPS_REMARKS_MD
This function is named **ToNativeIntInlined** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[NativeInterop.NativePtr Module &#40;F&#35;&#41;](NativeInterop.NativePtr+Module+%28F%23%29.md)

[Microsoft.FSharp.NativeInterop Namespace &#40;F&#35;&#41;](Microsoft.FSharp.NativeInterop+Namespace+%28F%23%29.md)

