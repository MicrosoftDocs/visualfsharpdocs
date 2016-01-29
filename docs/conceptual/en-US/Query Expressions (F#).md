# Query Expressions (F#)

Query expressions enable you to query a data source and put the data in a desired form. Query expressions provide support for LINQ in F#.


## CAPS_SYNTAX_MD

```
query { expression }
```

## CAPS_REMARKS_MD
Query expressions are a type of computation expression similar to sequence expressions. Just as you specify a sequence by providing code in a sequence expression, you specify a set of data by providing code in a query expression. In a sequence expression, the **yield** keyword identifies data to be returned as part of the resulting sequence. In query expressions, the **select** keyword performs the same function. In addition to the **select** keyword, F# also supports a number of query operators that are much like the parts of a SQL SELECT statement. Here is an example of a simple query expression, along with code that connects to the Northwind OData source.


```f#
// Use the OData type provider to create types that can be used to access the Northwind database.
// Add References to FSharp.Data.TypeProviders and System.Data.Services.Client
open Microsoft.FSharp.Data.TypeProviders

type Northwind = ODataService<"http://services.odata.org/Northwind/Northwind.svc">
let db = Northwind.GetDataContext()

// A query expression.
let query1 = query { for customer in db.Customers do
select customer }

query1
|> Seq.iter (fun customer -> printfn "Company: %s Contact: %s" customer.CompanyName customer.ContactName)
```
In the previous code example, the query expression is in curly braces. The meaning of the code in the expression is, return every customer in the Customers table in the database in the query results. Query expressions return a type that implements **T:System.Linq.IQueryable&#96;1** and **T:System.Collections.Generic.IEnumerable&#96;1**, and so they can be iterated using the [Seq module](http://msdn.microsoft.com/en-us/library/54e8f059-ca52-4632-9ae9-49685ee9b684) as the example shows.

Every computation expression type is built from a builder class. The builder class for the query computation expression is **QueryBuilder**. For more information, see [Computation Expressions &#40;F&#35;&#41;](Computation+Expressions+%28F%23%29.md) and [Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder+Class+%28F%23%29.md).


## Query Operators
Query operators enable you to specify the details of the query, such as to put criteria on records to be returned, or specify the sorting order of results. The query source must support the query operator. If you attempt to use an unsupported query operator, **T:System.NotSupportedException** will be thrown.

Only expressions that can be translated to SQL are allowed in query expressions. For example, no function calls are allowed in the expressions when you use the **where** query operator.

Table 1 shows available query operators. In addition, see Table2, which compares SQL queries and the equivalent F# query expressions later in this topic. Some query operators aren't supported by some type providers. In particular, the OData type provider is limited in the query operators that it supports due to limitations in OData. For more information, see [ODataService Type Provider (F#)](http://msdn.microsoft.com/en-us/library/bac609dd-9d12-4bf9-a662-24bdf4faa43e).

This table assumes a database in the following form:

![Sample Database Diagram](images/StudentCourseDB.png)

The code in the tables that follow also assumes the following database connection code. Projects should add references to System.Data,  System.Data.Linq, and FSharp.Data.TypeProviders assemblies. The code that creates this database is included at the end of this topic.


```f#
open System
open Microsoft.FSharp.Data.TypeProviders
open System.Data.Linq.SqlClient
open System.Linq
open Microsoft.FSharp.Linq



type schema = SqlDataConnection<"Data Source=SERVER\INSTANCE;Initial Catalog=MyDatabase;Integrated Security=SSPI;">

let db = schema.GetDataContext()

// Needed for some query operator examples:
let data = [ 1; 5; 7; 11; 18; 21]
```

### Table 1. Query Operators


||
|-|
|**Operator**|**Description**|
|**contains**|Determines whether the selected elements include a specified element.<br /><br /><br />```f#<br />let isStudent11 =<br />query {<br />for student in db.Student do<br />select student.Age.Value<br />contains 11<br />}<br />```|
|**count**|Returns the number of selected elements.<br /><br /><br />```f#<br />let countOfStudents =<br />query {<br />for student in db.Student do<br />select student<br />count<br />}<br />```|
|**last**|Selects the last element of those selected so far.<br /><br /><br />```f#<br />let number = <br />query {<br />for number in data do<br />last<br />}<br />```|
|**lastOrDefault**|Selects the last element of those selected so far, or a default value if no element is found.<br /><br /><br />```f#<br />let number =<br />query {<br />for number in data do<br />where (number < 0)<br />lastOrDefault<br />}<br />```|
|**exactlyOne**|Selects the single, specific element selected so far. If multiple elements are present, an exception is thrown.<br /><br /><br />```f#<br />let student =<br />query {<br />for student in db.Student do<br />where (student.StudentID = 1)<br />select student<br />exactlyOne<br />}<br />```|
|**exactlyOneOrDefault**|Selects the single, specific element of those selected so far, or a default value if that element is not found.<br /><br /><br />```f#<br />let student =<br />query {<br />for student in db.Student do<br />where (student.StudentID = 1)<br />select student<br />exactlyOneOrDefault<br />}<br />```|
|**headOrDefault**|Selects the first element of those selected so far, or a default value if the sequence contains no elements.<br /><br /><br />```f#<br />let student =<br />query {<br />for student in db.Student do<br />select student<br />headOrDefault<br />}<br />```|
|**select**|Projects each of the elements selected so far.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />select student<br />}<br />```|
|**where**|Selects elements based on a specified predicate.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />where (student.StudentID > 4)<br />select student<br />}<br />```|
|**minBy**|Selects a value for each element selected so far and returns the minimum resulting value.<br /><br /><br />```f#<br />let student =<br />query {<br />for student in db.Student do<br />minBy student.StudentID<br />}<br />```|
|**maxBy**|Selects a value for each element selected so far and returns the maximum resulting value.<br /><br /><br />```f#<br />let student =<br />query {<br />for student in db.Student do<br />maxBy student.StudentID<br />}<br />```|
|**groupBy**|Groups the elements selected so far according to a specified key selector.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />groupBy student.Age into g<br />select (g.Key, g.Count())<br />}<br />```|
|**sortBy**|Sorts the elements selected so far in ascending order by the given sorting key.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortBy student.Name<br />select student<br />}<br />```|
|**sortByDescending**|Sorts the elements selected so far in descending order by the given sorting key.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortByDescending student.Name<br />select student<br />}<br />```|
|**thenBy**|Performs a subsequent ordering of the elements selected so far in ascending order by the given sorting key. This operator may only be used after a **sortBy**, **sortByDescending**, **thenBy**, or **thenByDescending**.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />where student.Age.HasValue<br />sortBy student.Age.Value<br />thenBy student.Name<br />select student<br />}<br />```|
|**thenByDescending**|Performs a subsequent ordering of the elements selected so far in descending order by the given sorting key. This operator may only be used after a **sortBy**, **sortByDescending**, **thenBy**, or **thenByDescending**.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />where student.Age.HasValue<br />sortBy student.Age.Value<br />thenByDescending student.Name<br />select student<br />}<br />```|
|**groupValBy**|Selects a value for each element selected so far and groups the elements by the given key.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />groupValBy student.Name student.Age into g<br />select (g, g.Key, g.Count())<br />}<br />```|
|**join**|Correlates two sets of selected values based on matching keys. Note that the order of the keys around the = sign in a join expression is significant. In all joins, if the line is split after the **-&gt;** symbol, the indentation must be indented at least as far as the keyword **for**.<br /><br /><br />```f#<br />query {<br />for student in db.Student do <br />join selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID)<br />select (student, selection)<br />}<br />```|
|**groupJoin**|Correlates two sets of selected values based on matching keys and groups the results. Note that the order of the keys around the = sign in a join expression is significant.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />groupJoin courseSelection in db.CourseSelection on<br />(student.StudentID = courseSelection.StudentID) into g<br />for courseSelection in g do<br />join course in db.Course on (courseSelection.CourseID = course.CourseID)<br />select (student.Name, course.CourseName)<br />}<br />```|
|**leftOuterJoin**|Correlates two sets of selected values based on matching keys and groups the results. If any group is empty, a group with a single default value is used instead. Note that the order of the keys around the = sign in a join expression is significant.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />leftOuterJoin selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID) into result<br />for selection in result.DefaultIfEmpty() do<br />select (student, selection)<br />}<br />```|
|**sumByNullable**|Selects a nullable value for each element selected so far and returns the sum of these values. If any nullable does not have a value, it is ignored.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sumByNullable student.Age<br />}<br />```|
|**minByNullable**|Selects a nullable value for each element selected so far and returns the minimum of these values. If any nullable does not have a value, it is ignored.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />minByNullable student.Age<br />}<br />```|
|**maxByNullable**|Selects a nullable value for each element selected so far and returns the maximum of these values. If any nullable does not have a value, it is ignored.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />maxByNullable student.Age<br />}<br />```|
|**averageByNullable**|Selects a nullable value for each element selected so far and returns the average of these values. If any nullable does not have a value, it is ignored.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />averageByNullable (Nullable.float student.Age)<br />}<br />```|
|**averageBy**|Selects a value for each element selected so far and returns the average of these values.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />averageBy (float student.StudentID)<br />}<br />```|
|**distinct**|Selects distinct elements from the elements selected so far.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />join selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID)<br />distinct        <br />}<br />```|
|**exists**|Determines whether any element selected so far satisfies a condition.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />where (query { for courseSelection in db.CourseSelection do<br />exists (courseSelection.StudentID = student.StudentID) })<br />select student<br />}<br />```|
|**find**|Selects the first element selected so far that satisfies a specified condition.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />find (student.Name = "Abercrombie, Kim")<br />}<br />```|
|**all**|Determines whether all elements selected so far satisfy a condition.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />all (SqlMethods.Like(student.Name, "%,%"))<br />}<br />```|
|**head**|Selects the first element from those selected so far.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />head<br />}<br />```|
|**nth**|Selects the element at a specified index amongst those selected so far.<br /><br /><br />```f#<br />query {<br />for numbers in data do<br />nth 3<br />}<br />```|
|**skip**|Bypasses a specified number of the elements selected so far and then selects the remaining elements.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />skip 1<br />}<br />```|
|**skipWhile**|Bypasses elements in a sequence as long as a specified condition is true and then selects the remaining elements.<br /><br /><br />```f#<br />query {<br />for number in data do<br />skipWhile (number < 3)<br />select student<br />}<br />```|
|**sumBy**|Selects a value for each element selected so far and returns the sum of these values.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sumBy student.StudentID<br />}<br />```|
|**take**|Selects a specified number of contiguous elements from those selected so far.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />select student<br />take 2<br />}<br />```|
|**takeWhile**|Selects elements from a sequence as long as a specified condition is true, and then skips the remaining elements.<br /><br /><br />```f#<br />query {<br />for number in data do<br />takeWhile (number < 10)<br />}<br />```|
|**sortByNullable**|Sorts the elements selected so far in ascending order by the given nullable sorting key.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortByNullable student.Age<br />select student<br />}<br />```|
|**sortByNullableDescending**|Sorts the elements selected so far in descending order by the given nullable sorting key.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortByNullableDescending student.Age<br />select student<br />}<br />```|
|**thenByNullable**|Performs a subsequent ordering of the elements selected so far in ascending order by the given nullable sorting key. This operator may only be used immediately after a **sortBy**, **sortByDescending**, **thenBy**, or **thenByDescending**, or their nullable variants.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortBy student.Name<br />thenByNullable student.Age<br />select student<br />}<br />```|
|**thenByNullableDescending**|Performs a subsequent ordering of the elements selected so far in descending order by the given nullable sorting key. This operator may only be used immediately after a **sortBy**, **sortByDescending**, **thenBy**, or **thenByDescending**, or their nullable variants.<br /><br /><br />```f#<br />query {<br />for student in db.Student do<br />sortBy student.Name<br />thenByNullableDescending student.Age<br />select student<br />}<br />```|

