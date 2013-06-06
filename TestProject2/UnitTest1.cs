using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod3()
        {
             
            TestContext.WriteLine("[TEST NUMBER 1]");
            TestContext.WriteLine("[TestMethod1]this is line number 1");
            TestContext.WriteLine("[TestMethod1]this is line number 2");
            TestContext.WriteLine("[TestMethod1]this is line number 3");
            TestContext.WriteLine("[TestMethod1]this is line number 4");
            TestContext.WriteLine("[TestMethod1]this is line number 5");
            TestContext.WriteLine("[TestMethod1]this is line number 6");
            TestContext.WriteLine("[TestMethod1]this is line number 7");
            TestContext.WriteLine("[TestMethod1]this is line number 8");
            TestContext.WriteLine("[TestMethod1]this is line number 9");
            TestContext.WriteLine("[TestMethod1]this is line number 10");
            TestContext.WriteLine("[TestMethod1]this is line number 11");
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestContext.WriteLine("[TEST NUMBER 2]");
            TestContext.WriteLine("[TestMethod2]this is line number 1");
            TestContext.WriteLine("[TestMethod2]this is line number 2");
            TestContext.WriteLine("[TestMethod2]this is line number 3");
            TestContext.WriteLine("[TestMethod2]this is line number 4");
            TestContext.WriteLine("[TestMethod2]this is line number 5");
            TestContext.WriteLine("[TestMethod2]this is line number 6");
            TestContext.WriteLine("[TestMethod2]this is line number 7");
            TestContext.WriteLine("[TestMethod2]this is line number 8");
            TestContext.WriteLine("[TestMethod2]this is line number 9");
            TestContext.WriteLine("[TestMethod2]this is line number 10");
            TestContext.WriteLine("[TestMethod2]this is line number 11");
        }
    }
}
