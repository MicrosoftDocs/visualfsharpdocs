# Seq.concat<'Collection,'T> Function (F#)

Combines the given enumeration-of-enumerations as a single concatenated enumeration.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.concat : seq<'Collection> -> seq<'T> (requires 'Collection :> seq<'T>)

// Usage:
Seq.concat sources
```

#### CAPS_PARAMETERS_MD
*sources*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'Collection&gt;**


The input enumeration-of-enumerations.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
The returned sequence may be passed between threads safely. However, individual **IEnumerator** values generated from the returned sequence should not be accessed concurrently.

This function is named **Concat** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code shows how to use Seq.concat.**
**[!CODE [FsSequences#29](../CodeSnippet/VS_Snippets_Fsharp/fssequences/FSharp/fs/program.fs#29)]**
**Output**
**1 2 3 4 5 6 7 8 9 10 1 2 3 4 5 6 7 8 9**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

