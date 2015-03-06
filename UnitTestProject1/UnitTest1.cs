using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCIJenkins;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestAjoutClasse test = new TestAjoutClasse();
            Assert.Equals(test.GetMessage(),"hello");
        }
    }
}