## Comparison of Transact-SQL and F# Query Expressions
The following table shows some common Transact-SQL queries and their equivalents in F#. The code in this table also assumes the same database as the previous table and the same initial code to set up the type provider.


### Table 2. Transact-SQL and F# Query Expressions


|Transact-SQL (not case sensitive)|F# Query Expression (case sensitive)|
|---------------------------------|------------------------------------|
|Select all fields from table.<br /><br /><br />```tsql<br />SELECT * FROM Student<br />```|```f#<br />// All students.<br />query {<br />for student in db.Student do<br />select student<br />}<br />```|
|Count records in a table.<br /><br /><br />```tsql<br />SELECT COUNT(*) FROM Student<br />```|```f#<br />// Count of students.<br />query {<br />for student in db.Student do        <br />count<br />}<br />```|
|**EXISTS**<br /><br /><br />```tsql<br />SELECT * FROM Student<br />WHERE EXISTS <br />(SELECT * FROM CourseSelection<br />WHERE CourseSelection.StudentID = Student.StudentID)<br />```|```f#<br />// Find students who have signed up at least one course.<br />query {<br />for student in db.Student do<br />where (query { for courseSelection in db.CourseSelection do<br />exists (courseSelection.StudentID = student.StudentID) })<br />select student<br />}<br />```|
|Grouping<br /><br /><br />```tsql<br />SELECT Student.Age, COUNT(*) FROM Student<br />GROUP BY Student.Age<br />```|```f#<br />// Group by age and count.<br />query {<br />for n in db.Student do<br />groupBy n.Age into g<br />select (g.Key, g.Count())<br />}<br />// OR<br />query {<br />for n in db.Student do<br />groupValBy n.Age n.Age into g<br />select (g.Key, g.Count())<br />}<br />```|
|Grouping with condition.<br /><br /><br />```tsql<br />SELECT Student.Age, COUNT(*) <br />FROM Student<br />GROUP BY Student.Age<br />HAVING student.Age > 10<br />```|```f#<br />// Group students by age where age > 10.<br />query {<br />for student in db.Student do<br />groupBy student.Age into g<br />where (g.Key.HasValue && g.Key.Value > 10)<br />select (g.Key, g.Count())<br />}<br />```|
|Grouping with count condition.<br /><br /><br />```tsql<br />SELECT Student.Age, COUNT(*)<br />FROM Student<br />GROUP BY Student.Age<br />HAVING COUNT(*) > 1<br />```|```f#<br />// Group students by age and count number of students<br />// at each age with more than 1 student.<br />query {<br />for student in db.Student do<br />groupBy student.Age into group<br />where (group.Count() > 1)<br />select (group.Key, group.Count())<br />}<br />```|
|Grouping, counting, and summing.<br /><br /><br />```tsql<br />SELECT Student.Age, COUNT(*), SUM(Student.Age) as total<br />FROM Student<br />GROUP BY Student.Age<br />```|```f#<br />// Group students by age and sum ages.<br />query {<br />for student in db.Student do<br />groupBy student.Age into g        <br />let total = query { for student in g do<br />sumByNullable student.Age }<br />select (g.Key, g.Count(), total)<br />}<br />```|
|Grouping, counting, and ordering by count.<br /><br /><br />```tsql<br />SELECT Student.Age, COUNT(*) as myCount<br />FROM Student<br />GROUP BY Student.Age<br />HAVING COUNT(*) > 1<br />ORDER BY COUNT(*) DESC<br />```|```f#<br />// Group students by age, count number of students<br />// at each age, and display all with count > 1<br />// in descending order of count.<br />query {<br />for student in db.Student do<br />groupBy student.Age into g<br />where (g.Count() > 1)        <br />sortByDescending (g.Count())<br />select (g.Key, g.Count())<br />}<br />```|
|**IN** a set of specified values<br /><br /><br />```tsql<br />SELECT *<br />FROM Student<br />WHERE Student.StudentID IN (1, 2, 5, 10)<br />```|```f#<br />// Select students where studentID is one of a given list.<br />let idQuery = query { for id in [1; 2; 5; 10] do<br />select id }<br />query { <br />for student in db.Student do<br />where (idQuery.Contains(student.StudentID))<br />select student<br />}<br />```|
|**LIKE** and **TOP**.<br /><br /><br />```tsql<br />-- '_e%' matches strings where the second character is 'e'<br />SELECT TOP 2 * FROM Student<br />WHERE Student.Name LIKE '_e%'<br />```|```f#<br />// Look for students with Name match _e% pattern and take first two.<br />query {<br />for student in db.Student do<br />where (SqlMethods.Like( student.Name, "_e%") )<br />select student<br />take 2   <br />}<br />```|
|**LIKE** with pattern match set.<br /><br /><br />```tsql<br />-- '[abc]%' matches strings where the first character is<br />-- 'a', 'b', 'c', 'A', 'B', or 'C'<br />SELECT * FROM Student<br />WHERE Student.Name LIKE '[abc]%'<br />```|```f#<br />open System.Data.Linq.SqlClient;<br /><br />printfn "\nLook for students with Name matching [abc]%% pattern."<br />query {<br />for student in db.Student do<br />where (SqlMethods.Like( student.Name, "[abc]%") )<br />select student  <br />}<br />```|
|**LIKE** with set exclusion pattern.<br /><br /><br />```tsql<br />-- '[^abc]%' matches strings where the first character is<br />-- not 'a', 'b', 'c', 'A', 'B', or 'C'<br />SELECT * FROM Student<br />WHERE Student.Name LIKE '[^abc]%'<br />```|```f#<br />// Look for students with name matching [^abc]%% pattern.<br />query {<br />for student in db.Student do<br />where (SqlMethods.Like( student.Name, "[^abc]%") )<br />select student  <br />}<br />```|
|**LIKE** on one field, but select a different field.<br /><br /><br />```tsql<br />SELECT StudentID AS ID FROM Student<br />WHERE Student.Name LIKE '[^abc]%'<br />```|```f#<br />open System.Data.Linq.SqlClient;<br /><br />printfn "\nLook for students with name matching [^abc]%% pattern and select ID."<br />query {<br />for n in db.Student do<br />where (SqlMethods.Like( n.Name, "[^abc]%") )<br />select n.StudentID    <br />}<br />&#124;> Seq.iter (fun id -> printfn "%d" id)<br />```|
|**LIKE**, with substring search.<br /><br /><br />```tsql<br />SELECT * FROM Student<br />WHERE Student.Name like '%A%'<br />```|```f#<br />// Using Contains as a query filter.<br />query {<br />for student in db.Student do<br />where (student.Name.Contains("a"))<br />select student<br />}<br />```|
|Simple **JOIN** with two tables.<br /><br /><br />```tsql<br />SELECT * FROM Student<br />JOIN CourseSelection <br />ON Student.StudentID = CourseSelection.StudentID<br />```|```f#<br />// Join Student and CourseSelection tables.<br />query {<br />for student in db.Student do <br />join selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID)<br />select (student, selection)<br />}<br />```|
|**LEFT JOIN** with two tables.<br /><br /><br />```tsql<br />SELECT * FROM <br />Student LEFT JOIN CourseSelection <br />ON Student.StudentID = CourseSelection.StudentID<br />```|```f#<br />//Left Join Student and CourseSelection tables.<br />query {<br />for student in db.Student do<br />leftOuterJoin selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID) into result<br />for selection in result.DefaultIfEmpty() do<br />select (student, selection)<br />}<br />```|
|**JOIN** with **COUNT**<br /><br /><br />```tsql<br />SELECT COUNT(*) FROM <br />Student JOIN CourseSelection <br />ON Student.StudentID = CourseSelection.StudentID<br />```|```f#<br />// Join with count.<br />query {<br />for n in db.Student do <br />join e in db.CourseSelection on<br />(n.StudentID = e.StudentID)<br />count        <br />}<br />```|
|**DISTINCT**<br /><br /><br />```tsql<br />SELECT DISTINCT StudentID FROM CourseSelection<br />```|```f#<br />// Join with distinct.<br />query {<br />for student in db.Student do<br />join selection in db.CourseSelection on<br />(student.StudentID = selection.StudentID)<br />distinct        <br />}<br />```|
|Distinct count.<br /><br /><br />```tsql<br />SELECT DISTINCT COUNT(StudentID) FROM CourseSelection<br />```|```f#<br />// Join with distinct and count.<br />query {<br />for n in db.Student do <br />join e in db.CourseSelection on<br />n.StudentID = e.StudentID)<br />distinct<br />count       <br />}<br />```|
|**BETWEEN**<br /><br /><br />```tsql<br />SELECT * FROM Student<br />WHERE Student.Age BETWEEN 10 AND 15<br />```|```f#<br />// Selecting students with ages between 10 and 15.<br />query {<br />for student in db.Student do<br />where (student.Age ?>= 10 && student.Age ?< 15)<br />select student<br />}<br />```|
|**OR**<br /><br /><br />```tsql<br />SELECT * FROM Student<br />WHERE Student.Age =11 OR Student.Age = 12<br />```|```f#<br />// Selecting students with age that's either 11 or 12.<br />query {<br />for student in db.Student do<br />where (student.Age.Value = 11 &#124;&#124; student.Age.Value = 12)<br />select student<br />}<br />```|
|**OR** with ordering<br /><br /><br />```tsql<br />SELECT * FROM Student<br />WHERE Student.Age =12 OR Student.Age = 13<br />ORDER BY Student.Age DESC<br />```|```f#<br />// Selecting students in a certain age range and sorting.<br />query {<br />for n in db.Student do<br />where (n.Age.Value = 12 &#124;&#124; n.Age.Value = 13)<br />sortByNullableDescending n.Age<br />select n<br />}<br />```|
|**TOP**, **OR**, and ordering.<br /><br /><br />```tsql<br />SELECT TOP 2 student.Name FROM Student<br />WHERE Student.Age = 11 OR Student.Age = 12<br />ORDER BY Student.Name DESC<br />```|```f#<br />// Selecting students with certain ages,<br />// taking account of the possibility of nulls.<br />query {<br />for student in db.Student do<br />where ((student.Age.HasValue && student.Age.Value = 11) &#124;&#124;<br />(student.Age.HasValue && student.Age.Value = 12))<br />sortByDescending student.Name<br />select student.Name<br />take 2<br />}<br />```|
|**UNION** of two queries.<br /><br /><br />```tsql<br />SELECT * FROM Student<br />UNION<br />SELECT * FROM lastStudent<br />```|```f#<br />// Union of two queries.<br />module Queries =<br />let query1 = query {<br />for n in db.Student do<br />select (n.Name, n.Age)<br />}<br /><br />let query2 = query {<br />for n in db.LastStudent do<br />select (n.Name, n.Age)<br />}<br /><br />query2.Union (query1)<br />```|
|Intersection of two queries.<br /><br /><br />```tsql<br />SELECT * FROM Student<br />INTERSECT<br />SELECT * FROM LastStudent<br />```|```f#<br />// Intersect of two queries.<br />module Queries2 =<br />let query1 = query {<br />for n in db.Student do<br />select (n.Name, n.Age)<br />}<br /><br />let query2 = query {<br />for n in db.LastStudent do<br />select (n.Name, n.Age)<br />}<br /><br />query1.Intersect(query2)<br />```|
|**CASE** condition.<br /><br /><br />```tsql<br />SELECT student.StudentID, <br />CASE Student.Age<br />WHEN -1 THEN 100<br />ELSE Student.Age<br />END,<br />Student.Age<br />from Student<br />```|```f#<br />// Using if statement to alter results for special value.<br />query {<br />for student in db.Student do<br />select (if student.Age.HasValue && student.Age.Value = -1 then<br />(student.StudentID, System.Nullable<int>(100), student.Age)<br />else (student.StudentID, student.Age, student.Age))<br />}<br />```|
|Multiple cases.<br /><br /><br />```tsql<br />SELECT Student.StudentID, <br />CASE Student.Age<br />WHEN -1 THEN 100<br />WHEN 0 THEN 1000<br />ELSE Student.Age<br />END,<br />Student.Age<br />FROM Student<br />```|```f#<br />// Using if statement to alter results for special values.<br />query {<br />for student in db.Student do<br />select (if student.Age.HasValue && student.Age.Value = -1 then<br />(student.StudentID, System.Nullable<int>(100), student.Age)<br />elif student.Age.HasValue && student.Age.Value = 0 then<br />(student.StudentID, System.Nullable<int>(1000), student.Age)<br />else (student.StudentID, student.Age, student.Age))<br />}<br />```|
|Multiple tables.<br /><br /><br />```tsql<br />SELECT * FROM Student, Course<br />```|```f#<br />// Multiple table select.<br />query {<br />for student in db.Student do<br />for course in db.Course do<br />select (student, course)<br />}<br />```|
|Multiple joins.<br /><br /><br />```tsql<br />SELECT Student.Name, Course.CourseName<br />FROM Student<br />JOIN CourseSelection<br />ON CourseSelection.StudentID = Student.StudentID<br />JOIN Course<br />ON Course.CourseID = CourseSelection.CourseID<br />```|```f#<br />// Multiple joins.<br />query {<br />for student in db.Student do<br />join courseSelection in db.CourseSelection on<br />(student.StudentID = courseSelection.StudentID)<br />join course in db.Course on<br />(courseSelection.CourseID = course.CourseID)<br />select (student.Name, course.CourseName)<br />}<br />```|
|Multiple left outer joins.<br /><br /><br />```tsql<br />SELECT Student.Name, Course.CourseName<br />FROM Student<br />LEFT OUTER JOIN CourseSelection<br />ON CourseSelection.StudentID = Student.StudentID<br />LEFT OUTER JOIN Course<br />ON Course.CourseID = CourseSelection.CourseID<br />```|```f#<br />// Using leftOuterJoin with multiple joins.<br />query {<br />for student in db.Student do<br />leftOuterJoin courseSelection in db.CourseSelection on<br />(student.StudentID = courseSelection.StudentID) into g1<br />for courseSelection in g1.DefaultIfEmpty() do<br />leftOuterJoin course in db.Course on<br />(courseSelection.CourseID = course.CourseID) into g2<br />for course in g2.DefaultIfEmpty() do<br />select (student.Name, course.CourseName)<br />}<br />```|
The following code can be used to create the sample database for these examples.


