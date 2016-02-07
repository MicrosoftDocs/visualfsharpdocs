# Core.String Module (F#)

Functional programming operators for string processing. Further string operations are available via the member functions on strings and other functionality in **T:System.String** and **T:System.Text.RegularExpressions.Regex** types.

**Namespace/Module Path:** Microsoft.FSharp.Core

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax


```


module String

```



## Remarks

## Values


|Value|Description|
|-----|-----------|
|[collect](http://msdn.microsoft.com/en-us/library/9090ee26-f297-4abe-aa6a-8854d64ecf0f)<br />**: (char -&gt; string) -&gt; string -&gt; string**|Creates a new string whose characters are the results of applying a specified function to each of the characters of the input string and concatenating the resulting strings.|
|[concat](http://msdn.microsoft.com/en-us/library/a66f19e5-2002-4960-8ce8-eae1be77bc5f)<br />**: string -&gt; seq&lt;string&gt; -&gt; string**|Returns a new string made by concatenating the given strings with a separator.|
|[exists](http://msdn.microsoft.com/en-us/library/2a9952a0-7071-4d8f-b32b-90736d5aa781)<br />**: (char -&gt; bool) -&gt; string -&gt; bool**|Tests if any character of the string satisfies the given predicate.|
|[forall](http://msdn.microsoft.com/en-us/library/5ad8c75f-d513-42ac-915b-3261a7b82672)<br />**: (char -&gt; bool) -&gt; string -&gt; bool**|Tests if all characters in the string satisfy the given predicate.|
|[init](http://msdn.microsoft.com/en-us/library/2d42d3cd-a278-4dbf-8db5-c9433e312b08)<br />**: int -&gt; (int -&gt; string) -&gt; string**|Creates a new string whose characters are the results of applying a specified function to each index and concatenating the resulting strings.|
|[iter](http://msdn.microsoft.com/en-us/library/dad84486-fe93-4475-aea6-8735d463ac4d)<br />**: (char -&gt; unit) -&gt; string -&gt; unit**|Applies a specified function to each character in the string.|
|[iteri](http://msdn.microsoft.com/en-us/library/9f94dad5-53a2-44aa-a221-5000ccc03e5d)<br />**: (int -&gt; char -&gt; unit) -&gt; string -&gt; unit**|Applies a specified function to the index of each character in the string and the character itself.|
|[length](http://msdn.microsoft.com/en-us/library/c8b24dd5-c58f-4bc3-8eba-49543d02ea81)<br />**: string -&gt; int**|Returns the length of the string.|
|[map](http://msdn.microsoft.com/en-us/library/58fc5f63-f402-4790-baa5-2c8feeb1bcb1)<br />**: (char -&gt; char) -&gt; string -&gt; string**|Creates a new string whose characters are the results of applying a specified function to each of the characters of the input string.|
|[mapi](http://msdn.microsoft.com/en-us/library/08e0ae3c-dbfa-4bc2-9e02-91c023105f2d)<br />**: (int -&gt; char -&gt; char) -&gt; string -&gt; string**|Creates a new string whose characters are the results of applying a specified function to each character and index of the input string.|
|[replicate](http://msdn.microsoft.com/en-us/library/489cf6e9-e0a0-457a-9e9b-bf630a40a25b)<br />**: int -&gt; string -&gt; string**|Returns a string by concatenating a specified number of instances of a string.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28FSharp%29.md)

