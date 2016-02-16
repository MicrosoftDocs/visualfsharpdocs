# CompilerServices.ITypeProvider Interface (F#)

Type providers implement this interface in order to be recognized by the compiler as an F# type provider. The implementation of this interface determines the public interface and behavior of the type provider. For more information, see [Type Providers](Type-Providers.md).

**Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices

**Assembly**: FSharp.Core (in FSharp.Core.dll)


## Syntax


```


type ITypeProvider =
interface
inherit IDisposable
abstract this.ApplyStaticArguments : Type * string [] * obj [] -> Type  abstract this.GetGeneratedAssemblyContents : System.Reflection.Assembly -> byte[] 
abstract this.GetInvokerExpression : MethodBase * Quotations.Expr [] -> Quotations.Expr
abstract this.GetNamespaces : unit -> IProvidedNamespace []
abstract this.GetStaticParameters : Type -> ParameterInfo []
abstract this.add_Invalidate : EventHandler -> unit
abstract this.Invalidate : IEvent<EventHandler,EventArgs>
abstract this.remove_Invalidate : EventHandler -> unit
end

```



## Remarks

## Instance Members


|Member|Description|
|------|-----------|
|[add_Invalidate](http://msdn.microsoft.com/en-us/library/4d396b82-cbdb-4334-85c7-47b83d4ec16e) : **T:System.EventHandler** -&gt; unit|Add an event handler for the [Invalidate](http://msdn.microsoft.com/en-us/library/5a8d95dc-e462-4f07-90e4-9b8dfb82d100) event.|
|[ApplyStaticArguments](http://msdn.microsoft.com/en-us/library/05f98c71-5c9a-4002-aec2-b4ef2b1f6801) : **T:System.Type** &#42; [string](http://msdn.microsoft.com/en-us/library/12b97856-ec80-4f70-a018-afb0753f755a) [] &#42; [obj](http://msdn.microsoft.com/en-us/library/dcf2430f-702b-40e5-a0a1-97518bf137f7) [] -&gt; **T:System.Type**|Apply static arguments to a provided type that accepts static arguments.|
|[GetInvokerExpression](http://msdn.microsoft.com/en-us/library/5706a4fc-ac14-4d5f-9c28-bb62896e705a) : **T:System.Reflection.MethodBase** &#42; [Quotations.Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65) [] -&gt; [Quotations.Expr](http://msdn.microsoft.com/en-us/library/ed6a2caf-69d4-45c2-ab97-e9b3be9bce65)|Called by the compiler to ask for an Expression tree to replace the given **T:System.Reflection.MethodBase** with.|
|[GetGeneratedAssemblyContents](http://msdn.microsoft.com/en-us/library/2f9dff1a-6336-4748-bc34-db172c5fcba2) : System.Reflection.Assembly -&gt; [byte](http://msdn.microsoft.com/en-us/library/17a98430-283a-4ff6-a475-e6999577179d) []|Get the physical contents of the given logical provided assembly.|
|[GetNamespaces](http://msdn.microsoft.com/en-us/library/eac5d16b-5eb7-4911-b383-20862217ae02) : unit -&gt; [IProvidedNamespace](http://msdn.microsoft.com/en-us/library/1c6f26eb-9d66-4a84-b870-7ed6dd58bbc6) []|Namespace name that this type provider injects types into.|
|[GetStaticParameters](http://msdn.microsoft.com/en-us/library/2cd79503-64e5-4cc6-9272-fc27bcb2ef18) : **T:System.Type** -&gt; **T:System.Reflection.ParameterInfo** []|Get the static parameters for a provided type.|
|[Invalidate](http://msdn.microsoft.com/en-us/library/5a8d95dc-e462-4f07-90e4-9b8dfb82d100) : [IEvent](http://msdn.microsoft.com/en-us/library/8dbca0df-f8a1-40bd-8d50-aa26f6a8b862)&lt;**T:System.EventHandler**, **T:System.EventArgs**&gt;|Triggered when an assumption changes that invalidates the resolutions so far reported by the provider.|
|[remove_Invalidate](http://msdn.microsoft.com/en-us/library/222c81e5-4b1b-49bd-9d38-a89d5fbc93f2) : **T:System.EventHandler** -&gt; unit|Remove an event handler for the [Invalidate](http://msdn.microsoft.com/en-us/library/5a8d95dc-e462-4f07-90e4-9b8dfb82d100) event.|

## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 4.0Supported in: 4.0, Portable




## See Also
[Microsoft.FSharp.Core.CompilerServices Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Core.CompilerServices-Namespace-%5BFSharp%5D.md)