```tsql
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [master];
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'MyDatabase')
DROP DATABASE MyDatabase;
GO

-- Create the MyDatabase database.
CREATE DATABASE MyDatabase COLLATE SQL_Latin1_General_CP1_CI_AS;
GO

-- Specify a simple recovery model 
-- to keep the log growth to a minimum.
ALTER DATABASE MyDatabase
SET RECOVERY SIMPLE;
GO

USE MyDatabase;
GO

CREATE TABLE [dbo].[Course] (
[CourseID]   INT           NOT NULL,
[CourseName] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([CourseID] ASC)
);

CREATE TABLE [dbo].[Student] (
[StudentID] INT           NOT NULL,
[Name]      NVARCHAR (50) NOT NULL,
[Age]       INT           NULL,
PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

CREATE TABLE [dbo].[CourseSelection] (
[ID]        INT NOT NULL,
[StudentID] INT NOT NULL,
[CourseID]  INT NOT NULL,
PRIMARY KEY CLUSTERED ([ID] ASC),
CONSTRAINT [FK_CourseSelection_ToTable] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student] ([StudentID]) ON DELETE NO ACTION ON UPDATE NO ACTION,
CONSTRAINT [FK_CourseSelection_Course_1] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Course] ([CourseID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE [dbo].[LastStudent] (
[StudentID] INT           NOT NULL,
[Name]      NVARCHAR (50) NOT NULL,
[Age]       INT           NULL,
PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

-- Insert data into the tables.
USE MyDatabase
INSERT INTO Course (CourseID, CourseName)
VALUES(1, 'Algebra I');
INSERT INTO Course (CourseID, CourseName)
VALUES(2, 'Trigonometry');
INSERT INTO Course (CourseID, CourseName)
VALUES(3, 'Algebra II');
INSERT INTO Course (CourseID, CourseName)
VALUES(4, 'History');
INSERT INTO Course (CourseID, CourseName)
VALUES(5, 'English');
INSERT INTO Course (CourseID, CourseName)
VALUES(6, 'French');
INSERT INTO Course (CourseID, CourseName)
VALUES(7, 'Chinese');

INSERT INTO Student (StudentID, Name, Age)
VALUES(1, 'Abercrombie, Kim', 10);
INSERT INTO Student (StudentID, Name, Age)
VALUES(2, 'Abolrous, Hazen', 14);
INSERT INTO Student (StudentID, Name, Age)
VALUES(3, 'Hance, Jim', 12);
INSERT INTO Student (StudentID, Name, Age)
VALUES(4, 'Adams, Terry', 12);
INSERT INTO Student (StudentID, Name, Age)
VALUES(5, 'Hansen, Claus', 11);
INSERT INTO Student (StudentID, Name, Age)
VALUES(6, 'Penor, Lori', 13);
INSERT INTO Student (StudentID, Name, Age)
VALUES(7, 'Perham, Tom', 12);
INSERT INTO Student (StudentID, Name, Age)
VALUES(8, 'Peng, Yun-Feng', NULL);

INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(1, 1, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(2, 1, 3);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(3, 1, 5);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(4, 2, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(5, 2, 5);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(6, 2, 6);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(7, 2, 3);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(8, 3, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(9, 3, 1);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(10, 4, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(11, 4, 5);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(12, 4, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(13, 5, 3);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(14, 5, 2);
INSERT INTO CourseSelection (ID, StudentID, CourseID)
VALUES(15, 7, 3);
```
The following code contains  the sample code that appears in this topic.


