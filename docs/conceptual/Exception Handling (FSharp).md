# Exception Handling (F#)

This section contains information about exception handling support in the F# language.


## Exception Handling Basics
Exception handling is the standard way of handling error conditions in the .NET Framework. Thus, any .NET language must support this mechanism, including F#. An *exception* is an object that encapsulates information about an error. When errors occur, exceptions are raised and regular execution stops. Instead, the runtime searches for an appropriate handler for the exception. The search starts in the current function, and proceeds up the stack through the layers of callers until a matching handler is found. Then the handler is executed.

In addition, as the stack is unwound, the runtime executes any code in **finally** blocks, to guarantee that objects are cleaned up correctly during the unwinding process.


## Related Topics


|Title|Description|
|-----|-----------|
|[Exception Types &#40;F&#35;&#41;](Exception+Types+%28FSharp%29.md)|Describes how to declare an exception type.|
|[Exceptions: The try...with Expression &#40;F&#35;&#41;](Exceptions+-+The+try...with+Expression+%28FSharp%29.md)|Describes the language construct that supports exception handling.|
|[Exceptions: The try...finally Expression &#40;F&#35;&#41;](Exceptions+-+The+try...finally+Expression+%28FSharp%29.md)|Describes the language construct that enables you to execute clean-up code as the stack unwinds when an exception is thrown.|
|[Exceptions: the raise Function &#40;F&#35;&#41;](Exceptions+-+the+raise+Function+%28FSharp%29.md)|Describes how to throw an exception object.|
|[Exceptions: The failwith Function &#40;F&#35;&#41;](Exceptions+-+The+failwith+Function+%28FSharp%29.md)|Describes how to generate a general F# exception.|
|[Exceptions: The invalidArg Function &#40;F&#35;&#41;](Exceptions+-+The+invalidArg+Function+%28FSharp%29.md)|Describes how to generate an invalid argument exception.|
