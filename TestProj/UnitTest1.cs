using System;
using NUnit.Framework;
using MyTestApp.Utilities;

namespace TestProj
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Register reg = new Register();
            bool bResult = reg.RegisterUser();
            Assert.IsTrue(bResult);
        }
    }
}
