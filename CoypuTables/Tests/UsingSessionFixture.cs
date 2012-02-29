using Coypu;

using Xunit;

namespace CoypuTables.Tests
{
    public class UsingSessionFixture : IUseFixture<SessionFixture>
    {
        protected Session session;

        public void SetFixture(SessionFixture fixture)
        {
            session = fixture.Session;
            fixture.VisitFile(@"..\..\Tests\html\table.html");
        }
    }
}