---
title: Linq.NullableOperators Module (F#)
description: Linq.NullableOperators Module (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 409bae28-7ae8-49e8-ad83-2a16a7eef553 
---

# Linq.NullableOperators Module (F#)

Operators for working with nullable values.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
[<AutoOpen>]
module NullableOperators
```

## Remarks

## Values


|Value|Description|
|-----|-----------|
|[( %? )](http://msdn.microsoft.com/en-us/library/a4c178e5-eec4-42e8-847f-90b24fc609fe)|The modulus operator where a nullable value appears on the right.|
|[( &#42;? )](http://msdn.microsoft.com/en-us/library/04c47870-de7b-480d-98a0-f47593b4ffac)|The multiplication operator where a nullable value appears on the right.|
|[( -? )](http://msdn.microsoft.com/en-us/library/74772ea8-f010-493e-bdb5-ba347f2fd4f1)|The addition operator where a nullable value appears on the right.|
|[( -? )](http://msdn.microsoft.com/en-us/library/4a345c07-314a-48f1-b557-ce072583589c)|The subtraction operator where a nullable value appears on the right.|
|[( /? )](http://msdn.microsoft.com/en-us/library/1de07646-3778-476d-8c61-5d37495d463c)|The division operator where a nullable value appears on the right.|
|[( &lt;=? )](http://msdn.microsoft.com/en-us/library/02454a0f-30ca-4e77-ad84-ee7837461804)|The **&lt;=** operator where a nullable value appears on the right.|
|[( &lt;&gt;? )](http://msdn.microsoft.com/en-us/library/3179aace-70c4-4911-9258-619592214976)|The **&lt;&gt;** operator where a nullable value appears on the right.|
|[( &lt;? )](http://msdn.microsoft.com/en-us/library/be9ea40f-a67f-4e98-8067-a14046752e8b)|The **&lt;** operator where a nullable value appears on the right.|
|[( =? )](http://msdn.microsoft.com/en-us/library/d2102894-6a51-475d-890a-735568c31f87)|The **=** operator where a nullable value appears on the right.|
|[( &gt;=? )](http://msdn.microsoft.com/en-us/library/0a255d8e-8cae-4160-ae61-243a5d96583f)|The **&gt;=** operator where a nullable value appears on the right.|
|[( &gt;? )](http://msdn.microsoft.com/en-us/library/0ad1284b-de48-4a04-83d8-b6f13c9c8936)|The '&gt;' operator where a nullable value appears on the right.|
|[( ?% )](http://msdn.microsoft.com/en-us/library/44297bba-1bd9-4ed2-a848-f1e1e598db87)|The modulus operator where a nullable value appears on the left.|
|[( ?%? )](http://msdn.microsoft.com/en-us/library/dd555f20-1be3-4b8d-81f1-bf1921e62fda)|The modulus operator where a nullable value appears on both left and right sides.|
|[( ?&#42; )](http://msdn.microsoft.com/en-us/library/519da708-5ad6-4075-9d74-d00441cd6078)|The multiplication operator where a nullable value appears on the left.|
|[( ?&#42;? )](http://msdn.microsoft.com/en-us/library/e57057ba-9c3a-40ec-8401-150c2b25f75b)|The multiplication operator where a nullable value appears on both left and right sides.|
|[( ?- )](http://msdn.microsoft.com/en-us/library/2e8ddd05-b3f3-41b3-9d73-938d9e540f3f)|The addition operator where a nullable value appears on the left.|
|[( ?-? )](http://msdn.microsoft.com/en-us/library/57f28137-0f42-43d2-92af-cad8c6c9d05f)|The addition operator where a nullable value appears on both left and right sides.|
|[( ?- )](http://msdn.microsoft.com/en-us/library/f237a7a6-89f2-48b2-a2fe-f0b98a2bedc2)|The subtraction operator where a nullable value appears on the left.|
|[( ?-? )](http://msdn.microsoft.com/en-us/library/e0024142-1d2a-4607-a39c-1eb1e86fa25a)|The subtraction operator where a nullable value appears on both left and right sides .|
|[( ?/ )](http://msdn.microsoft.com/en-us/library/add02a42-f556-40a7-a168-fbf2053322e3)|The division operator where a nullable value appears on the left.|
|[( ?/? )](http://msdn.microsoft.com/en-us/library/b17be0ac-bf98-4590-861d-a4dd6c6fa535)|The division operator where a nullable value appears on both left and right sides.|
|[( ?&lt; )](http://msdn.microsoft.com/en-us/library/b71897f0-6e29-4c58-b0a7-a5bfa6f88917)|The **&lt;** operator where a nullable value appears on the left.|
|[( ?&lt;= )](http://msdn.microsoft.com/en-us/library/56fddf0a-e4ca-4891-a3be-fad1876be3b6)|The **&lt;=** operator where a nullable value appears on the left.|
|[( ?&lt;=? )](http://msdn.microsoft.com/en-us/library/5c37c28c-0b57-4da5-be11-5a123f7e8ee4)|The **&lt;=** operator where a nullable value appears on both left and right sides.|
|[( ?&lt;&gt; )](http://msdn.microsoft.com/en-us/library/3643a5a8-2ea5-4ad6-82c4-83927c3884a0)|The **&lt;&gt;** operator where a nullable value appears on the left.|
|[( ?&lt;&gt;? )](http://msdn.microsoft.com/en-us/library/5da813d8-ee75-45b8-9ef4-146dcb6d394d)|The **&lt;&gt;** operator where a nullable value appears on both left and right sides.|
|[( ?&lt;? )](http://msdn.microsoft.com/en-us/library/6f1962c8-5605-468c-94ae-f379ae98e17d)|The **&lt;** operator where a nullable value appears on both left and right sides.|
|[( ?= )](http://msdn.microsoft.com/en-us/library/5cdc8ff6-244b-49cf-9376-69ecf249fd7c)|The **=** operator where a nullable value appears on the left.|
|[( ?=? )](http://msdn.microsoft.com/en-us/library/5f793f29-1084-4570-b1c1-17c1b7ef764b)|The **=** operator where a nullable value appears on both left and right sides.|
|[( ?&gt; )](http://msdn.microsoft.com/en-us/library/62dc0021-1312-4ac3-be87-798b60b81bb6)|The **&gt;** operator where a nullable value appears on the left.|
|[( ?&gt;= )](http://msdn.microsoft.com/en-us/library/94d29e32-a204-4f60-a527-6b0af86268f3)|The **&gt;=** operator where a nullable value appears on the left.|
|[( ?&gt;=? )](http://msdn.microsoft.com/en-us/library/3051a50f-d276-4c84-9d73-bf2efeddef94)|The **&gt;=** operator where a nullable value appears on both left and right sides.|
|[( ?&gt;? )](http://msdn.microsoft.com/en-us/library/dc18b6fa-30c4-47b0-9057-794439378a05)|The **&gt;** operator where a nullable value appears on both left and right sides.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq-Namespace-%5BFSharp%5D.md)

