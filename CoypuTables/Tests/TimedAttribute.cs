using System;
using System.Diagnostics;

using Xunit;

namespace CoypuTables.Tests
{
    public class TimedAttribute : BeforeAfterTestAttribute
    {
        private Stopwatch stopwatch;

        public override void Before(System.Reflection.MethodInfo methodUnderTest)
        {
            stopwatch = Stopwatch.StartNew();
        }

        public override void After(System.Reflection.MethodInfo methodUnderTest)
        {
            Console.WriteLine("Test took: {0}", stopwatch.Elapsed);
        }
    }
}