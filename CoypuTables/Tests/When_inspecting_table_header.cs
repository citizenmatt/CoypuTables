using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table_header : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_not_find_header_element_if_not_exists()
        {
            var table = session.FindId("empty_table").AsTable();
            var header = table.Header;

            Assert.NotNull(header);
            Assert.True(header.Missing());
        }

        [Fact]
        [Timed]
        public void Should_retrieve_header_as_element_scope()
        {
            var table = session.FindId("table_with_header_and_footer").AsTable();
            var header = table.Header;

            Assert.IsAssignableFrom<TableRowGroupElementScope>(header);
            Assert.True(header.Exists());
            Assert.Equal("this is the header", header["title"]);
        } 
    }
}