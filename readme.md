# CoypuTables

For the most part, Coypu makes it nicer to automate testing of a webpage in .net (see http://gihub.com/coypu/coypu). But tables are not so nice. Coypu currently doesn't have an API to deal with tables, so this is a quick sketchpad project to trial how that could look.

It's a first cut, but it's working, and I've tried to keep it simple. It's based on the currently unreleased chain-scopes branch of Coypu, rather than master (it relies on chaining the scope of find operations).

You call it like this:

  var table = session.FindId("table1").AsTable();

and table is a TableElementScope. You can now call all of the usual Find\* methods that you can on normal elements, but you've also got Header, Footer and Body properties, which return back a TableRowGroupElementScope, from which you can get a header row and an enumerable of rows. From the TableRowElementScope, you can get at an enumerable of ElementScope for the cells.

The table-specfic element scope objects work in the same way as ElementScope - they don't search for the element until you try to access it (e.g. calling .Exists, or .HasCss, .FillIn, etc). The Rows and Cells properties also return an enumerable, which again, isn't evaluated until you start enumerating it. At which point, each child element is evaluated for existence, and an ElementScope (i.e. a deferred element) is returned for each existing row/cell.

It's worth noting that this constant evaluation is most likely a performance issue that will need to be addressed.
