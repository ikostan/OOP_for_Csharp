using System;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void ValidateInvalidTest()
        {
            //Arrange
            Product p = new Product();

            //Act

            //Assert
            Assert.IsFalse(p.Validate());
        }

        [TestMethod]
        public void ValidateValidTest()
        {
            //Arrange
            Product p = new Product();

            //Act
            decimal price = 12.50M;
            string productName = "Product";
            p.ProductName = productName;
            p.CurrentPrice = price;

            //Assert
            Assert.IsTrue(p.Validate());
        }

        [TestMethod]
        public void CurrentPriceTest()
        {
            //Arrange
            Product p = new Product();

            //Act
            decimal price = 12.50M;
            p.CurrentPrice = price;

            //Assert
            Assert.AreEqual(price, p.CurrentPrice);
        }

        [TestMethod]
        public void ProductNameTest()
        {
            //Arrange
            Product p = new Product();

            //Act
            string productName = "Product";
            p.ProductName = productName;

            //Assert
            Assert.AreEqual(productName, p.ProductName);
        }
    }
}
