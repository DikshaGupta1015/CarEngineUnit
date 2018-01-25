using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarEngine
{
    [TestClass]
    public class CarEngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car c = new Car();
            bool res = c.Drive();
            Assert.AreEqual(true, res);
        }
    }
}
