using Coypu;

namespace CoypuTables
{
    public class TableElementScope : DelegatingElementScope
    {
        public TableElementScope(ElementScope elementScope)
            : base(elementScope)
        {
        }

        public string Summary
        {
            get { return this["summary"]; }
        }

        public ElementScope Caption
        {
            get { return FindXPath("caption"); }
        }

        public TableRowGroupElementScope Body
        {
            get { return new TableRowGroupElementScope(FindXPath("tbody")); }
        }

        public TableRowGroupElementScope Footer
        {
            get { return new TableRowGroupElementScope(FindXPath("tfoot")); }
        }

        public TableRowGroupElementScope Header
        {
            get { return new TableRowGroupElementScope(FindXPath("thead")); }
        }
    }
}
