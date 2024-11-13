---
title: Exceptions - The try...finally Expression (F#)
description: Exceptions - The try...finally Expression (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: af06b20c-8d87-4496-a0aa-6fdfe8b3a786
redirect_url: https://docs.microsoft.com/dotnet/articles/fsharp/language-reference/exception-handling/the-try-finally-expression 
---

# Exceptions: The try...finally Expression (F#)

The `try...finally` expression enables you to execute clean-up code even if a block of code throws an exception.


## Syntax

```fsharp
try
expression1
finally
expression2
```

## Remarks
The `try...finally` expression can be used to execute the code in *expression2* in the preceding syntax regardless of whether an exception is generated during the execution of *expression1*.

The type of *expression2* does not contribute to the value of the whole expression; the type returned when an exception does not occur is the last value in *expression1*. When an exception does occur, no value is returned and the flow of control transfers to the next matching exception handler up the call stack. If no exception handler is found, the program terminates. Before the code in a matching handler is executed or the program terminates, the code in the `finally` branch is executed.

The following code demonstrates the use of the `try...finally` expression.

[!code-fsharp[Main](snippets/fslangref2/snippet5701.fs)]

The output to the console is as follows.

```
Closing stream
Exception handled.
```

As you can see from the output, the stream was closed before the outer exception was handled, and the file `test.txt` contains the text `test1`, which indicates that the buffers were flushed and written to disk even though the exception transferred control to the outer exception handler.

Note that the `try...with` construct is a separate construct from the `try...finally` construct. Therefore, if your code requires both a `with` block and a `finally` block, you have to nest the two constructs, as in the following code example.

[!code-fsharp[Main](snippets/fslangref2/snippet5702.fs)]

In the context of computation expressions, including sequence expressions and asynchronous workflows, **try...finally** expressions can have a custom implementation. For more information, see [Computation Expressions &#40;F&#35;&#41;](Computation-Expressions-%5BFSharp%5D.md).


## See Also
[Exception Handling &#40;F&#35;&#41;](Exception-Handling-%5BFSharp%5D.md)

[Exceptions: The try...with Expression &#40;F&#35;&#41;](Exceptions-The-try...with-Expression-%5BFSharp%5D.md)