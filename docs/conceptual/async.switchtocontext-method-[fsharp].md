---
title: Async.SwitchToContext Method (F#)
description: Async.SwitchToContext Method (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: c9ac8eb9-456c-4719-b017-b63d5eddb80a 
---

# Async.SwitchToContext Method (F#)

Creates an asynchronous computation that runs its continuation using the **M:System.Threading.SynchronizationContext.Post(System.Threading.SendOrPostCallback,System.Object)** method on the synchronization context object.

**Namespace/Module Path**: Microsoft.FSharp.Control

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax

```
// Signature:
static member SwitchToContext : SynchronizationContext -> Async<unit>

// Usage:
Async.SwitchToContext (syncContext)
```

#### Parameters
*syncContext*
Type: **T:System.Threading.SynchronizationContext**


The synchronization context to accept the posted computation.



**An asynchronous computation that uses the syncContext context to execute.**
## Remarks
If *syncContext* is null then the asynchronous computation is equivalent to [Async.SwitchToThreadPool](http://msdn.microsoft.com/en-us/library/c2708739-5389-487a-a3c9-490f417bcdc6).

**The following code example illustrates how to use Async.SwitchToContext to switch to the UI thread to update the UI. In this, case a progress bar that indicates the state of completion of a computation is updated.**
<b>codeReference tag is not supported!!!!</b>
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Control.Async Class &#40;F&#35;&#41;](Control.Async-Class-%5BFSharp%5D.md)

[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control-Namespace-%5BFSharp%5D.md)

