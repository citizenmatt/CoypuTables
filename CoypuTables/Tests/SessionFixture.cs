using System;
using System.Diagnostics;
using System.IO;

using Coypu;

namespace CoypuTables.Tests
{
    public class SessionFixture : IDisposable
    {
        public SessionFixture()
        {
            var stopwatch = Stopwatch.StartNew();
            Session = CoypuHelper.GetNewWatinSession();
            Console.WriteLine("Starting session: {0}", stopwatch.Elapsed);
        }

        public Session Session { get; private set; }

        public void VisitFile(string htmlPath)
        {
            var stopwatch = Stopwatch.StartNew();
            var uri = new Uri(new FileInfo(htmlPath).FullName);
            Session.Visit(uri.AbsoluteUri);
            Console.WriteLine("Visiting page: {0}", stopwatch.Elapsed);
        }

        public void Dispose()
        {
            var stopwatch = Stopwatch.StartNew();
            Session.Dispose();
            Console.WriteLine("Disposing session: {0}", stopwatch.Elapsed);
        }
    }
}