using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gpayments;

namespace Tests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void TestGenerateToken()
        {
            FourGeeksPayments api = new FourGeeksPayments();
            Assert.IsNotNull(api);
        }

        public void TestMeInfo()
        {

        }
    }
}
