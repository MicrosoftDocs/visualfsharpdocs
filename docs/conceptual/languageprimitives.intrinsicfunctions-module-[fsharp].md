---
title: LanguagePrimitives.IntrinsicFunctions Module (F#)
description: LanguagePrimitives.IntrinsicFunctions Module (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: fc228654-e463-464c-a1e0-14e83ea17c4d 
---

# LanguagePrimitives.IntrinsicFunctions Module (F#)

The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs

**Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
module IntrinsicFunctions
```

## Remarks

## Values


|Value|Description|
|-----|-----------|
|[CheckThis](http://msdn.microsoft.com/en-us/library/3f696af0-f912-48fb-8122-51e306e074c2)|A compiler intrinsic for checking initialization soundness of recursive bindings|
|[CreateInstance](http://msdn.microsoft.com/en-us/library/3ba3445c-8522-438e-915d-101ad98ba5f1)|This function implements calls to default constructors acccessed by 'new' constraints.|
|[Dispose](http://msdn.microsoft.com/en-us/library/dd267de8-2699-440b-afe9-a2bda5986e91)|A compiler intrinsic for the efficient compilation of sequence expressions|
|[FailInit](http://msdn.microsoft.com/en-us/library/5fb4fb47-ed7b-4166-a268-ba12e6bc28ca)|A compiler intrinsic for checking initialization soundness of recursive bindings|
|[FailStaticInit](http://msdn.microsoft.com/en-us/library/75a58d95-4243-4623-8dc4-bb5006a1a3bc)|A compiler intrinsic for checking initialization soundness of recursive static bindings|
|[GetArray](http://msdn.microsoft.com/en-us/library/24a0af79-d0f8-4214-a0cf-282e07b9963c)|The standard overloaded associative (indexed) lookup operator|
|[GetArray2D](http://msdn.microsoft.com/en-us/library/b9240f85-84b4-4586-8da6-ac9251528416)|The standard overloaded associative (2-indexed) lookup operator|
|[GetArray3D](http://msdn.microsoft.com/en-us/library/e3d39923-e6f1-4a14-8dfc-afc15f1b89da)|The standard overloaded associative (3-indexed) lookup operator|
|[GetArray4D](http://msdn.microsoft.com/en-us/library/14e4a558-3b97-48b1-ba3b-a50895a8531c)|The standard overloaded associative (4-indexed) lookup operator|
|[GetString](http://msdn.microsoft.com/en-us/library/745ac5ac-c4fe-4009-9bac-90b8d41117ae)|Primitive used by pattern match compilation|
|[MakeDecimal](http://msdn.microsoft.com/en-us/library/af62eb6c-02c7-487f-bd8d-2ab15c620854)|This function implements parsing of decimal constants|
|[SetArray](http://msdn.microsoft.com/en-us/library/f7904de2-c969-4314-a5ad-a2e3fed17a4a)|The standard overloaded associative (indexed) mutation operator|
|[SetArray2D](http://msdn.microsoft.com/en-us/library/fa4f965b-abe3-44ad-9244-0d47c3858292)|The standard overloaded associative (2-indexed) mutation operator|
|[SetArray3D](http://msdn.microsoft.com/en-us/library/bc3cc1f1-9a89-4d85-aa42-ab7d1a8b0aed)|The standard overloaded associative (3-indexed) mutation operator|
|[SetArray4D](http://msdn.microsoft.com/en-us/library/20f10348-37d2-43c2-ab77-81dfd6745494)|The standard overloaded associative (4-indexed) mutation operator|
|[TypeTestFast](http://msdn.microsoft.com/en-us/library/e04d5e7e-4133-48bb-82ff-9fc184b72688)|A compiler intrinsic that implements the ':?' operator|
|[TypeTestGeneric](http://msdn.microsoft.com/en-us/library/b1428f64-90cf-44f2-ad44-d88c7c8d3c4c)|A compiler intrinsic that implements the ':?' operator|
|[UnboxFast](http://msdn.microsoft.com/en-us/library/d8f72f03-395b-4ca7-89ad-55def72ecb75)|A compiler intrinsic that implements the ':?&gt;' operator|
|[UnboxGeneric](http://msdn.microsoft.com/en-us/library/20313588-557f-4892-ac30-7336b33a5d28)|A compiler intrinsic that implements the ':?&gt;' operator|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.LanguagePrimitives Module &#40;F&#35;&#41;](Core.LanguagePrimitives-Module-%5BFSharp%5D.md)

