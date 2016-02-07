# Microsoft.FSharp.Collections Namespace (F#)

This namespace contains some common collections in an object-oriented style well suited for use from F#.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


namespace Microsoft.FSharp.Collections

```



## Remarks

## Modules


|Module|Description|
|------|-----------|
|module [Array](http://msdn.microsoft.com/en-us/library/0cda8040-9396-40dd-8dcd-cf48542165a1)|Basic operations on arrays.|
|module [Array2D](http://msdn.microsoft.com/en-us/library/ae1a9746-7817-4430-bcdb-a79c2411bbd3)|Basic operations on 2-dimensional arrays.|
|module [Array3D](http://msdn.microsoft.com/en-us/library/c8355e2d-add8-48a4-8aa6-1c57ae74c560)|Basic operations on rank 3 arrays.|
|module [Array4D](http://msdn.microsoft.com/en-us/library/9fdbd023-7c17-4a68-a405-8a1b826ac032)|Basic operations on rank 4 arrays.|
|module [ComparisonIdentity](http://msdn.microsoft.com/en-us/library/c2b37395-7081-4427-9913-3e91a8001d77)|Common notions of comparison identity used with sorted data structures.|
|module [HashIdentity](http://msdn.microsoft.com/en-us/library/8e676091-4b8d-44d6-83cc-5caeb3f78cf4)|Common notions of value identity used with hash tables.|
|module [List](http://msdn.microsoft.com/en-us/library/a2264ba3-2d45-40dd-9040-4f7aa2ad9788)|Basic operations on lists.|
|module [Map](http://msdn.microsoft.com/en-us/library/bfe61ead-f16c-416f-af98-56dbcbe23e4f)|Functional programming operators related to the [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664) type.|
|module [Seq](http://msdn.microsoft.com/en-us/library/54e8f059-ca52-4632-9ae9-49685ee9b684)|Basic operations on enumerable collections.|
|module [Set](http://msdn.microsoft.com/en-us/library/61efa732-d55d-4c32-993f-628e2f98e6a0)|Functional programming operators related to the [Set](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8) type.|

## Type Definitions


|Type|Description|
|----|-----------|
|type [List&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)|The type of immutable singly-linked lists.|
|type [Map&lt; 'Key, 'Value&gt;](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664)|Immutable maps. Keys are ordered by F# generic comparison.|
|type [Set&lt; 'T&gt;](http://msdn.microsoft.com/en-us/library/50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8)|Immutable sets based on binary trees, where comparison is the F# structural comparison function, potentially using implementations of the **T:System.IComparable** interface on key values.|

## Type Abbreviations


|Type|Description|
|----|-----------|
|type [list&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/dd7cd330-4bb6-4e28-b458-0ea62c6b0b04)|An abbreviation for the type of immutable singly-linked lists.|
|type [ResizeArray&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/2b9bb344-8fa0-4ab6-a325-db7a12b6bdad)|An abbreviation for the CLI type **T:System.Collections.Generic.List&#96;1**.|
|type [seq&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)|An abbreviation for the CLI type **T:System.Collections.Generic.IEnumerable&#96;1**|

## See Also
[F&#35; Core Library Reference](FSharp+Core+Library+Reference.md)

