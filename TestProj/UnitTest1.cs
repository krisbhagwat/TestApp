using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTestApp.Utilities;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Register reg = new Register();
            bool bResult = reg.RegisterUser();
            Assert.IsTrue(bResult);
        }
    }
}
