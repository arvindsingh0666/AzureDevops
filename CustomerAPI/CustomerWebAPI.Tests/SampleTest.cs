using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerWebAPI.Tests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void ThisIsSuccessfulTest()
        {
        }

        [TestMethod]
        public void ThisIsfailedTest()
        {
            Assert.AreEqual(1,1);
        }
    }
}
