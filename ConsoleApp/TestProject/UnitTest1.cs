using System.IO;
using System;


namespace TestProject
{
        [TestClass]
        public class UnitTest1
        {
            private const string Expected = "Hello, World! from Masihullah";
            [TestMethod]
            public void TestMethod1()
            {
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    ConsoleApp.Program.Main();

                    var result = sw.ToString().Trim();
                    Assert.AreEqual(Expected, result);
                }
            }
        }
    }