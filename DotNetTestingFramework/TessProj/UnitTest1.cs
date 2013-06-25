using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TessProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("This is test 1.");
        }

        [TestCategory("dasdasdas")]
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is test 2.");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("This is test 3.");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("This is test 4.");
        }
    }
}
