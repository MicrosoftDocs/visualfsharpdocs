# Core.ExtraTopLevelOperators Module (F#)

Additional F# operators and types that are available without opening a module or namespace.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


[<AutoOpen>]
module ExtraTopLevelOperators

```



## Remarks

## Values


|Value|Description|
|-----|-----------|
|[( ~% )](http://msdn.microsoft.com/en-us/library/d5cd4a4e-7f20-4a23-a346-a11a963f18e2)<br />**: Expr&lt;'T&gt; -&gt; 'T**|Special prefix operator for splicing typed expressions into quotation holes.|
|[( ~%% )](http://msdn.microsoft.com/en-us/library/f6d8d802-888a-4ed3-ad7e-8eace7be60ca)<br />**: Expr -&gt; 'T**|Special prefix operator for splicing untyped expressions into quotation holes.|
|[array2D](http://msdn.microsoft.com/en-us/library/1d52503d-2990-49fc-8fd3-6b0e508aa236)<br />**: seq&lt;#seq&lt;'T&gt;&gt; -&gt; 'T [,]**|Builds a 2D array from a sequence of sequences of elements.|
|[async](http://msdn.microsoft.com/en-us/library/dbe42940-13d3-4f2f-b99c-344fbd78785f)<br />**: AsyncBuilder**|Build an asynchronous workflow using computation expression syntax.|
|[dict](http://msdn.microsoft.com/en-us/library/a8d7fac4-4466-44d9-bf31-7b29a21b2d17)<br />**: seq&lt;'Key &#42; 'Value&gt; -&gt; IDictionary&lt;'Key,'Value&gt;**|Builds a read-only lookup table from a sequence of key/value pairs. The key objects are indexed using generic hashing and equality.|
|[double](http://msdn.microsoft.com/en-us/library/21e147c8-fee0-4d59-9620-cbe832d3fde7)<br />**: ^T -&gt; float**|Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.Double.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires and invokes a **ToDouble** method on the input type.|
|[eprintf](http://msdn.microsoft.com/en-us/library/501be259-4adc-414e-bc7b-0f665c777fd4)<br />**: TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to **stderr** using the given format.|
|[eprintfn](http://msdn.microsoft.com/en-us/library/d3ba61e2-22b0-4170-a753-6e1a736e91bb)<br />**: TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to **stderr** using the given format, and add a newline|
|[failwithf](http://msdn.microsoft.com/en-us/library/677781f0-fb69-4dfe-9d18-8fb1a7fc7aed)<br />**: StringFormat&lt;'T,'TResult&gt; -&gt; 'T**|Print to a string buffer and raise an exception with the given result. Helper printers must return strings.|
|[fprintf](http://msdn.microsoft.com/en-us/library/b6db8c01-2bcc-44ea-8aec-a7c5da114200)<br />**: TextWriter -&gt; TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to a file using the given format|
|[fprintfn](http://msdn.microsoft.com/en-us/library/2a1edd66-53b8-460d-a71b-616c54dca561)<br />**: TextWriter -&gt; TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to a file using the given format, and add a newline|
|[int8](http://msdn.microsoft.com/en-us/library/e42d6978-87f1-41af-a535-e138ddd90085)<br />**: ^T -&gt; sbyte**|Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.SByte.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires and invokes a **ToSByte** method on the input type.|
|[printf](http://msdn.microsoft.com/en-us/library/b9b851d7-b032-48e5-8c2e-3841fe9c44cc)<br />**: TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to **stdout** using the given format.|
|[printfn](http://msdn.microsoft.com/en-us/library/3b8e7af1-0931-4d57-9e11-7d7e57c8038c)<br />**: TextWriterFormat&lt;'T&gt; -&gt; 'T**|Print to **stdout** using the given format, and add a newline.|
|[set](http://msdn.microsoft.com/en-us/library/a4ec6cdd-9ae6-47e5-afa3-c6610a22931e)<br />**: seq&lt;'T&gt; -&gt; Set&lt;'T&gt;**|Builds a set from a sequence of objects. The objects are indexed using generic comparison.|
|[single](http://msdn.microsoft.com/en-us/library/c408b9da-58d1-400b-84b8-61985804de0f)<br />**: ^T -&gt; single**|Converts the argument to 32-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **M:System.Single.Parse(System.String)** with **P:System.Globalization.CultureInfo.InvariantCulture** settings. Otherwise the operation requires and invokes a **ToSingle** method on the input type.|
|[sprintf](http://msdn.microsoft.com/en-us/library/8ddc0cc1-4e80-4371-820d-cdde04ab8145)<br />**: StringFormat&lt;'T&gt; -&gt; 'T**|Print to a string using the given format.|
|[uint8](http://msdn.microsoft.com/en-us/library/824ecbe9-2578-4339-8d0a-621f97a8a56a)<br />**: ^T -&gt; byte**|Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using **Byte.Parse** on strings and otherwise requires a **ToByte** method on the input type.|

## Active Patterns


|Active Pattern|Description|
|--------------|-----------|
|[( &#124;Lazy&#124; )](http://msdn.microsoft.com/en-us/library/5dc8b945-3004-42a4-b2a1-b19bb21836e1)<br />**: Lazy&lt;'T&gt; -&gt; 'T**|An active pattern to force the execution of values of type [Lazy](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489).|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable


## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

