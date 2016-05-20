---
title: Quotations.Patterns Module (F#)
description: Quotations.Patterns Module (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.assetid: 02e5a8ba-2fa8-4b75-8522-a60c4afe2334 
---

# Quotations.Patterns Module (F#)

Contains a set of primitive F# active patterns to analyze F# expression objects.

**Namespace/Module Path:** Microsoft.FSharp.Quotations

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
module Patterns
```

## Remarks

## Active Patterns


|Active Pattern|Description|
|--------------|-----------|
|[AddressOf](http://msdn.microsoft.com/en-us/library/dc14214e-96a1-43b7-ae8c-44d2b78dad4d)<br />**: Expr -&gt; Expr option**|Recognizes expressions that represent getting the address of a value.|
|[AddressSet](http://msdn.microsoft.com/en-us/library/08abb9b7-ca3c-4170-886a-ee393e6aa5f7)<br />**: Expr -&gt; (Expr &#42; Expr) option**|Recognizes expressions that represent setting the value held at an address .|
|[Application](http://msdn.microsoft.com/en-us/library/57856b28-771f-4ceb-9f00-16ea7f48af46)<br />**: Expr -&gt; (Expr &#42; Expr) option**|Recognizes expressions that represent applications of first class function values.|
|[Call](http://msdn.microsoft.com/en-us/library/30fe9a55-5a76-452d-9334-3324a6837ae7)<br />**: Expr -&gt; (Expr option &#42; MethodInfo &#42; Expr list) option**|Recognizes expressions that represent calls to static and instance methods, and functions defined in modules.|
|[Coerce](http://msdn.microsoft.com/en-us/library/bd5f79c4-5245-4e84-b1a7-b221928d47ae)<br />**: Expr -&gt; (Expr &#42; Type) option**|Recognizes expressions that represent coercions from one type to another.|
|[DefaultValue](http://msdn.microsoft.com/en-us/library/b71bf5a2-dcd6-4612-9b2d-d7f8a52d35fa)<br />**: Expr -&gt; Type option**|Recognizes expressions that represent invocations of a default constructor of a structure.|
|[FieldGet](http://msdn.microsoft.com/en-us/library/99d0c3d6-da53-4ebd-a288-c7be83c00daf)<br />**: Expr -&gt; (Expr option &#42; FieldInfo)**|Recognizes expressions that represent getting a static or instance field.|
|[FieldSet](http://msdn.microsoft.com/en-us/library/44ebb5e4-e79d-4ae1-9e17-704b3f33bd32)<br />**: Expr -&gt; (Expr option &#42; FieldInfo &#42; Expr) option**|Recognizes expressions that represent setting a static or instance field.|
|[ForIntegerRangeLoop](http://msdn.microsoft.com/en-us/library/bf775c49-6b5b-4a45-97bf-9caa678e743f)<br />**: Expr -&gt; (Var &#42; Expr &#42; Expr &#42; Expr) option**|Recognizes expressions that represent loops over integer ranges.|
|[IfThenElse](http://msdn.microsoft.com/en-us/library/90f83178-ad5e-4a9f-b657-50e955e2738b)<br />**: Expr -&gt; (Expr &#42; Expr &#42; Expr) option**|Recognizes expressions that represent conditionals.|
|[Lambda](http://msdn.microsoft.com/en-us/library/5f584ead-897b-4108-8c0d-7ba6a53a9e38)<br />**: Expr -&gt; (Var &#42; Expr) option**|Recognizes expressions that represent first class function values.|
|[LetRecursive](http://msdn.microsoft.com/en-us/library/4c127a46-ac21-4908-8e21-eed5f8d1659c)<br />**: Expr -&gt; ((Var &#42; Expr) list &#42; Expr) option**|Recognizes expressions that represent recursive let bindings of one or more variables.|
|[Let](http://msdn.microsoft.com/en-us/library/6bed1453-5243-45c5-a88f-5534444c6655)<br />**: Expr -&gt; (Var &#42; Expr &#42; Expr) option**|Recognizes expressions that represent let bindings.|
|[NewArray](http://msdn.microsoft.com/en-us/library/5427df99-ab59-4210-9333-79ae3cd24105)<br />**: Expr -&gt; (Type &#42; Expr list) option**|Recognizes expressions that represent the construction of arrays.|
|[NewDelegate](http://msdn.microsoft.com/en-us/library/42e69e2f-6a0d-4d0a-832b-a3374f10ea8f)<br />**: Expr -&gt; (Type &#42; Var list &#42; Expr) option**|Recognizes expressions that represent construction of delegate values.|
|[NewObject](http://msdn.microsoft.com/en-us/library/fc7b4283-5292-4fd1-b881-ad0178049979)<br />**: Expr -&gt; (ConstructorInfo &#42; Expr list) option**|Recognizes expressions that represent invocation of object constructors.|
|[NewRecord](http://msdn.microsoft.com/en-us/library/3be68638-6f84-409a-baf7-0697f9aa9084)<br />**: Expr -&gt; (Type &#42; Expr list) option**|Recognizes expressions that represent construction of record values.|
|[NewTuple](http://msdn.microsoft.com/en-us/library/2808be50-9b00-47e8-bbde-caf7180b6bbb)<br />**: Expr -&gt; (Expr list) option**|Recognizes expressions that represent construction of tuple values.|
|[NewUnionCase](http://msdn.microsoft.com/en-us/library/d361ce71-14fe-4c66-b99b-04ef429727e1)<br />**: Expr -&gt; (UnionCaseInfo &#42; Expr list) option**|Recognizes expressions that represent construction of particular union case values.|
|[PropertyGet](http://msdn.microsoft.com/en-us/library/ee094de8-82ad-48fb-9576-f9ad7d43fd36)<br />**: Expr -&gt; (Expr option &#42; PropertyInfo &#42; Expr list) option**|Recognizes expressions that represent the read of a static or instance property, or a non-function value declared in a module.|
|[PropertySet](http://msdn.microsoft.com/en-us/library/9a674e05-e14f-42dd-a645-91f5221fd872)<br />**: Expr -&gt; (Expr option &#42; PropertyInfo &#42; Expr list &#42; Expr) option**|Recognizes expressions that represent setting a static or instance property, or a non-function value declared in a module.|
|[Quote](http://msdn.microsoft.com/en-us/library/d164c678-ab7d-4836-bdb7-511af5647109)<br />**: Expr -&gt; Expr option**|Recognizes expressions that represent a nested quotation literal.|
|[Sequential](http://msdn.microsoft.com/en-us/library/9c6b25a1-4b8d-4de2-8365-8d26e0ee9611)<br />**: Expr -&gt; (Expr &#42; Expr) option**|Recognizes expressions that represent sequential execution of one expression followed by another.|
|[TryFinally](http://msdn.microsoft.com/en-us/library/30d985b7-3989-4baf-89e5-2b88dcafe648)<br />**: Expr -&gt; (Expr &#42; Expr) option**|Recognizes expressions that represent a **try...finally** construct.|
|[TryWith](http://msdn.microsoft.com/en-us/library/71c6a72e-d817-4e9e-9fe3-9cbe91ba2f6d)<br />**: Expr -&gt; (Expr &#42; Var &#42; Expr &#42; Var &#42; Expr) option**|Recognizes expressions that represent a **try...with** construct for exception filtering and catching.|
|[TupleGet](http://msdn.microsoft.com/en-us/library/3a11f5bb-fa3f-40af-8a75-e886b82a7f62)<br />**: Expr -&gt; (Expr &#42; int) option**|Recognizes expressions that represent getting a tuple field.|
|[TypeTest](http://msdn.microsoft.com/en-us/library/433ea8af-312f-48eb-a655-bee31758ede6)<br />**: Expr -&gt; (Expr &#42; Type) option**|Recognizes expressions that represent a dynamic type test.|
|[UnionCaseTest](http://msdn.microsoft.com/en-us/library/fb65b0a3-68d0-4223-be01-fe68ff2a8d57)<br />**: Expr -&gt; (Expr &#42; UnionCaseInfo) option**|Recognizes expressions that represent a test if a value is of a particular union case.|
|[Value](http://msdn.microsoft.com/en-us/library/c8c35d6d-0068-4faa-b7de-cd571991adee)<br />**: Expr -&gt; (obj &#42; Type) option**|Recognizes expressions that represent a constant value.|
|[VarSet](http://msdn.microsoft.com/en-us/library/4fb87a56-d508-4a0a-a2b4-43a84d127d7a)<br />**: Expr -&gt; (Var &#42; Expr) option**|Recognizes expressions that represent setting a mutable variable.|
|[Var](http://msdn.microsoft.com/en-us/library/fd28da2c-0ba3-4db2-85bc-73f7c23114e2)<br />**: Expr -&gt; Var option**|Recognizes expressions that represent a variable.|
|[WhileLoop](http://msdn.microsoft.com/en-us/library/0df8dd3c-faab-4873-ab5c-eb5b0159f8b9)<br />**: Expr -&gt; (Expr &#42; Expr) option**|Recognizes expressions that represent while loops.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Quotations Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Quotations-Namespace-%5BFSharp%5D.md)

