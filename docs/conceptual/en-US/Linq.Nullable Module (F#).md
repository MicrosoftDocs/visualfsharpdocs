# Linq.Nullable Module (F#)

Functions for converting nullable values into nullable values of another type.

**Namespace/Module Path**: Microsoft.FSharp.Linq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
module Nullable
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]
For more information about nullable types and nullable operators, see **T:System.Nullable&#96;1** and [Nullable Operators &#40;F&#35;&#41;](Nullable+Operators+28%F%2329%.md).


## Values


|Value|Description|
|-----|-----------|
|[byte](http://msdn.microsoft.com/en-us/library/9d0fd2ef-8b80-44a7-b504-a6e9105035a8) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;byte&gt;|Converts the argument to nullable byte, Nullable&lt;[byte](http://msdn.microsoft.com/en-us/library/17a98430-283a-4ff6-a475-e6999577179d)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[char](http://msdn.microsoft.com/en-us/library/27c61925-0ccd-4f7f-b911-8f656d63eb6f) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;char&gt;|Converts the argument to a nullable character, Nullable&lt;[char](http://msdn.microsoft.com/en-us/library/3627f475-985b-4b4e-94d2-14f217c04958)&gt;. Numeric inputs are converted according to the UTF-16 encoding for characters. The operation requires an appropriate static conversion method on the input type.|
|[decimal](http://msdn.microsoft.com/en-us/library/fe77229c-542c-4359-b755-39b7a90fa79d) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;System.Decimal&gt;|Converts the argument to a nullable decimal, Nullable&lt;**T:System.Decimal**&gt; using a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[enum](http://msdn.microsoft.com/en-us/library/d1149ef9-696f-4cf4-b4cd-94521606926b) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;'U when 'U : enum&gt;|Converts the argument to a particular nullable enum type.|
|[float](http://msdn.microsoft.com/en-us/library/0813ebd5-757b-43ec-8a3e-2aaafbb5e201) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;float&gt;|Converts the argument to a nullable 64-bit float, Nullable&lt;[float](http://msdn.microsoft.com/en-us/library/3fa76cae-e9b5-4672-8bdf-88ff6dbcf7b8)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[float32](http://msdn.microsoft.com/en-us/library/9b2fd2f1-beec-4e7e-b9fb-4da0d9750213) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;float32&gt;|Converts the argument to a nullable 32-bit float, Nullable&lt;[float32](http://msdn.microsoft.com/en-us/library/9bf674b5-ea9a-4b08-ad42-4da313b6ebf0)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[int](http://msdn.microsoft.com/en-us/library/efecf446-be62-444a-a6a6-f67504f119a9) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;int&gt;|Converts the argument to nullable signed 32-bit integer, Nullable&lt;[int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[int16](http://msdn.microsoft.com/en-us/library/953ba6ba-39ad-4f29-9c0d-22847d97e314) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;int16&gt;|Converts the argument to a nullable signed 16-bit integer, Nullable&lt;[int16](http://msdn.microsoft.com/en-us/library/608e612c-5a8e-40c4-912f-55788628cb9b)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[int32](http://msdn.microsoft.com/en-us/library/c6790ad2-bab4-49be-84ba-16dee88090db) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;int32&gt;|Converts the argument to a nullable signed 32-bit integer, Nullable&lt;[int32](http://msdn.microsoft.com/en-us/library/6ab0ea34-03db-4874-a265-bef9c64f8eff)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[int64](http://msdn.microsoft.com/en-us/library/5d95d9a6-4056-4061-a029-2f169feae88b): System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;int64&gt;|Converts the argument to a nullable signed 64-bit integer, Nullable&lt;[int64](http://msdn.microsoft.com/en-us/library/1bec11c0-45ac-469e-923b-22a1708c0701)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[nativeint](http://msdn.microsoft.com/en-us/library/c4da00bb-d3cc-4b99-a958-b3cb39601ea8) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;nativeint&gt;|Converts the argument to a nullable signed native integer, Nullable&lt;[nativeint](http://msdn.microsoft.com/en-us/library/876c5aa7-683f-4912-a799-161732109c4f)&gt;. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|
|[sbyte](http://msdn.microsoft.com/en-us/library/44043d32-324b-4017-8546-016871776112) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;sbyte&gt;|Converts the argument to a nullable signed byte, Nullable&lt;[sbyte](http://msdn.microsoft.com/en-us/library/fbc28b7f-2dbf-4361-acb3-830886820068)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[uint16](http://msdn.microsoft.com/en-us/library/f6321925-76ee-4499-a1f6-4f581b650efe): System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;uint16&gt;|Converts the argument to a nullable unsigned 16-bit integer, Nullable&lt;[uint16](http://msdn.microsoft.com/en-us/library/2ab2f1fa-344e-4fcf-a688-5024c589630b)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[uint32](http://msdn.microsoft.com/en-us/library/678e7843-fab8-4053-b8c0-3214bea74913) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;uint32&gt;|Converts the argument to a nullable unsigned 32-bit integer, Nullable&lt;[uint32](http://msdn.microsoft.com/en-us/library/02aea3e2-e400-453a-a681-3a657afe1825)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[uint64](http://msdn.microsoft.com/en-us/library/a90b1710-16d3-4f6a-ae02-f0a277006b8c) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;uint64&gt;|Converts the argument to a nullable unsigned 64-bit integer, Nullable&lt;[uint64](http://msdn.microsoft.com/en-us/library/3c4f3a04-06eb-48aa-b38e-16646bda2f33)&gt;. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|
|[unativeint](http://msdn.microsoft.com/en-us/library/85721b5a-d241-4586-bd12-ec81547a3f7e) : System.Nullable&lt;'T&gt; -&gt; System.Nullable&lt;unativeint&gt;|Converts the argument to a nullable unsigned native integer, Nullable&lt;[unativeint](http://msdn.microsoft.com/en-us/library/9d2946a7-ace9-48a4-8cff-7894b8e7de86)&gt;, using a direct conversion for all primitive numeric types. Otherwise, the operation requires an appropriate static conversion method on the input type.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Linq Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Linq+Namespace+28%F%2329%.md)

