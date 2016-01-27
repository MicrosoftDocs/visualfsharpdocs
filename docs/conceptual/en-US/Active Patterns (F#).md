# Active Patterns (F#)

*Active patterns* enable you to define named partitions that subdivide input data, so that you can use these names in a pattern matching expression just as you would for a discriminated union. You can use active patterns to decompose data in a customized manner for each partition.


## CAPS_SYNTAX_MD

```
// Complete active pattern definition.
let (|identifer1|identifier2|...|) [ arguments ] = expression
// Partial active pattern definition.
let (|identifier|_|) [ arguments ] = expression
```

## CAPS_REMARKS_MD
In the previous syntax, the identifiers are names for partitions of the input data that is represented by *arguments*, or, in other words, names for subsets of the set of all values of the arguments. There can be up to seven partitions in an active pattern definition. The *expression* describes the form into which to decompose the data. You can use an active pattern definition to define the rules for determining which of the named partitions the values given as arguments belong to. The (| and |) symbols are referred to as *banana clips* and the function created by this type of let binding is called an *active recognizer*.

As an example, consider the following active pattern with an argument.

```

let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd
```

    You can use the active pattern in a pattern matching expression, as in the following example.

```

let TestNumber input =
   match input with
   | Even -> printfn "%d is even" input
   | Odd -> printfn "%d is odd" input

TestNumber 7
TestNumber 11
TestNumber 32
```

    The output of this program is as follows:


```
7 is odd
11 is odd
32 is even
```
Another use of active patterns is to decompose data types in multiple ways, such as when the same underlying data has various possible representations. For example, a **Color** object could be decomposed into an RGB representation or an HSB representation.

```

open System.Drawing

let (|RGB|) (col : System.Drawing.Color) =
     ( col.R, col.G, col.B )

let (|HSB|) (col : System.Drawing.Color) =
   ( col.GetHue(), col.GetSaturation(), col.GetBrightness() )

let printRGB (col: System.Drawing.Color) =
   match col with
   | RGB(r, g, b) -> printfn " Red: %d Green: %d Blue: %d" r g b

let printHSB (col: System.Drawing.Color) =
   match col with
   | HSB(h, s, b) -> printfn " Hue: %f Saturation: %f Brightness: %f" h s b

let printAll col colorString =
  printfn "%s" colorString
  printRGB col
  printHSB col

printAll Color.Red "Red"
printAll Color.Black "Black"
printAll Color.White "White"
printAll Color.Gray "Gray"
printAll Color.BlanchedAlmond "BlanchedAlmond"
```

    The output of the above program is as follows:


```
Red
R: 255 G: 0 B: 0
H: 0.000000 S: 1.000000 B: 0.500000
Black
R: 0 G: 0 B: 0
H: 0.000000 S: 0.000000 B: 0.000000
White
R: 255 G: 255 B: 255
H: 0.000000 S: 0.000000 B: 1.000000
Gray
R: 128 G: 128 B: 128
H: 0.000000 S: 0.000000 B: 0.501961
BlanchedAlmond
R: 255 G: 235 B: 205
H: 36.000000 S: 1.000000 B: 0.901961
```
In combination, these two ways of using active patterns enable you to partition and decompose data into just the appropriate form and perform the appropriate computations on the appropriate data in the form most convenient for the computation.

The resulting pattern matching expressions enable data to be written in a convenient way that is very readable, greatly simplifying potentially complex branching and data analysis code.


## Partial Active Patterns
Sometimes, you need to partition only part of the input space. In that case, you write a set of partial patterns each of which match some inputs but fail to match other inputs. Active patterns that do not always produce a value are called *partial active patterns*; they have a return value that is an option type. To define a partial active pattern, you use a wildcard character (_) at the end of the list of patterns inside the banana clips. The following code illustrates the use of a partial active pattern.

```

let (|Integer|_|) (str: string) =
   let mutable intvalue = 0
   if System.Int32.TryParse(str, &intvalue) then Some(intvalue)
   else None

let (|Float|_|) (str: string) =
   let mutable floatvalue = 0.0
   if System.Double.TryParse(str, &floatvalue) then Some(floatvalue)
   else None

let parseNumeric str =
   match str with
     | Integer i -> printfn "%d : Integer" i
     | Float f -> printfn "%f : Floating point" f
     | _ -> printfn "%s : Not matched." str

parseNumeric "1.1"
parseNumeric "0"
parseNumeric "0.0"
parseNumeric "10"
parseNumeric "Something else"
```

    The output of the previous example is as follows:


```
1.100000 : Floating point
0 : Integer
0.000000 : Floating point
10 : Integer
Something else : Not matched.
```
When using partial active patterns, sometimes the individual choices can be disjoint or mutually exclusive, but they need not be. In the following example, the pattern Square and the pattern Cube are not disjoint, because some numbers are both squares and cubes, such as 64. The following program prints out all integers up to 1000000 that are both squares and cubes.

```

let err = 1.e-10

let isNearlyIntegral (x:float) = abs (x - round(x)) < err

let (|Square|_|) (x : int) =
  if isNearlyIntegral (sqrt (float x)) then Some(x)
  else None

let (|Cube|_|) (x : int) =
  if isNearlyIntegral ((float x) ** ( 1.0 / 3.0)) then Some(x)
  else None

let examineNumber x =
   match x with
      | Cube x -> printfn "%d is a cube" x
      | _ -> ()
   match x with
      | Square x -> printfn "%d is a square" x
      | _ -> ()

let findSquareCubes x =
   if (match x with
       | Cube x -> true
       | _ -> false
       &&
       match x with
       | Square x -> true
       | _ -> false
      )
   then printf "%d \n" x

[ 1 .. 1000000 ] |> List.iter (fun elem -> findSquareCubes elem)
```

    The output is as follows:


```
1
64
729
4096
15625
46656
117649
262144
531441
1000000
```

## Parameterized Active Patterns
Active patterns always take at least one argument for the item being matched, but they may take additional arguments as well, in which case the name *parameterized active pattern* applies. Additional arguments allow a general pattern to be specialized. For example, active patterns that use regular expressions to parse strings often include the regular expression as an extra parameter, as in the following code, which also uses the partial active pattern **Integer** defined in the previous code example. In this example, strings that use regular expressions for various date formats are given to customize the general ParseRegex active pattern. The Integer active pattern is used to convert the matched strings into integers that can be passed to the DateTime constructor.

```

open System.Text.RegularExpressions

// ParseRegex parses a regular expression and returns a list of the strings that match each group in
// the regular expression.
// List.tail is called to eliminate the first element in the list, which is the full matched expression,
// since only the matches for each group are wanted.
let (|ParseRegex|_|) regex str =
   let m = Regex(regex).Match(str)
   if m.Success
   then Some (List.tail [ for x in m.Groups -> x.Value ])
   else None

// Three different date formats are demonstrated here. The first matches two-
// digit dates and the second matches full dates. This code assumes that if a two-digit
// date is provided, it is an abbreviation, not a year in the first century.
let parseDate str =
   match str with
     | ParseRegex "(\d{1,2})/(\d{1,2})/(\d{1,2})$" [Integer m; Integer d; Integer y]
          -> new System.DateTime(y + 2000, m, d)
     | ParseRegex "(\d{1,2})/(\d{1,2})/(\d{3,4})" [Integer m; Integer d; Integer y]
          -> new System.DateTime(y, m, d)
     | ParseRegex "(\d{1,4})-(\d{1,2})-(\d{1,2})" [Integer y; Integer m; Integer d]
          -> new System.DateTime(y, m, d)
     | _ -> new System.DateTime()

let dt1 = parseDate "12/22/08"
let dt2 = parseDate "1/1/2009"
let dt3 = parseDate "2008-1-15"
let dt4 = parseDate "1995-12-28"

printfn "%s %s %s %s" (dt1.ToString()) (dt2.ToString()) (dt3.ToString()) (dt4.ToString())
```

    The output of the previous code is as follows:


```
12/22/2008 12:00:00 AM 1/1/2009 12:00:00 AM 1/15/2008 12:00:00 AM 12/28/1995 12:00:00 AM
```

## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Match Expressions &#40;F&#35;&#41;](Match+Expressions+%28F%23%29.md)

