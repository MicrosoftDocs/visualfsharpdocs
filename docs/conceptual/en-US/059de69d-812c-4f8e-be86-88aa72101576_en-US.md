# Seq.init<'T> Function (F#)

Generates a new sequence which, when iterated, will return successive elements by calling the given function, up to the given count.

**Namespace/Module Path:** Microsoft.FSharp.Collections.Seq

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.init : int -> (int -> 'T) -> seq<'T>

// Usage:
Seq.init count initializer
```

#### CAPS_PARAMETERS_MD
*count*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)


The maximum number of items to generate for the sequence.


*initializer*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T**


A function that generates an item in the sequence from a given index.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
Each element is saved after its initialization. The function is passed the index of the item being generated.

This function is named **Initialize** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.


## Thread Safety
The returned sequence may be passed between threads safely. However, individual **IEnumerator** values generated from the returned sequence should not be accessed concurrently.

**The following example demonstrates the use of Seq.init to create a sequence of the first five multiples of 10.**
```

let seqFirst5MultiplesOf10 = Seq.init 5 (fun n -> n * 10)
Seq.iter (fun elem -> printf "%d " elem) seqFirst5MultiplesOf10
```

**0 10 20 30 40**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

