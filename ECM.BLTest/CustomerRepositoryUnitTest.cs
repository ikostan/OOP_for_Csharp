using System;
using ACM.BL;
using ACM.BL.AddressClassess;
using ACM.BL.CustomerClassess;
using ACM.BL.RepositoryClassess;
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
            Customer actual = cr.Retrieve(id);
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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepositorty = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "email@mail.com",
                FirstName = "John",
                LastName = "Doe",
                HomeAddress = new Address()
                        {
                            AddressType = AddressType.HOME,
                            StreetLine1 = "Bag End",
                            StreetLine2 = "Bagshot row",
                            City = "Hobbiton",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "144"
                        },

                WorkAddress = new Address()
                {
                            AddressType = AddressType.WORK,
                            StreetLine1 = "Green Dragon",
                            City = "Bywater",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "146"
                        
                }
            };


            //-- Act
            var actual = customerRepositorty.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            //Work
            Assert.AreEqual(expected.WorkAddress.AddressType, actual.WorkAddress.AddressType);
            Assert.AreEqual(expected.WorkAddress.StreetLine1, actual.WorkAddress.StreetLine1);
            Assert.AreEqual(expected.WorkAddress.City, actual.WorkAddress.City);
            Assert.AreEqual(expected.WorkAddress.State, actual.WorkAddress.State);
            Assert.AreEqual(expected.WorkAddress.Country, actual.WorkAddress.Country);
            Assert.AreEqual(expected.WorkAddress.PostalCode, actual.WorkAddress.PostalCode);

            //Home
            Assert.AreEqual(expected.HomeAddress.AddressType, actual.HomeAddress.AddressType);
            Assert.AreEqual(expected.HomeAddress.StreetLine1, actual.HomeAddress.StreetLine1);
            Assert.AreEqual(expected.HomeAddress.City, actual.HomeAddress.City);
            Assert.AreEqual(expected.HomeAddress.State, actual.HomeAddress.State);
            Assert.AreEqual(expected.HomeAddress.Country, actual.HomeAddress.Country);
            Assert.AreEqual(expected.HomeAddress.PostalCode, actual.HomeAddress.PostalCode);

        }

        //End of Class
    }
}
