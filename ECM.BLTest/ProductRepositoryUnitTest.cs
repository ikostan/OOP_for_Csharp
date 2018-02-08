using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class ProductRepositoryUnitTest
    {
        [TestMethod]
        public void RetreiveExistingTest()
        {
            //Arrange
            ProductRepository pr = new ProductRepository();
            int id = 2;

            //Act
            Product expected = new Product(id)
            {
                ProductName = "Product",
                ProductDescription = "Description",
                CurrentPrice = 15.95M
            };

            Product actual = pr.Retrieve(id);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
