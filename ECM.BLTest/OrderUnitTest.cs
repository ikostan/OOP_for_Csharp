using System;
using ACME.BL;
using ACME.BL.OrderClassess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderUnitTest
    {
        [TestMethod]
        public void ValidateValidTest()
        {
            //Arrange
            Order o = new Order();

            //Act
            o.OrderDate = DateTimeOffset.Now;

            //Assert
            Assert.IsTrue(o.Validate());
        }

        [TestMethod]
        public void ValidateInvalidTest()
        {
            //Arrange
            Order o = new Order();

            //Act

            //Assert
            Assert.IsFalse(o.Validate());
        }
    }
}