```f#
#if INTERACTIVE
#r "FSharp.Data.TypeProviders.dll"
#r "System.Data.dll"
#r "System.Data.Linq.dll"
#endif
open System
open Microsoft.FSharp.Data.TypeProviders
open System.Data.Linq.SqlClient
open System.Linq

[<Generate>]
type schema = SqlDataConnection<"Data Source=SERVER\INSTANCE;Initial Catalog=MyDatabase;Integrated Security=SSPI;">

let db = schema.GetDataContext()

let student = db.Student

let data = [1; 5; 7; 11; 18; 21]

open System
type Nullable<'T when 'T : ( new : unit -> 'T) and 'T : struct and 'T :> ValueType > with
member this.Print() =
if (this.HasValue) then this.Value.ToString()
else "NULL"

printfn "\ncontains query operator"
query {
for student in db.Student do
select student.Age.Value
contains 11
}
|> printfn "Is at least one student age 11? %b" 

printfn "\ncount query operator"
query {
for student in db.Student do
select student
count
}
|> printfn "Number of students: %d" 


printfn "\nlast query operator." 
let num =
query {
for number in data do
sortBy number
last
}
printfn "Last number: %d" num


open Microsoft.FSharp.Linq

printfn "\nlastOrDefault query operator." 
query {
for number in data do
sortBy number
lastOrDefault
}
|> printfn "lastOrDefault: %d"

printfn "\nexactlyOne query operator."
let student2 =
query {
for student in db.Student do
where (student.StudentID = 1)
select student
exactlyOne
}
printfn "Student with StudentID = 1 is %s" student2.Name

printfn "\nexactlyOneOrDefault query operator."
let student3 =
query {
for student in db.Student do
where (student.StudentID = 1)
select student
exactlyOneOrDefault
}
printfn "Student with StudentID = 1 is %s" student3.Name

printfn "\nheadOrDefault query operator."
let student4 =
query {
for student in db.Student do
select student
headOrDefault
}
printfn "head student is %s" student4.Name

printfn "\nselect query operator."
query {
for student in db.Student do
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.StudentID student.Name)

printfn "\nwhere query operator."
query {
for student in db.Student do
where (student.StudentID > 4)
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.StudentID student.Name)

printfn "\nminBy query operator."
let student5 =
query {
for student in db.Student do
minBy student.StudentID
}

printfn "\nmaxBy query operator."
let student6 =
query {
for student in db.Student do
maxBy student.StudentID
}

printfn "\ngroupBy query operator."
query {
for student in db.Student do
groupBy student.Age into g
select (g.Key, g.Count())
}
|> Seq.iter (fun (age, count) -> printfn "Age: %s Count at that age: %d" (age.Print()) count)

printfn "\nsortBy query operator."
query {
for student in db.Student do
sortBy student.Name
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.StudentID student.Name)

printfn "\nsortByDescending query operator."
query {
for student in db.Student do
sortByDescending student.Name
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.StudentID student.Name)

printfn "\nthenBy query operator."
query {
for student in db.Student do
where student.Age.HasValue
sortBy student.Age.Value
thenBy student.Name
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.Age.Value student.Name)

printfn "\nthenByDescending query operator."
query {
for student in db.Student do
where student.Age.HasValue
sortBy student.Age.Value
thenByDescending student.Name
select student
}
|> Seq.iter (fun student -> printfn "StudentID, Name: %d %s" student.Age.Value student.Name)

printfn "\ngroupValBy query operator."
query {
for student in db.Student do
groupValBy student.Name student.Age into g
select (g, g.Key, g.Count())
}
|> Seq.iter (fun (group, age, count) ->
printfn "Age: %s Count at that age: %d" (age.Print()) count
group |> Seq.iter (fun name -> printfn "Name: %s" name))

printfn "\n sumByNullable query operator"
query {
for student in db.Student do
sumByNullable student.Age
}
|> (fun sum -> printfn "Sum of ages: %s" (sum.Print()))

printfn "\n minByNullable"
query {
for student in db.Student do
minByNullable student.Age
}
|> (fun age -> printfn "Minimum age: %s" (age.Print()))

printfn "\n maxByNullable"
query {
for student in db.Student do
maxByNullable student.Age
}
|> (fun age -> printfn "Maximum age: %s" (age.Print()))

printfn "\n averageBy"
query {
for student in db.Student do
averageBy (float student.StudentID)
}
|> printfn "Average student ID: %f"

printfn "\n averageByNullable"
query {
for student in db.Student do
averageByNullable (Nullable.float student.Age)
}
|> (fun avg -> printfn "Average age: %s" (avg.Print()))

printfn "\n find query operator"
query {
for student in db.Student do
find (student.Name = "Abercrombie, Kim")
}
|> (fun student -> printfn "Found a match with StudentID = %d" student.StudentID)

printfn "\n all query operator"
query {
for student in db.Student do
all (SqlMethods.Like(student.Name, "%,%"))
}
|> printfn "Do all students have a comma in the name? %b"

printfn "\n head query operator"
query {
for student in db.Student do
head
}
|> (fun student -> printfn "Found the head student with StudentID = %d" student.StudentID)

printfn "\n nth query operator"
query {
for numbers in data do
nth 3
}
|> printfn "Third number is %d"

printfn "\n skip query operator"
query {
for student in db.Student do
skip 1
}
|> Seq.iter (fun student -> printfn "StudentID = %d" student.StudentID)

printfn "\n skipWhile query operator"
query {
for number in data do
skipWhile (number < 3)
select number
}
|> Seq.iter (fun number -> printfn "Number = %d" number)


printfn "\n sumBy query operator"
query {
for student in db.Student do
sumBy student.StudentID
}
|> printfn "Sum of student IDs: %d" 

printfn "\n take query operator"
query {
for student in db.Student do
select student
take 2
}
|> Seq.iter (fun student -> printfn "StudentID = %d" student.StudentID)

printfn "\n takeWhile query operator"
query {
for number in data do
takeWhile (number < 10)
}
|> Seq.iter (fun number -> printfn "Number = %d" number)

printfn "\n sortByNullable query operator"
query {
for student in db.Student do
sortByNullable student.Age
select student
}
|> Seq.iter (fun student ->
printfn "StudentID, Name, Age: %d %s %s" student.StudentID student.Name (student.Age.Print()))

printfn "\n sortByNullableDescending query operator"
query {
for student in db.Student do
sortByNullableDescending student.Age
select student
}
|> Seq.iter (fun student ->
printfn "StudentID, Name, Age: %d %s %s" student.StudentID student.Name (student.Age.Print()))

printfn "\n thenByNullable query operator"
query {
for student in db.Student do
sortBy student.Name
thenByNullable student.Age
select student
}
|> Seq.iter (fun student ->
printfn "StudentID, Name, Age: %d %s %s" student.StudentID student.Name (student.Age.Print()))

printfn "\n thenByNullableDescending query operator"
query {
for student in db.Student do
sortBy student.Name
thenByNullableDescending student.Age
select student
}
|> Seq.iter (fun student ->
printfn "StudentID, Name, Age: %d %s %s" student.StudentID student.Name (student.Age.Print()))

printfn "All students: "
query {
for student in db.Student do
select student
}
|> Seq.iter (fun student -> printfn "%s %d %s" student.Name student.StudentID (student.Age.Print()))

printfn "\nCount of students: "
query {
for student in db.Student do        
count
}
|>  (fun count -> printfn "Student count: %d" count)

printfn "\nExists."
query {
for student in db.Student do
where (query { for courseSelection in db.CourseSelection do
exists (courseSelection.StudentID = student.StudentID) })
select student }
|> Seq.iter (fun student -> printfn "%A" student.Name)

printfn "\n Group by age and count"
query {
for n in db.Student do
groupBy n.Age into g
select (g.Key, g.Count())
}
|> Seq.iter (fun (age, count) -> printfn "%s %d" (age.Print()) count)

printfn "\n Group value by age."
query {
for n in db.Student do
groupValBy n.Age n.Age into g
select (g.Key, g.Count())
}
|> Seq.iter (fun (age, count) -> printfn "%s %d" (age.Print()) count)


printfn "\nGroup students by age where age > 10."
query {
for student in db.Student do
groupBy student.Age into g
where (g.Key.HasValue && g.Key.Value > 10)
select (g, g.Key)
}
|> Seq.iter (fun (students, age) ->
printfn "Age: %s" (age.Value.ToString())
students
|> Seq.iter (fun student -> printfn "%s" student.Name))

printfn "\nGroup students by age and print counts of number of students at each age with more than 1 student."
query {
for student in db.Student do
groupBy student.Age into group
where (group.Count() > 1)
select (group.Key, group.Count())
}
|> Seq.iter (fun (age, ageCount) ->
printfn "Age: %s Count: %d" (age.Print()) ageCount)

printfn "\nGroup students by age and sum ages."
query {
for student in db.Student do
groupBy student.Age into g        
let total = query { for student in g do sumByNullable student.Age }
select (g.Key, g.Count(), total)
}
|> Seq.iter (fun (age, count, total) ->
printfn "Age: %d" (age.GetValueOrDefault())
printfn "Count: %d" count
printfn "Total years: %s" (total.ToString()))

printfn "\nGroup students by age and count number of students at each age, and display all with count > 1 in descending order of count."
query {
for student in db.Student do
groupBy student.Age into g
where (g.Count() > 1)        
sortByDescending (g.Count())
select (g.Key, g.Count())
}
|> Seq.iter (fun (age, myCount) ->
printfn "Age: %s" (age.Print())
printfn "Count: %d" myCount)

printfn "\n Select students from a set of IDs"
let idList = [1; 2; 5; 10]
let idQuery = query { for id in idList do
select id }
query {
for student in db.Student do
where (idQuery.Contains(student.StudentID))
select student
}
|> Seq.iter (fun student ->
printfn "Name: %s" student.Name)

printfn "\nLook for students with Name match _e%% pattern and take first two."
query {
for student in db.Student do
where (SqlMethods.Like( student.Name, "_e%") )
select student
take 2   
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\nLook for students with Name matching [abc]%% pattern."
query {
for student in db.Student do
where (SqlMethods.Like( student.Name, "[abc]%") )
select student  
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\nLook for students with name matching [^abc]%% pattern."
query {
for student in db.Student do
where (SqlMethods.Like( student.Name, "[^abc]%") )
select student  
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\nLook for students with name matching [^abc]%% pattern and select ID."
query {
for n in db.Student do
where (SqlMethods.Like( n.Name, "[^abc]%") )
select n.StudentID    
}
|> Seq.iter (fun id -> printfn "%d" id)

printfn "\n Using Contains as a query filter."
query {
for student in db.Student do
where (student.Name.Contains("a"))
select student
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\nSearching for names from a list."
let names = [|"a";"b";"c"|]
query {
for student in db.Student do
if names.Contains (student.Name) then select student }
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\nJoin Student and CourseSelection tables."
query {
for student in db.Student do 
join (for selection in db.CourseSelection ->
student.StudentID = selection.StudentID)
select (student, selection)
}
|> Seq.iter (fun (student, selection) -> printfn "%d %s %d" student.StudentID student.Name selection.CourseID)


printfn "\nLeft Join Student and CourseSelection tables."
query {
for student in db.Student do
leftOuterJoin (for selection in db.CourseSelection ->
student.StudentID = selection.StudentID) into result
for selection in result.DefaultIfEmpty() do
select (student, selection)
}
|> Seq.iter (fun (student, selection) ->
let selectionID, studentID, courseID =
match selection with
| null -> "NULL", "NULL", "NULL"
| sel -> (sel.ID.ToString(), sel.StudentID.ToString(), sel.CourseID.ToString())
printfn "%d %s %d %s %s %s" student.StudentID student.Name (student.Age.GetValueOrDefault()) selectionID studentID courseID)


printfn "\nJoin with count"
query {
for n in db.Student do 
join (for e in db.CourseSelection -> n.StudentID = e.StudentID)
count        
}
|>  printfn "%d"

printfn "\n Join with distinct."
query {
for student in db.Student do 
join (for selection in db.CourseSelection ->
student.StudentID = selection.StudentID)
distinct        
}
|> Seq.iter (fun (student, selection) -> printfn "%s %d" student.Name selection.CourseID)

printfn "\n Join with distinct and count."
query {
for n in db.Student do 
join (for e in db.CourseSelection -> n.StudentID = e.StudentID)
distinct
count       
}
|> printfn "%d"


printfn "\n Selecting students with age between 10 and 15."
query {
for student in db.Student do
where (student.Age.Value >= 10 && student.Age.Value < 15)
select student
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\n Selecting students with age either 11 or 12."
query {
for student in db.Student do
where (student.Age.Value = 11 || student.Age.Value = 12)
select student
}
|> Seq.iter (fun student -> printfn "%s" student.Name)

printfn "\n Selecting students in a certain age range and sorting."
query {
for n in db.Student do
where (n.Age.Value = 12 || n.Age.Value = 13)
sortByNullableDescending n.Age
select n
}
|> Seq.iter (fun student -> printfn "%s %s" student.Name (student.Age.Print()))

printfn "\n Selecting students with certain ages, taking account of possibility of nulls."
query {
for student in db.Student do
where ((student.Age.HasValue && student.Age.Value = 11) ||
(student.Age.HasValue && student.Age.Value = 12))
sortByDescending student.Name 
select student.Name
take 2
}
|> Seq.iter (fun name -> printfn "%s" name)

printfn "\n Union of two queries."
module Queries =
let query1 = query {
for n in db.Student do
select (n.Name, n.Age)
}

let query2 = query {
for n in db.LastStudent do
select (n.Name, n.Age)
}

query2.Union (query1)
|> Seq.iter (fun (name, age) -> printfn "%s %s" name (age.Print()))

printfn "\n Intersect of two queries."
module Queries2 =
let query1 = query {
for n in db.Student do
select (n.Name, n.Age)
}

let query2 = query {
for n in db.LastStudent do
select (n.Name, n.Age)
}

query1.Intersect(query2)
|> Seq.iter (fun (name, age) -> printfn "%s %s" name (age.Print()))

printfn "\n Using if statement to alter results for special value."
query {
for student in db.Student do
select (if student.Age.HasValue && student.Age.Value = -1 then
(student.StudentID, System.Nullable<int>(100), student.Age)
else (student.StudentID, student.Age, student.Age))
}
|> Seq.iter (fun (id, value, age) -> printfn "%d %s %s" id (value.Print()) (age.Print()))

printfn "\n Using if statement to alter results special values."
query {
for student in db.Student do
select (if student.Age.HasValue && student.Age.Value = -1 then
(student.StudentID, System.Nullable<int>(100), student.Age)
elif student.Age.HasValue && student.Age.Value = 0 then
(student.StudentID, System.Nullable<int>(100), student.Age)
else (student.StudentID, student.Age, student.Age))
}
|> Seq.iter (fun (id, value, age) -> printfn "%d %s %s" id (value.Print()) (age.Print()))

printfn "\n Multiple table select."
query {
for student in db.Student do
for course in db.Course do
select (student, course)
}
|> Seq.iteri (fun index (student, course) ->
if (index = 0) then printfn "StudentID Name Age CourseID CourseName"
printfn "%d %s %s %d %s" student.StudentID student.Name (student.Age.Print()) course.CourseID course.CourseName)

printfn "\nMultiple Joins"
query {
for student in db.Student do
join courseSelection in db.CourseSelection on
(student.StudentID = courseSelection.StudentID)
join course in db.Course on
(courseSelection.CourseID = course.CourseID)
select (student.Name, course.CourseName)
}










|> Seq.iter (fun (studentName, courseName) -> printfn "%s %s" studentName courseName)

printfn "\nMultiple Left Outer Joins"
query {
for student in db.Student do
leftOuterJoin (for courseSelection in db.CourseSelection ->
student.StudentID = courseSelection.StudentID) into g1
for courseSelection in g1.DefaultIfEmpty() do
leftOuterJoin (for course in db.Course ->
courseSelection.CourseID = course.CourseID) into g2
for course in g2.DefaultIfEmpty() do
select (student.Name, course.CourseName)
}
|> Seq.iter (fun (studentName, courseName) -> printfn "%s %s" studentName courseName)
```
And here is the full output when this code is run in F# Interactive.

