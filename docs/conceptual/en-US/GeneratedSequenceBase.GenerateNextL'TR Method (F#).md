# GeneratedSequenceBase.GenerateNext<'T> Method (F#)

The F# compiler emits implementations of this type for compiled sequence expressions.

**Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
abstract this.GenerateNext : byref<IEnumerable<'T>> -> int

// Usage:
generatedSequenceBase.GenerateNext (result)


```



#### CAPS_PARAMETERS_MD
*result*
Type: [byref](http://msdn.microsoft.com/en-us/library/ab37321f-5515-4c29-8296-48b57eae15f7)**&lt;****T:System.Collections.Generic.IEnumerable&#96;1****&lt;'T&gt;&gt;**


A reference to the sequence.



**A 0, 1, and 2 respectively indicate Stop, Yield, and Goto conditions for the sequence generator.**
## CAPS_REMARKS_MD

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[CompilerServices.GeneratedSequenceBase&#60;'T&#62; Class &#40;F&#35;&#41;](CompilerServices.GeneratedSequenceBase+%27T+Class+%28F%23%29.md)

[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices+Namespace+%28F%23%29.md)

