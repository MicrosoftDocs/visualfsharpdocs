# ExtraTopLevelOperators.dict<'Key,'Value> Function (F#)

Builds a read-only lookup table from a sequence of key/value pairs. The key objects are indexed using generic hashing and equality.

**Namespace/Module Path**: Microsoft.FSharp.Core.ExtraTopLevelOperators

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD

```
// Signature:
dict : seq<'Key * 'Value> -> IDictionary<'Key,'Value> (requires equality)

// Usage:
dict keyValuePairs
```

#### CAPS_PARAMETERS_MD
*keyValuePairs*
Type: [seq](http://msdn.microsoft.com/en-us/library/2f0c87c6-8a0d-4d33-92a6-10d1d037ce75)**&lt;'Key &#42; 'Value&gt;**



**An object that implements T:System.Collections.Generic.IDictionary&#96;2 that represents the given collection.**
## CAPS_REMARKS_MD
This function is named **CreateDictionary** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example shows the use of the dict function.**
```

    open System
    open System.Collections.Generic

    let seq1 = seq { for i in 1..10 -> i, i*i }
    let dictionary1 = dict seq1
    if dictionary1.IsReadOnly then
        Console.WriteLine("The dictionary is read only.")
    // The type is a read only IDictionary.
    // If you try to add or remove elements,
    // NotSupportedException is generated, as in the following line:
    //dictionary1.Add(new KeyValuePair<int, int>(0, 0))
    // You can use read-only methods as in the following lines.
    if dictionary1.ContainsKey(5) then
        Console.WriteLine("Value for key 5: {0}", dictionary1.Item(5))
    for elem in dictionary1 do
       Console.WriteLine("Key: {0} Value: {1}", elem.Key, elem.Value) 
```

**The output is as follows.**
**The dictionary is read only.**
**Value for key 5: 25**
**Key: 1 Value: 1**
**Key: 2 Value: 4**
**Key: 3 Value: 9**
**Key: 4 Value: 16**
**Key: 5 Value: 25**
**Key: 6 Value: 36**
**Key: 7 Value: 49**
**Key: 8 Value: 64**
**Key: 9 Value: 81**
**Key: 10 Value: 100**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Core.ExtraTopLevelOperators Module &#40;F&#35;&#41;](Core.ExtraTopLevelOperators+Module+%28F%23%29.md)

[Microsoft.FSharp.Core Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core+Namespace+%28F%23%29.md)

