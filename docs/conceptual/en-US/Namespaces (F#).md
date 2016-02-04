# Namespaces (F#)

A namespace lets you organize code into areas of related functionality by enabling you to attach a name to a grouping of program elements.


## CAPS_SYNTAX_MD



```


namespace [parent-namespaces.]identifier


```



## CAPS_REMARKS_MD
If you want to put code in a namespace, the first declaration in the file must declare the namespace. The contents of the entire file then become part of the namespace.

Namespaces cannot directly contain values and functions. Instead, values and functions must be included in modules, and modules are included in namespaces. Namespaces can contain types, modules.

Namespaces can be declared explicitly with the namespace keyword, or implicitly when declaring a module. To declare a namespace explicitly, use the namespace keyword followed by the namespace name. The following example shows a code file that declares a namespace Widgets with a type and a module included in that namespace.



```



namespace Widgets

type MyWidget1 =
    member this.WidgetName = "Widget1"

module WidgetsModule =
    let widgetName = "Widget2"


```



    If the entire contents of the file are in one module, you can also declare namespaces implicitly by using the **module** keyword and providing the new namespace name in the fully qualified module name. The following example shows a code file that declares a namespace **Widgets** and a module **WidgetsModule**, which contains a function.



```



module Widgets.WidgetModule

let widgetFunction x y =
   printfn "%A %A" x y


```



    The following code is equivalent to the preceding code, but the module is a local module declaration. In that case, the namespace must appear on its own line.



```



namespace Widgets

module WidgetModule =

    let widgetFunction x y =
        printfn "%A %A" x y


```



    If more than one module is required in the same file in one or more namespaces, you must use local module declarations. When you use local module declarations, you cannot use the qualified namespace in the module declarations. The following code shows a file that has a namespace declaration and two local module declarations. In this case, the modules are contained directly in the namespace; there is no implicitly created module that has the same name as the file. Any other code in the file, such as a **do** binding, is in the namespace but not in the inner modules, so you need to qualify the module member **widgetFunction** by using the module name.



```



namespace Widgets

module WidgetModule1 =
   let widgetFunction x y =
      printfn "Module1 %A %A" x y
module WidgetModule2 =
   let widgetFunction x y =
      printfn "Module2 %A %A" x y

module useWidgets =

  do
     WidgetModule1.widgetFunction 10 20
     WidgetModule2.widgetFunction 5 6


```



    The output of this example is as follows.




```


Module1 10 20
Module2 5 6


```


For more information, see [Modules &#40;F&#35;&#41;](Modules+%28F%23%29.md).


## Nested Namespaces
When you create a nested namespace, you must fully qualify it. Otherwise, you create a new top-level namespace. Indentation is ignored in namespace declarations.

The following example shows how to declare a nested namespace.



```



namespace Outer

    // Full name: Outer.MyClass
    type MyClass() =
       member this.X(x) = x + 1

// Fully qualify any nested namespaces.
namespace Outer.Inner

    // Full name: Outer.Inner.MyClass
    type MyClass() =
       member this.Prop1 = "X"


```



    
## Namespaces in Files and Assemblies
Namespaces can span multiple files in a single project or compilation. The term *namespace fragment* describes the part of a namespace that is included in one file. Namespaces can also span multiple assemblies. For example, the **System** namespace includes the whole .NET Framework, which spans many assemblies and contains many nested namespaces.


## Global Namespace
You use the predefined namespace **global** to put names in the .NET top-level namespace.



```



namespace global

type SomeType() =
    member this.SomeMember = 0


```



    You can also use global to reference the top-level .NET namespace, for example, to resolve name conflicts with other namespaces.



```



    global.System.Console.WriteLine("Hello World!")


```



    
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Modules &#40;F&#35;&#41;](Modules+%28F%23%29.md)

