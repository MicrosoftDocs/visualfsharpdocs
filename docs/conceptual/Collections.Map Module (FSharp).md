# Collections.Map Module (F#)

Functional programming operators related to the [Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664) type.

**Namespace/Module Path:** Microsoft.FSharp.Collections

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax

```
module Map
```

## Remarks

## Values


|Value|Description|
|-----|-----------|
|[add](http://msdn.microsoft.com/en-us/library/8cd69deb-e5c2-4e24-b63f-02b807d3e98d)<br />**: 'Key -&gt; 'T -&gt; Map&lt;'Key,'T&gt; -&gt; Map&lt;'Key,'T&gt;**|Returns a new map with the binding added to the given map.|
|[containsKey](http://msdn.microsoft.com/en-us/library/45364a26-984c-4cf8-844f-dad1121c012d)<br />**: 'Key -&gt; Map&lt;'Key,'T&gt; -&gt; bool**|Tests if an element is in the domain of the map.|
|[empty](http://msdn.microsoft.com/en-us/library/3b016bff-78fc-4439-ae8f-4d3eeecfa1c4)<br />**: Map&lt;'Key,'T&gt;**|The empty map.|
|[exists](http://msdn.microsoft.com/en-us/library/2f564fec-5be2-458c-877e-d90368d0e968)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; bool**|Returns **true** if the given predicate returns true for one of the bindings in the map.|
|[filter](http://msdn.microsoft.com/en-us/library/2d678ca0-8ed9-42fa-8235-908c4b8208c3)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; Map&lt;'Key,'T&gt;**|Creates a new map containing only the bindings for which the given predicate returns **true**.|
|[find](http://msdn.microsoft.com/en-us/library/fc984657-9e0f-4544-b7d1-da6572b5ae74)<br />**: 'Key -&gt; Map&lt;'Key,'T&gt; -&gt; 'T**|Looks up an element in the map.|
|[findKey](http://msdn.microsoft.com/en-us/library/34052cc7-a792-476a-8d66-1764493335e3)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; 'Key**|Evaluates the function on each mapping in the collection. Returns the key for the first mapping where the function returns **true**.|
|[fold](http://msdn.microsoft.com/en-us/library/f7665840-e675-4762-9aa8-56a707fff1c1)<br />**: ('State -&gt; 'Key -&gt; 'T -&gt; 'State) -&gt; 'State -&gt; Map&lt;'Key,'T&gt; -&gt; 'State**|Folds over the bindings in the map|
|[foldBack](http://msdn.microsoft.com/en-us/library/c4b2dece-4d1c-42cd-8782-71f47a64e54f)<br />**: ('Key -&gt; 'T -&gt; 'State -&gt; 'State) -&gt; Map&lt;'Key,'T&gt; -&gt; 'State -&gt; 'State**|Folds over the bindings in the map.|
|[forall](http://msdn.microsoft.com/en-us/library/184ced53-597e-47e1-90d0-47926a81bf92)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; bool**|Returns true if the given predicate returns true for all of the bindings in the map.|
|[isEmpty](http://msdn.microsoft.com/en-us/library/3e6efa6d-e028-48c9-bfc8-189d2e9b98c9)<br />**: Map&lt;'Key,'T&gt; -&gt; bool**|Tests whether the map has any bindings.|
|[iter](http://msdn.microsoft.com/en-us/library/63ba88a2-0d40-452b-8993-ec66e2ac978f)<br />**: ('Key -&gt; 'T -&gt; unit) -&gt; Map&lt;'Key,'T&gt; -&gt; unit**|Applies the given function to each binding in the dictionary|
|[map](http://msdn.microsoft.com/en-us/library/c47bdb4a-af6b-4317-8687-02379b81d4c9)<br />**: ('Key -&gt; 'T -&gt; 'U) -&gt; Map&lt;'Key,'T&gt; -&gt; Map&lt;'Key,'U&gt;**|Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The key passed to the function indicates the key of element being transformed.|
|[ofArray](http://msdn.microsoft.com/en-us/library/614c77a4-2571-485c-b25d-9077bd1d2ab6)<br />**: ('Key &#42; 'T) [] -&gt; Map&lt;'Key,'T&gt;**|Returns a new map made from the given bindings.|
|[ofList](http://msdn.microsoft.com/en-us/library/baa7df23-d015-44b0-8f20-f4a3631dcc8f)<br />**: 'Key &#42; 'T list -&gt; Map&lt;'Key,'T&gt;**|Returns a new map made from the given bindings.|
|[ofSeq](http://msdn.microsoft.com/en-us/library/8449a3ef-b5a4-4731-904f-929c8efb1a2f)<br />**: seq&lt;'Key &#42; 'T&gt; -&gt; Map&lt;'Key,'T&gt;**|Returns a new map made from the given bindings.|
|[partition](http://msdn.microsoft.com/en-us/library/97896a64-ef03-43d2-9000-51cad86c2200)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; Map&lt;'Key,'T&gt; &#42; Map&lt;'Key,'T&gt;**|Creates two new maps, one containing the bindings for which the given predicate returns **true**, and the other the remaining bindings.|
|[pick](http://msdn.microsoft.com/en-us/library/a7868ddd-13aa-443d-9ac0-e16205b77681)<br />**: ('Key -&gt; 'T -&gt; 'U option) -&gt; Map&lt;'Key,'T&gt; -&gt; 'U**|Searches the map looking for the first element where the given function returns a **Some** value|
|[remove](http://msdn.microsoft.com/en-us/library/fa512ed2-dce1-499d-b4c6-7d71d5c767e2)<br />**: 'Key -&gt; Map&lt;'Key,'T&gt; -&gt; Map&lt;'Key,'T&gt;**|Removes an element from the domain of the map. No exception is raised if the element is not present.|
|[toArray](http://msdn.microsoft.com/en-us/library/12e1b141-9aa1-4193-8fef-55a8d41bf7d7)<br />**: Map&lt;'Key,'T&gt; -&gt; ('Key &#42; 'T) []**|Returns an array of all key/value pairs in the mapping. The array will be ordered by the keys of the map.|
|[toList](http://msdn.microsoft.com/en-us/library/5aff0d8b-334e-4323-8dc3-fb705d85d396)<br />**: Map&lt;'Key,'T&gt; -&gt; ('Key &#42; 'T) list**|Returns a list of all key/value pairs in the mapping. The list will be ordered by the keys of the map.|
|[toSeq](http://msdn.microsoft.com/en-us/library/32646074-6c9b-4813-8b53-77317b950d8e)<br />**: Map&lt;'Key,'T&gt; -&gt; seq&lt;'Key &#42; 'T&gt;**|Views the collection as an enumerable sequence of pairs. The sequence will be ordered by the keys of the map.|
|[tryFind](http://msdn.microsoft.com/en-us/library/3e1b9f31-7584-4115-aaa6-442b71b21cc9)<br />**: 'Key -&gt; Map&lt;'Key,'T&gt; -&gt; 'T option**|Looks up an element in the map, returning a **Some** value if the element is in the domain of the map, or **None** if not.|
|[tryFindKey](http://msdn.microsoft.com/en-us/library/9356bc17-ebc7-4070-b58d-96275a791c5d)<br />**: ('Key -&gt; 'T -&gt; bool) -&gt; Map&lt;'Key,'T&gt; -&gt; 'Key option**|Returns the key of the first mapping in the collection that satisfies the given predicate, or returns **None** if no such element exists.|
|[tryPick](http://msdn.microsoft.com/en-us/library/71f66885-1aad-4363-9527-5f9856e6cee9)<br />**: ('Key -&gt; 'T -&gt; 'U option) -&gt; Map&lt;'Key,'T&gt; -&gt; 'U option**|Searches the map looking for the first element where the given function returns a **Some** value.|
**The following code example uses functions in the Map module to create a histogram of the occurrences of particular Unicode characters using a [Microsoft.FSharp.Collections.Map](http://msdn.microsoft.com/en-us/library/975316ea-55e3-4987-9994-90897ad45664).**
[!code-fsharp[Main](snippets/fssamples101/snippet2002.fs)]
**Number of ' ' characters = 8**
**Number of 'T' characters = 1**
**Number of 'a' characters = 1**
**Number of 'b' characters = 1**
**Number of 'c' characters = 1**
**Number of 'd' characters = 1**
**Number of 'e' characters = 3**
**Number of 'f' characters = 1**
**...**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28FSharp%29.md)

