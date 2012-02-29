using System.Linq;

using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table_body : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_retrieve_body_as_element_scope()
        {
            var table = session.FindId("table_with_summary").AsTable();
            var body = table.Body;

            Assert.IsAssignableFrom<TableRowGroupElementScope>(body);
            Assert.Equal(1, body.Rows.Count());
            Assert.Equal(1, body.Rows.First().Cells.Count());
        }

        [Fact]
        [Timed]
        public void Should_retrieve_body_when_tbody_is_missing_in_markup()
        {
            var table = session.FindId("table_with_implied_tbody").AsTable();
            var body = table.Body;
            var rows = body.Rows.ToList();
            var cells = rows[0].Cells.ToList();

            Assert.IsAssignableFrom<TableRowGroupElementScope>(body);
            Assert.Equal(1, rows.Count);
            Assert.Equal(1, cells.Count);
            Assert.Equal("Cell content", cells[0].Text);
        }
    }
}