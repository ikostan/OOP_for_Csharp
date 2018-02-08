using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerRepositoryUnitTest
    {
        [TestMethod]
        public void RetreiveExistingTest()
        {
            //Arrange
            CustomerRepository cr = new CustomerRepository();
            int id = 1;

            //Act
            Customer actual = cr.Retreive(id);
            Customer expected = new Customer(id)
            {
                Email = "email@mail.com",
                FirstName = "John",
                LastName = "Doe",
            };

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(id, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
