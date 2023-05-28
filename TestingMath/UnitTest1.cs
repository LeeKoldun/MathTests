using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System;

namespace TestingMath
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual( 10, Geometry.RectangelArea(5, 2) );
        }
    }
}
