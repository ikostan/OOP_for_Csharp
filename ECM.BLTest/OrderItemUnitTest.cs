using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class OrderItemUnitTest
    {
        [TestMethod]
        public void OrderItemIdTest()
        {
            //Arrange
            int id = 1;
            OrderItem oi = new OrderItem(1);

            //Act

            //Assert
            Assert.AreEqual(id, oi.OrderItemId);
        }
    }
}
