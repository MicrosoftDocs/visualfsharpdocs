# Operators.hash<'T> Function (F#)

A generic hash function, designed to return equal hash values for items that are equal according to the **=** operator. By default it will use structural hashing for F# union, record and tuple types, hashing the complete contents of the type. The exact behavior of the function can be adjusted on a type-by-type basis by implementing **M:System.Object.GetHashCode** for each type.

**Namespace/Module Path**: Microsoft.FSharp.Core.Operators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
// Signature:
hash : 'T -> int (requires equality)

// Usage:
hash obj
```

#### [!INCLUDE[System_CAPS_parameters](//System/Token/System_CAPS_parameters_md.md)]
*obj*
Type: **'T**


The input object.



**The computed hash.**
## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
This function is named **Hash** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following examples shows the use of the hash function to generate hashes for a variety of data types.**
**[!CODE [FsSamples101#1010](../CodeSnippet/VS_Snippets_Fsharp/fssamples101/FSharp/fs/beginners.fs#1010)]**
**hash(1) : 1**
**hash(2) : 2**
**hash("1") : -842352753**
**hash("2") : -842352754**
**hash("abb") : 2103075711**
**hash("aBc") : 539088922**
**hash(&lt;null&gt;) : 0**
**hash(Some 1) : -1640531462**
**hash(Some 0) : -1640531463**
**hash([1; 2; 3]) : 1956583134**
**hash([1; 2; 3; 4; 5; 6; 7; 8]) : 922428386**
**hash([1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11]) : 1771492728**
**hash([1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14; 15]) : -926589492**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.Operators Module &#40;F&#35;&#41;](Core.Operators+Module+28%F%2329%.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+28%F%2329%.md)

