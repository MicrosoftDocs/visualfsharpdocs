# Control.Observable Module (F#)

Basic operations on first class event and other observable objects.

**Namespace/Module Path:** Microsoft.FSharp.Control

**Assembly:** FSharp.Core (in FSharp.Core.dll)


## [!INCLUDE[System_CAPS_syntax](//System/Token/System_CAPS_syntax_md.md)]

```
module Observable
```

## [!INCLUDE[System_CAPS_remarks](//System/Token/System_CAPS_remarks_md.md)]

## Values


|Value|Description|
|-----|-----------|
|[add](http://msdn.microsoft.com/en-us/library/f4723e85-4fd0-41e5-b31a-a6f2cf07c43a)<br />**: ('T -&gt; unit) -&gt; IObservable&lt;'T&gt; -&gt; unit**|Creates an observer which permanently subscribes to the given observable and which calls the given function for each observation.|
|[choose](http://msdn.microsoft.com/en-us/library/75191474-af8a-4eb8-bc39-34f0e55a4368)<br />**: ('T -&gt; 'U option) -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'U&gt;**|Returns an observable which chooses a projection of observations from the source using the given function. The returned object will trigger observations for which the splitter returns a **Some**value. The returned object also propagates all errors arising from the source and completes when the source completes.|
|[filter](http://msdn.microsoft.com/en-us/library/c7957b74-9d92-4a5d-9f0a-43b51179e6c8)<br />**: ('T -&gt; bool) -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'T&gt;**|Returns an observable which filters the observations of the source by the given function. The observable will see only those observations for which the predicate returns **true**. The predicate is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.|
|[map](http://msdn.microsoft.com/en-us/library/e3274517-65e4-4c3c-aa9f-61a5c4ba1031)<br />**: ('T -&gt; 'U) -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'U&gt;**|Returns an observable which transforms the observations of the source by the given function. The transformation function is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.|
|[merge](http://msdn.microsoft.com/en-us/library/33e40753-6895-41a8-acd5-85fcb4eb7524)<br />**: IObservable&lt;'T&gt; -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'T&gt;**|Returns an observable for the merged observations from the sources. The returned object propagates success and error values arising from either source and completes when both the sources have completed.|
|[pairwise](http://msdn.microsoft.com/en-us/library/62641615-858c-41f3-8bd3-bc5e71eec783)<br />**: IObservable&lt;'T&gt; -&gt; IObservable&lt;'T &#42; 'T&gt;**|Returns a new observable that triggers on the second and subsequent triggerings of the input observable. The Nth triggering of the input observable passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.|
|[partition](http://msdn.microsoft.com/en-us/library/31619722-11a8-498c-88e4-8be7591a2160)<br />**: ('T -&gt; bool) -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'T&gt; &#42; IObservable&lt;'T&gt;**|Returns two observables which partition the observations of the source by the given function. The first will trigger observations for those values for which the predicate returns **true**. The second will trigger observations for those values where the predicate returns **false**. The predicate is executed once for each subscribed observer. Both also propagate all error observations arising from the source and each completes when the source completes.|
|[scan](http://msdn.microsoft.com/en-us/library/a51f3116-1588-442a-b200-9e370155b9ff)<br />**: ('U -&gt; 'T -&gt; 'U) -&gt; 'U -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'U&gt;**|Returns an observable which, for each observer, allocates an item of state and applies the given accumulating function to successive values arising from the input. The returned object will trigger observations for each computed state value, excluding the initial value. The returned object propagates all errors arising from the source and completes when the source completes.|
|[split](http://msdn.microsoft.com/en-us/library/a628f66b-8712-4a5d-b9fc-ba2f323cb333)<br />**: ('T -&gt; Choice&lt;'U1,'U2&gt;) -&gt; IObservable&lt;'T&gt; -&gt; IObservable&lt;'U1&gt; &#42; IObservable&lt;'U2&gt;**|Returns two observables which split the observations of the source by the given function. The first will trigger observations for which the splitter returns **Choice1Of2**. The second will trigger observations **y** for which the splitter returns **Choice2Of2**. The splitter is executed once for each subscribed observer. Both also propagate error observations arising from the source and each completes when the source completes.|
|[subscribe](http://msdn.microsoft.com/en-us/library/19e66519-0b77-4396-8159-67ec47be0a63)<br />**: ('T -&gt; unit) -&gt; IObservable&lt;'T&gt; -&gt; IDisposable**|Creates an observer which subscribes to the given observable and which calls the given function for each observation.|
**The following code example shows how to use observables. The ObserverSource class defined in this example is a general-purpose reusable class that you can use as a source of observable events. Examples of using some of the functions in this module are shown here; for functions that are not demonstrated here, you can refer to the code examples in [Control.Event Module &#40;F&#35;&#41;](Control.Event+Module+28%F%2329%.md).**
**[!CODE [FsObservables#1](../CodeSnippet/VS_Snippets_Fsharp/fsobservables/FSharp/fs/program.fs#1)]**
## Platforms
Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2


## Version Information
**F# Core Library Versions**

Supported in: 2.0, 4.0, Portable




## See Also
[Microsoft.FSharp.Control Namespace &#40;F&#35;&#41;](Microsoft.FSharp.Control+Namespace+28%F%2329%.md)

