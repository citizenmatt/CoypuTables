using System;

using Coypu;

using Xunit;

namespace CoypuTables.Tests
{
    public class When_inspecting_table : UsingSessionFixture
    {
        [Fact]
        [Timed]
        public void Should_return_table_element_scope()
        {
            var table = session.FindId("table_with_summary").AsTable();

            Assert.IsType<TableElementScope>(table);
        }

        // TODO: What if you call AsTable on a non-table element?
        // There's nothing in the Coypu API to discover that...

        [Fact]
        [Timed]
        public void Should_return_null_when_no_summary_attribute()
        {
            var table = session.FindId("empty_table").AsTable();
            var summary = table.Summary;

            Assert.Null(summary);
        }

        [Fact]
        [Timed]
        public void Should_get_summary_attribute()
        {
            var table = session.FindId("table_with_summary").AsTable();
            var summary = table.Summary;

            Assert.Equal("this is the summary", summary);
        }

        [Fact]
        [Timed]
        public void Should_not_find_caption_element_if_not_exists()
        {
            var table = session.FindId("empty_table").AsTable();
            var caption = table.Caption;

            Assert.True(caption.Missing());
        }

        [Fact]
        [Timed]
        public void Should_retrieve_caption_as_element_scope()
        {
            var table = session.FindId("table_with_caption").AsTable();
            var caption = table.Caption;

            Assert.IsAssignableFrom<ElementScope>(caption);
            Assert.True(caption.Exists());
            Assert.Equal("this is the caption", caption["title"]);
            Assert.True(caption.FindId("caption_image").Exists());
        }
    }
}