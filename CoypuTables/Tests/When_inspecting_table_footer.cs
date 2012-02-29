using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table_footer : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_not_find_footer_element_if_not_exists()
        {
            var table = session.FindId("empty_table").AsTable();
            var footer = table.Footer;

            Assert.NotNull(footer);
            Assert.True(footer.Missing());
        }

        [Fact]
        [Timed]
        public void Should_retrieve_footer_as_element_scope()
        {
            var table = session.FindId("table_with_header_and_footer").AsTable();
            var footer = table.Footer;

            Assert.IsAssignableFrom<TableRowGroupElementScope>(footer);
            Assert.True(footer.Exists());
            Assert.Equal("this is the footer", footer["title"]);
        }
    }
}