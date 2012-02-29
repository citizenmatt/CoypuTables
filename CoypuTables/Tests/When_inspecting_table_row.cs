using System.Linq;

using Coypu;

using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table_row : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_retrieve_all_cells_as_element_scope()
        {
            var table = session.FindId("table_with_header_and_footer").AsTable();
            var row = table.Header.Rows.First();
            var cells = row.Cells.ToList();

            Assert.Equal(3, cells.Count);
            Assert.IsAssignableFrom<ElementScope>(cells[0]);
            Assert.Equal("This is the content in thead cell 1", cells[0].Text);
            Assert.True(cells[2].FindId("header_cell3_image").Exists());
        }
    }
}