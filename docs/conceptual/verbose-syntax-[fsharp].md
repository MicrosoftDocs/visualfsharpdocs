---
title: Verbose Syntax (F#)
description: Verbose Syntax (F#)
keywords: visual f#, f#, functional programming
author: dend
manager: danielfe
ms.date: 05/16/2016
ms.topic: language-reference
ms.prod: visual-studio-dev14
ms.technology: devlang-fsharp
ms.assetid: 0a6792b3-b312-4453-a025-21d9760eee5d
redirect_url: https://docs.microsoft.com/dotnet/articles/fsharp/language-reference/verbose-syntax 
---

# Verbose Syntax (F#)

There are two forms of syntax available for many constructs in the F# language: *verbose syntax* and *lightweight syntax*. The verbose syntax is not as commonly used, but has the advantage of being less sensitive to indentation. The lightweight syntax is shorter and uses indentation to signal the beginning and end of constructs, rather than additional keywords like `begin`, `end`, `in`, and so on. The default syntax is the lightweight syntax. This topic describes the syntax for F# constructs when lightweight syntax is not enabled. Verbose syntax is always enabled, so even if you enable lightweight syntax, you can still use verbose syntax for some constructs. You can disable lightweight syntax by using the `#light "off"` directive.


## Table of Constructs
The following table shows the lightweight and verbose syntax for F# language constructs in contexts where there is a difference between the two forms. In this table, angle brackets (&lt;&gt;) enclose user-supplied syntax elements. Refer to the documentation for each language construct for more detailed information about the syntax used within these constructs.



<table>
<tr>
<th>Language construct</th>
<th>Lightweight syntax</th>
<th>Verbose syntax</th>
</tr>
<tr>
<td>
compound expressions
</td>
<td>

<code>&lt;expression1&gt;
&lt;expression2&gt;</code>
</td><td>

<code>&lt;expression1&gt;; &lt;expression2&gt;</code>

</td>
</tr>
<tr><td>


nested <code>let</code> bindings

</td><td>
<code>let f x =
    let a = 1
    let b = 2
    x + a + b</code>

</td><td>

<code>let f x =
    let a = 1 in
    let b = 2 in
    x + a + b</code>

</td>
</tr>
<tr><td>
code block
</td><td>

<code>&lt;expression1&gt;
&lt;expression2&gt;
...</code>

</td><td>

<code>begin
    &lt;expression1&gt;;
    &lt;expression2&gt;;
end</code>
</td>
</tr>
<tr><td>
<code>for...do</code>
</td><td>

<code>for counter = start to finish do
    ...</code>

</td><td>

<code>for counter = start to finish do
    ...
done</code>

</td>
</tr>
<tr><td>
<code>while...do</code>
</td><td>

<code>while &lt;condition&gt; do
    ...</code>

</td><td>

<code>while &lt;condition&gt; do
    ...
done</code>

</td>
</tr>
<tr><td>
<code>for...in</code>
</td><td>

<code>for var in start .. finish do
    ...</code>

</td><td>

<code>for var in start .. finish do
    ...
done</code>

</td>
</tr>
<tr><td>
<code>do</code>
</td><td>

<code>do
    ...</code>

</td><td>

<code>do
    ...
in</code>

</td>
</tr>
<tr><td>record
</td><td>

<code>type &lt;record-name&gt; =
    {
        &lt;field-declarations&gt;
    }
    &lt;value-or-member-definitions&gt;</code>

</td><td>

<code>type &lt;record-name&gt; =
    {
        &lt;field-declarations&gt;
    }
    with
        &lt;value-or-member-definitions&gt;
    end</code>

</td>
</tr>
<tr><td>class
</td><td>
<code>type &lt;class-name&gt;(&lt;params&gt;) =
    ...</code>

</td><td>

<code>type &lt;class-name&gt;(&lt;params&gt;) =
    class
        ...
    end</code>
</td>
</tr>
<tr><td>structure</td><td>

<code>[&lt;StructAttribute&gt;]
type &lt;structure-name&gt; =
    ...</code>
</td><td>

<code>type &lt;structure-name&gt; =
    struct
        ...
    end</code>

</td>
</tr>
<tr><td>discriminated union</td><td>

<code>type &lt;union-name&gt; =
    | ...
    | ...
    ...
    &lt;value-or-member definitions&gt;</code>
</td><td>

<code>type &lt;union-name&gt; =
    | ...
    | ...
    ...
    with
        &lt;value-or-member-definitions&gt;
    end</code>

</td>
</tr>
<tr><td>interface</td><td>

<code>type &lt;interface-name&gt; =
    ...</code>
</td><td>

<code>type &lt;interface-name&gt; =
    interface
        ...
    end</code>

</td>
</tr>
<tr><td>object expression</td><td>

<code>{ new &lt;type-name&gt;
    with
        &lt;value-or-member-definitions&gt;
        &lt;interface-implementations&gt;
}</code>

</td><td>

<code>{ new &lt;type-name&gt;
    with
        &lt;value-or-member-definitions&gt;
    end
    &lt;interface-implementations&gt;
}</code>

</td>
</tr>
<tr><td>interface implementation</td><td>

<code>interface &lt;interface-name&gt;
    with
        &lt;value-or-member-definitions&gt;</code>

</td><td>

<code>interface &lt;interface-name&gt;
    with
        &lt;value-or-member-definitions&gt;
    end</code>

</td>
</tr>
<tr><td>type extension</td><td>

<code>type &lt;type-name&gt;
    with
        &lt;value-or-member-definitions&gt;</code>

</td><td>

<code>type &lt;type-name&gt;
    with
        &lt;value-or-member-definitions&gt;
    end</code>

</td>
</tr>
<tr><td>module</td><td>

<code>module &lt;module-name&gt; =
    ...</code>

</td><td>

<code>module &lt;module-name&gt; =
    begin
        ...
    end</code>

</td>
</tr>
</table>



## See Also
[F&#35; Language Reference](FSharp-Language-Reference.md)

[Compiler Directives &#40;F&#35;&#41;](Compiler-Directives-%5BFSharp%5D.md)

[Code Formatting Guidelines &#40;F&#35;&#41;](Code-Formatting-Guidelines-%5BFSharp%5D.md)