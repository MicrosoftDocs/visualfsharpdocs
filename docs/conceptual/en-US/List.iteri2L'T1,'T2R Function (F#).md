# List.iteri2<'T1,'T2> Function (F#)

Applies the given function to two collections simultaneously. The collections must have identical size. The integer passed to the function indicates the index of element.

**Namespace/Module Path:** Microsoft.FSharp.Collections.List

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## CAPS_SYNTAX_MD



```


// Signature:
List.iteri2 : (int -> 'T1 -> 'T2 -> unit) -> 'T1 list -> 'T2 list -> unit

// Usage:
List.iteri2 action list1 list2


```



#### CAPS_PARAMETERS_MD
*action*
Type: [int](http://msdn.microsoft.com/en-us/library/025d5455-3622-4ea5-9573-3ecbd4ee1375)**-&gt; 'T1 -&gt; 'T2 -&gt;**[unit](http://msdn.microsoft.com/en-us/library/00b837c2-6c8a-483a-87d3-0479c64037a7)


The function to apply to a pair of elements from the input lists along with their index.


*list1*
Type: **'T1**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The first input list.


*list2*
Type: **'T2**[list](http://msdn.microsoft.com/en-us/library/c627b668-477b-4409-91ed-06d7f1b3e4a7)


The second input list.



**exceptions tag is not supported!!!!**

## CAPS_REMARKS_MD
This function is named **IterateIndexed2** in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.

**The following code example illustrates the use of List.iteri2 and compares its behavior with related functions.**


```



    let list1 = [1; 2; 3]
    let list2 = [4; 5; 6]
    List.iter (fun x -> printfn "List.iter: element is %d" x) list1
    List.iteri(fun i x -> printfn "List.iteri: element %d is %d" i x) list1
    List.iter2 (fun x y -> printfn "List.iter2: elements are %d %d" x y) list1 list2
    List.iteri2 (fun i x y ->
                   printfn "List.iteri2: element %d of list1 is %d element %d of list2 is %d"
                     i x i y)
                list1 list2


```



**Output**
**List.iter: element is 1**
**List.iter: element is 2**
**List.iter: element is 3**
**List.iteri: element 0 is 1**
**List.iteri: element 1 is 2**
**List.iteri: element 2 is 3**
**List.iter2: elements are 1 4**
**List.iter2: elements are 2 5**
**List.iter2: elements are 3 6**
**List.iteri2: element 0 of list1 is 1 element 0 of list2 is 4**
**List.iteri2: element 1 of list1 is 2 element 1 of list2 is 5**
**List.iteri2: element 2 of list1 is 3 element 2 of list2 is 6**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Collections.List Module &#40;F&#35;&#41;](Collections.List+Module+%28F%23%29.md)

[Microsoft.FSharp.Collections Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Collections+Namespace+%28F%23%29.md)

