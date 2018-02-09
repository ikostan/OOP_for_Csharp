using System;
using ACME.BL.OrderClassess;
using ACME.BL.RepositoryClassess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryUnitTest
    {
        [TestMethod]
        public void RetreiveExistingTest()
        {
            //Arrange
            OrderRepository or = new OrderRepository();
            int orderId = 10;

            //Act
            var actual = or.Retrieve(orderId);

            Order expected = new Order(orderId)
            {
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
