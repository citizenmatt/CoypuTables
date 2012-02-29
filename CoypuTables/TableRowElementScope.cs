using System.Collections.Generic;
using System.Linq;

using Coypu;

namespace CoypuTables
{
    public class TableRowElementScope : DelegatingElementScope
    {
        public TableRowElementScope(ElementScope innerElement)
            : base(innerElement)
        {
        }

        public IEnumerable<ElementScope> Cells
        {
            get { return GetRows().TakeWhile(scope => scope.Exists()); }
        }

        private IEnumerable<ElementScope> GetRows()
        {
            var index = 1;

            do
            {
                yield return FindXPath("td[" + index++ + "]");
            } while (index > 0);
        }
    }
}