# Seq.cache<'T> Function (F#)

Returns a sequence that corresponds to a cached version of the input sequence.

**Namespace/Module Path**: Microsoft.FSharp.Collections.Seq

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
Seq.cache : seq<'T> -> seq<'T>

// Usage:
Seq.cache source
```

#### CAPS_PARAMETERS_MD
*source*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'T&gt;**


The input sequence.



**exceptions tag is not supported!!!!**
**The result sequence.**
## CAPS_REMARKS_MD
This result sequence will have the same elements as the input sequence. The result can be enumerated multiple times. The input sequence is enumerated at most once and only as far as is necessary. Caching a sequence is typically useful when repeatedly evaluating items in the original sequence is computationally expensive or if iterating the sequence causes side-effects that the user does not want to be repeated multiple times. Once enumeration of the input sequence has started, its enumerator will be kept active by this object until the enumeration has completed. At that point, the enumerator will be disposed. The enumerator may be disposed and underlying cache storage released by converting the returned sequence object to type **T:System.IDisposable**, and calling the **Dispose** method on this object. The sequence object may then be re-enumerated and a fresh enumerator will be used.

This function is named **Cache** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example demonstrates how to use Seq.cache to avoid recomputing elements of a sequence.**
```

   // Recursive isprime function.
   let isPrime n =
       let rec check i =
           i > n/2 || (n % i <> 0 && check (i + 1))
       check 2

   let seqPrimes = seq { for n in 2 .. 10000 do if isPrime n then yield n }
   // Cache the sequence to avoid recomputing the sequence elements.
   let cachedSeq = Seq.cache seqPrimes
   for index in 1..5 do
       printfn "%d is prime." (Seq.nth (Seq.length cachedSeq - index) cachedSeq)
```

**Output**
**9973 is prime.**
**9967 is prime.**
**9949 is prime.**
**9941 is prime.**
**9931 is prime.**
## Thread Safety
Enumeration of the result sequence is thread-safe in the sense that multiple independent **IEnumerator** values may be used simultaneously from different threads (accesses to the internal lookaside table are thread-safe). Each individual **IEnumerator** is not typically thread-safe and should not be accessed concurrently.


## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.Seq Module &#40;F&#35;&#41;](Collections.Seq+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

