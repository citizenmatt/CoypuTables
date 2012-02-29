using System.Linq;

using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table_row_group : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_retrieve_header_row_if_first_row_of_footer_contains_th()
        {
            var table = session.FindId("table_with_th_for_header_and_footer").AsTable();
            var th = table.Footer.HeaderRow;

            Assert.IsAssignableFrom<TableRowElementScope>(th);
            Assert.True(th.Exists());
            Assert.Equal("tr as header row in tfoot", th["title"]);
        }

        [Fact]
        [Timed]
        public void Should_not_retrieve_header_row_if_first_row_of_footer_does_not_contain_th()
        {
            var table = session.FindId("table_with_header_and_footer").AsTable();
            var th = table.Footer.HeaderRow;

            Assert.IsAssignableFrom<TableRowElementScope>(th);
            Assert.True(th.Missing());
        }

        [Fact]
        [Timed]
        public void Should_retrieve_all_rows_as_element_scope()
        {
            var table = session.FindId("table_with_header_and_footer").AsTable();
            var rows = table.Footer.Rows.ToList();

            Assert.Equal(3, rows.Count);
            Assert.IsAssignableFrom<TableRowElementScope>(rows[0]);
            Assert.Equal("this is row 2", rows[1]["title"]);
        }

        [Fact]
        [Timed]
        public void Should_not_include_header_row_if_it_exists()
        {
            var table = session.FindId("table_with_th_for_header_and_footer").AsTable();
            var rows = table.Footer.Rows.ToList();

            Assert.Equal(2, rows.Count);
        } 
    }
}