**--&gt; Referenced 'C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\3.0\Runtime\v4.0\Type Providers\FSharp.Data.TypeProviders.dll'--&gt; Referenced 'C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.dll'--&gt; Referenced 'C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.Linq.dll'contains query operatorBinding session to 'C:\Users\ghogen\AppData\Local\Temp\tmp5E3C.dll'...Binding session to 'C:\Users\ghogen\AppData\Local\Temp\tmp611A.dll'...Is at least one student age 11? truecount query operatorNumber of students: 8last query operator.Last number: 21lastOrDefault query operator.lastOrDefault: 21exactlyOne query operator.Student with StudentID = 1 is Abercrombie, KimexactlyOneOrDefault query operator.Student with StudentID = 1 is Abercrombie, KimheadOrDefault query operator.head student is Abercrombie, Kimselect query operator.StudentID, Name: 1 Abercrombie, KimStudentID, Name: 2 Abolrous, HazenStudentID, Name: 3 Hance, JimStudentID, Name: 4 Adams, TerryStudentID, Name: 5 Hansen, ClausStudentID, Name: 6 Penor, LoriStudentID, Name: 7 Perham, TomStudentID, Name: 8 Peng, Yun-Fengwhere query operator.StudentID, Name: 5 Hansen, ClausStudentID, Name: 6 Penor, LoriStudentID, Name: 7 Perham, TomStudentID, Name: 8 Peng, Yun-FengminBy query operator.maxBy query operator.groupBy query operator.Age: NULL Count at that age: 1Age: 10 Count at that age: 1Age: 11 Count at that age: 1Age: 12 Count at that age: 3Age: 13 Count at that age: 1Age: 14 Count at that age: 1sortBy query operator.StudentID, Name: 1 Abercrombie, KimStudentID, Name: 2 Abolrous, HazenStudentID, Name: 4 Adams, TerryStudentID, Name: 3 Hance, JimStudentID, Name: 5 Hansen, ClausStudentID, Name: 8 Peng, Yun-FengStudentID, Name: 6 Penor, LoriStudentID, Name: 7 Perham, TomsortByDescending query operator.StudentID, Name: 7 Perham, TomStudentID, Name: 6 Penor, LoriStudentID, Name: 8 Peng, Yun-FengStudentID, Name: 5 Hansen, ClausStudentID, Name: 3 Hance, JimStudentID, Name: 4 Adams, TerryStudentID, Name: 2 Abolrous, HazenStudentID, Name: 1 Abercrombie, KimthenBy query operator.StudentID, Name: 10 Abercrombie, KimStudentID, Name: 11 Hansen, ClausStudentID, Name: 12 Adams, TerryStudentID, Name: 12 Hance, JimStudentID, Name: 12 Perham, TomStudentID, Name: 13 Penor, LoriStudentID, Name: 14 Abolrous, HazenthenByDescending query operator.StudentID, Name: 10 Abercrombie, KimStudentID, Name: 11 Hansen, ClausStudentID, Name: 12 Perham, TomStudentID, Name: 12 Hance, JimStudentID, Name: 12 Adams, TerryStudentID, Name: 13 Penor, LoriStudentID, Name: 14 Abolrous, HazengroupValBy query operator.Age: NULL Count at that age: 1Name: Peng, Yun-FengAge: 10 Count at that age: 1Name: Abercrombie, KimAge: 11 Count at that age: 1Name: Hansen, ClausAge: 12 Count at that age: 3Name: Hance, JimName: Adams, TerryName: Perham, TomAge: 13 Count at that age: 1Name: Penor, LoriAge: 14 Count at that age: 1Name: Abolrous, HazensumByNullable query operatorSum of ages: 84minByNullableMinimum age: 10maxByNullableMaximum age: 14averageByAverage student ID: 4.500000averageByNullableAverage age: 12find query operatorFound a match with StudentID = 1all query operatorDo all students have a comma in the name? truehead query operatorFound the head student with StudentID = 1nth query operatorThird number is 11skip query operatorStudentID = 2StudentID = 3StudentID = 4StudentID = 5StudentID = 6StudentID = 7StudentID = 8skipWhile query operatorNumber = 5Number = 7Number = 11Number = 18Number = 21sumBy query operatorSum of student IDs: 36take query operatorStudentID = 1StudentID = 2takeWhile query operatorNumber = 1Number = 5Number = 7sortByNullable query operatorStudentID, Name, Age: 8 Peng, Yun-Feng NULLStudentID, Name, Age: 1 Abercrombie, Kim 10StudentID, Name, Age: 5 Hansen, Claus 11StudentID, Name, Age: 7 Perham, Tom 12StudentID, Name, Age: 3 Hance, Jim 12StudentID, Name, Age: 4 Adams, Terry 12StudentID, Name, Age: 6 Penor, Lori 13StudentID, Name, Age: 2 Abolrous, Hazen 14sortByNullableDescending query operatorStudentID, Name, Age: 2 Abolrous, Hazen 14StudentID, Name, Age: 6 Penor, Lori 13StudentID, Name, Age: 7 Perham, Tom 12StudentID, Name, Age: 3 Hance, Jim 12StudentID, Name, Age: 4 Adams, Terry 12StudentID, Name, Age: 5 Hansen, Claus 11StudentID, Name, Age: 1 Abercrombie, Kim 10StudentID, Name, Age: 8 Peng, Yun-Feng NULLthenByNullable query operatorStudentID, Name, Age: 1 Abercrombie, Kim 10StudentID, Name, Age: 2 Abolrous, Hazen 14StudentID, Name, Age: 4 Adams, Terry 12StudentID, Name, Age: 3 Hance, Jim 12StudentID, Name, Age: 5 Hansen, Claus 11StudentID, Name, Age: 8 Peng, Yun-Feng NULLStudentID, Name, Age: 6 Penor, Lori 13StudentID, Name, Age: 7 Perham, Tom 12thenByNullableDescending query operatorStudentID, Name, Age: 1 Abercrombie, Kim 10StudentID, Name, Age: 2 Abolrous, Hazen 14StudentID, Name, Age: 4 Adams, Terry 12StudentID, Name, Age: 3 Hance, Jim 12StudentID, Name, Age: 5 Hansen, Claus 11StudentID, Name, Age: 8 Peng, Yun-Feng NULLStudentID, Name, Age: 6 Penor, Lori 13StudentID, Name, Age: 7 Perham, Tom 12All students: Abercrombie, Kim 1 10Abolrous, Hazen 2 14Hance, Jim 3 12Adams, Terry 4 12Hansen, Claus 5 11Penor, Lori 6 13Perham, Tom 7 12Peng, Yun-Feng 8 NULLCount of students: Student count: 8Exists."Abercrombie, Kim""Abolrous, Hazen""Hance, Jim""Adams, Terry""Hansen, Claus""Perham, Tom"Group by age and countNULL 110 111 112 313 114 1Group value by age.NULL 110 111 112 313 114 1Group students by age where age &gt; 10.Age: 11Hansen, ClausAge: 12Hance, JimAdams, TerryPerham, TomAge: 13Penor, LoriAge: 14Abolrous, HazenGroup students by age and print counts of number of students at each age with more than 1 student.Age: 12 Count: 3Group students by age and sum ages.Age: 0Count: 1Total years: Age: 10Count: 1Total years: 10Age: 11Count: 1Total years: 11Age: 12Count: 3Total years: 36Age: 13Count: 1Total years: 13Age: 14Count: 1Total years: 14Group students by age and count number of students at each age, and display all with count &gt; 1 in descending order of count.Age: 12Count: 3Select students from a set of IDsName: Abercrombie, KimName: Abolrous, HazenName: Hansen, ClausLook for students with Name match _e% pattern and take first two.Penor, LoriPerham, TomLook for students with Name matching [abc]% pattern.Abercrombie, KimAbolrous, HazenAdams, TerryLook for students with name matching [^abc]% pattern.Hance, JimHansen, ClausPenor, LoriPerham, TomPeng, Yun-FengLook for students with name matching [^abc]% pattern and select ID.35678Using Contains as a query filter.Abercrombie, KimAbolrous, HazenHance, JimAdams, TerryHansen, ClausPerham, TomSearching for names from a list.Join Student and CourseSelection tables.2 Abolrous, Hazen 23 Hance, Jim 35 Hansen, Claus 52 Abolrous, Hazen 25 Hansen, Claus 56 Penor, Lori 63 Hance, Jim 32 Abolrous, Hazen 21 Abercrombie, Kim 12 Abolrous, Hazen 25 Hansen, Claus 52 Abolrous, Hazen 23 Hance, Jim 32 Abolrous, Hazen 23 Hance, Jim 3Left Join Student and CourseSelection tables.1 Abercrombie, Kim 10 9 3 12 Abolrous, Hazen 14 1 1 22 Abolrous, Hazen 14 4 2 22 Abolrous, Hazen 14 8 3 22 Abolrous, Hazen 14 10 4 22 Abolrous, Hazen 14 12 4 22 Abolrous, Hazen 14 14 5 23 Hance, Jim 12 2 1 33 Hance, Jim 12 7 2 33 Hance, Jim 12 13 5 33 Hance, Jim 12 15 7 34 Adams, Terry 12 NULL NULL NULL5 Hansen, Claus 11 3 1 55 Hansen, Claus 11 5 2 55 Hansen, Claus 11 11 4 56 Penor, Lori 13 6 2 67 Perham, Tom 12 NULL NULL NULL8 Peng, Yun-Feng 0 NULL NULL NULLJoin with count15Join with distinct.Abercrombie, Kim 2Abercrombie, Kim 3Abercrombie, Kim 5Abolrous, Hazen 2Abolrous, Hazen 5Abolrous, Hazen 6Abolrous, Hazen 3Hance, Jim 2Hance, Jim 1Adams, Terry 2Adams, Terry 5Adams, Terry 2Hansen, Claus 3Hansen, Claus 2Perham, Tom 3Join with distinct and count.15Selecting students with age between 10 and 15.Abercrombie, KimAbolrous, HazenHance, JimAdams, TerryHansen, ClausPenor, LoriPerham, TomSelecting students with age either 11 or 12.Hance, JimAdams, TerryHansen, ClausPerham, TomSelecting students in a certain age range and sorting.Penor, Lori 13Perham, Tom 12Hance, Jim 12Adams, Terry 12Selecting students with certain ages, taking account of possibility of nulls.Hance, JimAdams, TerryUnion of two queries.Abercrombie, Kim 10Abolrous, Hazen 14Hance, Jim 12Adams, Terry 12Hansen, Claus 11Penor, Lori 13Perham, Tom 12Peng, Yun-Feng NULLIntersect of two queries.Using if statement to alter results for special value.1 10 102 14 143 12 124 12 125 11 116 13 137 12 128 NULL NULLUsing if statement to alter results special values.1 10 102 14 143 12 124 12 125 11 116 13 137 12 128 NULL NULLMultiple table select.StudentID Name Age CourseID CourseName1 Abercrombie, Kim 10 1 Algebra I2 Abolrous, Hazen 14 1 Algebra I3 Hance, Jim 12 1 Algebra I4 Adams, Terry 12 1 Algebra I5 Hansen, Claus 11 1 Algebra I6 Penor, Lori 13 1 Algebra I7 Perham, Tom 12 1 Algebra I8 Peng, Yun-Feng NULL 1 Algebra I1 Abercrombie, Kim 10 2 Trigonometry2 Abolrous, Hazen 14 2 Trigonometry3 Hance, Jim 12 2 Trigonometry4 Adams, Terry 12 2 Trigonometry5 Hansen, Claus 11 2 Trigonometry6 Penor, Lori 13 2 Trigonometry7 Perham, Tom 12 2 Trigonometry8 Peng, Yun-Feng NULL 2 Trigonometry1 Abercrombie, Kim 10 3 Algebra II2 Abolrous, Hazen 14 3 Algebra II3 Hance, Jim 12 3 Algebra II4 Adams, Terry 12 3 Algebra II5 Hansen, Claus 11 3 Algebra II6 Penor, Lori 13 3 Algebra II7 Perham, Tom 12 3 Algebra II8 Peng, Yun-Feng NULL 3 Algebra II1 Abercrombie, Kim 10 4 History2 Abolrous, Hazen 14 4 History3 Hance, Jim 12 4 History4 Adams, Terry 12 4 History5 Hansen, Claus 11 4 History6 Penor, Lori 13 4 History7 Perham, Tom 12 4 History8 Peng, Yun-Feng NULL 4 History1 Abercrombie, Kim 10 5 English2 Abolrous, Hazen 14 5 English3 Hance, Jim 12 5 English4 Adams, Terry 12 5 English5 Hansen, Claus 11 5 English6 Penor, Lori 13 5 English7 Perham, Tom 12 5 English8 Peng, Yun-Feng NULL 5 English1 Abercrombie, Kim 10 6 French2 Abolrous, Hazen 14 6 French3 Hance, Jim 12 6 French4 Adams, Terry 12 6 French5 Hansen, Claus 11 6 French6 Penor, Lori 13 6 French7 Perham, Tom 12 6 French8 Peng, Yun-Feng NULL 6 French1 Abercrombie, Kim 10 7 Chinese2 Abolrous, Hazen 14 7 Chinese3 Hance, Jim 12 7 Chinese4 Adams, Terry 12 7 Chinese5 Hansen, Claus 11 7 Chinese6 Penor, Lori 13 7 Chinese7 Perham, Tom 12 7 Chinese8 Peng, Yun-Feng NULL 7 ChineseMultiple JoinsAbercrombie, Kim TrigonometryAbercrombie, Kim Algebra IIAbercrombie, Kim EnglishAbolrous, Hazen TrigonometryAbolrous, Hazen EnglishAbolrous, Hazen FrenchAbolrous, Hazen Algebra IIHance, Jim TrigonometryHance, Jim Algebra IAdams, Terry TrigonometryAdams, Terry EnglishAdams, Terry TrigonometryHansen, Claus Algebra IIHansen, Claus TrigonometryPerham, Tom Algebra IIMultiple Left Outer JoinsAbercrombie, Kim TrigonometryAbercrombie, Kim Algebra IIAbercrombie, Kim EnglishAbolrous, Hazen TrigonometryAbolrous, Hazen EnglishAbolrous, Hazen FrenchAbolrous, Hazen Algebra IIHance, Jim TrigonometryHance, Jim Algebra IAdams, Terry TrigonometryAdams, Terry EnglishAdams, Terry TrigonometryHansen, Claus Algebra IIHansen, Claus TrigonometryPenor, Lori Perham, Tom Algebra IIPeng, Yun-Feng type schemaval db : schema.ServiceTypes.SimpleDataContextTypes.MyDatabase1val student : System.Data.Linq.Table&lt;schema.ServiceTypes.Student&gt;val data : int list = [1; 5; 7; 11; 18; 21]type Nullable&lt;'T                when 'T : (new : unit -&gt;  'T) and 'T : struct and                     'T :&gt; System.ValueType&gt; with  member Print : unit -&gt; stringval num : int = 21val student2 : schema.ServiceTypes.Studentval student3 : schema.ServiceTypes.Studentval student4 : schema.ServiceTypes.Studentval student5 : int = 1val student6 : int = 8val idList : int list = [1; 2; 5; 10]val idQuery : seq&lt;int&gt;val names : string [] = [|"a"; "b"; "c"|]module Queries = begin  val query1 : System.Linq.IQueryable&lt;string &#42; System.Nullable&lt;int&gt;&gt;  val query2 : System.Linq.IQueryable&lt;string &#42; System.Nullable&lt;int&gt;&gt;endmodule Queries2 = begin  val query1 : System.Linq.IQueryable&lt;string &#42; System.Nullable&lt;int&gt;&gt;  val query2 : System.Linq.IQueryable&lt;string &#42; System.Nullable&lt;int&gt;&gt;end**
## See Also
[F&#35; Language Reference](F%23+Language+Reference.md)

[Linq.QueryBuilder Class &#40;F&#35;&#41;](Linq.QueryBuilder+Class+%28F%23%29.md)

[Computation Expressions &#40;F&#35;&#41;](Computation+Expressions+%28F%23%29.md)

