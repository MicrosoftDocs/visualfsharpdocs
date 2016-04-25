# HashIdentity.LimitedStructural<'T> Function (F#)

Implements a structural hash that is limited to hashing a fixed number of elements.

**Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## Syntax



```




// Signature:
LimitedStructural : int -> IEqualityComparer<'T> (requires equality)

// Usage:
LimitedStructural limit


```





#### Parameters
*limit*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The maximum number of elements to hash.



**An object that implements T:System.Collections.IEqualityComparer using the limited hash.**
## Remarks
Structural hashing recursively composes a hash of a structural object by combining the hashes of each of its constituent elements. So, if you have a list composed of 20,000 elements, the hashes of each element will be composed into the hash of the list.

To save time and mitigate the risk of a stack overflow while hashing, the limited hash allows you to specify an upper bound on the number of items you would like to consider when constructing a hash over structured data. So, if you are hashing a list of 20,000 elements, you can just use its first 18 elements.

**LimitedStructural** uses the [limitedHash function](http://msdn.microsoft.com/en-us/library/499fba7c-6b04-47e7-aeda-05420e6e2d21).


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.HashIdentity Module &#40;F&#35;&#41;](Collections.HashIdentity-Module-%5BFSharp%5D.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections-Namespace-%5BFSharp%5D.md)

