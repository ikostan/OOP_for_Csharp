using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
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
