# EdmxFile Type Provider (F#)

Provides the types to access a database with the schema in an .edmx file by using a LINQ to Entities mapping.

**Namespace/Module Path:** Microsoft.FSharp.Data.TypeProviders

**Assembly:** FSharp.Data.TypeProviders (in FSharp.Data.TypeProviders.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
type EdmxFile<File : string,                                   ?ResolutionFolder : string>
```

## Static Type Parameters


|Type Parameter|Description|
|--------------|-----------|
|File : string|The path to an .edmx file that contains the schema. This file is written by the type provider.|
|?ResolutionFolder : string|A folder to be used to resolve relative file paths at compile time. The default value is the folder that contains the project or script.|

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
The EdmxFile type provider doesn't support the SQL data types **hierarchyid** and **sql_variant**.

For a walkthrough that shows how to use the EdmxFile type provider, see [Walkthrough: Generating F&#35; Types from an EDMX Schema File &#40;F&#35;&#41;](Walkthrough%3A+Generating+F%23+Types+from+an+EDMX+Schema+File+28%F%2329%.md).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+28%F%2329%.md)

