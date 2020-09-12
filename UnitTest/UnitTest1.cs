using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class ConsoleAppUnitTest
    {
        private const string Expected = "Hello World!";
        
        [TestMethod]
        public void HelloWorldTest()
        {
            using var sw = new StringWriter(); // shortcut for using statement.
            Console.SetOut(sw);
            ConsoleApp.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}
