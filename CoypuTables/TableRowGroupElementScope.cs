using System.Collections.Generic;
using System.Linq;

using Coypu;

namespace CoypuTables
{
    public class TableRowGroupElementScope : DelegatingElementScope
    {
        private const string HeaderRowXPath = "tr[1 and th]";

        public TableRowGroupElementScope(ElementScope innerElement)
            : base(innerElement)
        {
        }

        /// <summary>
        /// Returns the first row in the row group if the first row contains "th" elements
        /// </summary>
        /// <remarks>
        /// <para>
        /// Returns an instance of <see cref="TableRowElementScope"/> that will
        /// resolve to the first row in the row group if it contains "th" elements.
        /// If it doesn't contain "th" elements, it will resolve to nothing. (I.e.
        /// <see cref="ElementScope.Exists"/> will return false.
        /// </para>
        /// <para>
        /// The "th" element is allowed anywhere the "td" element is. If you use
        /// the "th" element anywhere other than the first row of the rowgroup,
        /// you can 1) use <see cref="TableRowGroupElementScope.FindXPath"/>
        /// and create your own instances of <see cref="TableRowElementScope"/>
        /// or 2) DON'T DO THAT.
        /// </para>
        /// </remarks> 
        public TableRowElementScope HeaderRow
        {
            get { return new TableRowElementScope(FindXPath(HeaderRowXPath)); }
        }

        /// <summary>
        /// Returns an enumerable of the rows, exluding the header row if appropriate.
        /// </summary>
        public IEnumerable<TableRowElementScope> Rows
        {
            get { return GetRows().TakeWhile(scope => scope.Exists()); }
        }

        private IEnumerable<TableRowElementScope> GetRows()
        {
            var index = 1;

            if (HasXPath(HeaderRowXPath))
                index++;

            do
            {
                yield return new TableRowElementScope(FindXPath("tr[" + index++ + "]"));
            } while (index > 0);
        }
    }
}