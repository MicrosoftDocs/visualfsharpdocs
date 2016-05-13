# Lazy Computations (F#)

*Lazy computations* are computations that are not evaluated immediately, but are instead evaluated when the result is needed. This can help to improve the performance of your code.


## Syntax



```




let identifier = lazy ( expression )


```





## Remarks
In the previous syntax, *expression* is code that is evaluated only when a result is required, and *identifier* is a value that stores the result. The value is of type [Lazy&lt;'T&gt;](http://msdn.microsoft.com/en-us/library/b29d0af5-6efb-4a55-a278-2662a4ecc489), where the actual type that is used for **'T** is determined from the result of the expression.

Lazy computations enable you to improve performance by restricting the execution of a computation to only those situations in which a result is needed.

To force the computation to be performed, you call the method **Force**. **Force** causes the execution to be performed only one time. Subsequent calls to **Force** return the same result, but do not execute any code.

The following code illustrates the use of lazy computation and the use of **Force**. In this code, the type of **result** is **Lazy&lt;int&gt;**, and the **Force** method returns an **int**.

[!code-fsharp[Main](snippets/fslangref2/snippet73011.fs)]
    Lazy evaluation, but not the **Lazy** type, is also used for sequences. For more information, see [Sequences &#40;F&#35;&#41;](Sequences-%5BFSharp%5D.md).


## See Also
[F&#35; Language Reference](FSharp-Language-Reference.md)

[LazyExtensions module](http://msdn.microsoft.com/en-us/library/86671f40-84a0-402a-867d-ae596218d948)

