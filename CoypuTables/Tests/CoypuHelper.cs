using Coypu;
using Coypu.Drivers.Watin;

namespace CoypuTables.Tests
{
    public static class CoypuHelper
    {
        public static Session GetNewWatinSession()
        {
            Configuration.Driver = typeof(WatiNDriver);
            Configuration.Browser = Coypu.Drivers.Browser.InternetExplorer;

            return Browser.NewSession();
        }
    }
}