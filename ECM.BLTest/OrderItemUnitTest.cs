using System;
using ACME.BL.OrderClassess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
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
