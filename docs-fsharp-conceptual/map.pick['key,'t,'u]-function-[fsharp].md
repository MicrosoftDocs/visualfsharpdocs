---
title: Map.pick<'Key,'T,'U> Function (F#)
description: Map.pick<'Key,'T,'U> Function (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: aa03cc11-bddf-44e4-9264-e517733c3ded
---

# Map.pick<'Key,'T,'U> Function (F#)

Searches the map looking for the first element where the given function returns a `Some` value. If the function returns `None` for all elements, raises `System.Collections.Generic.KeyNotFoundException`.



**Namespace/Module Path**: Microsoft.FSharp.Collections.Map

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```fsharp
// Signature:
Map.pick : ('Key -> 'T -> 'U option) -> Map<'Key,'T> -> 'U (requires comparison)

// Usage:
Map.pick chooser table
```

#### Parameters
*chooser*
Type: **'Key -&gt; 'T -&gt; 'U**[option](https://msdn.microsoft.com/library/b08add48-34bf-4410-80a1-ef6a8daddc58)


The function to generate options from the key/value pairs.


*table*
Type: [Map](https://msdn.microsoft.com/library/975316ea-55e3-4987-9994-90897ad45664)**&lt;'Key,'T&gt;**


The input map.

## Exceptions
|Exception|Condition|
|----|----|
|[KeyNotFoundException](https://msdn.microsoft.com/library/system.collections.generic.keynotfoundexception.aspx)|Thrown if the function returns `None` for all elements.|

## Return Value

The first result.

## Remarks
This function is named `Pick` in compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.

## Example

The following code shows how to use `Map.pick`.

```fsharp
let map1 = [ for i in 1 .. 100 -> (i, 100 - i) ] |> Map.ofList
let result = Map.pick (fun key value -> if key = value then Some(key) else None) map1
printfn "Result where key and value are the same: %d" result
```

**Output**

```
Result where key and value are the same: 50
```

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable

## See Also
[Collections.Map Module &#40;F&#35;&#41;](Collections.Map-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)
