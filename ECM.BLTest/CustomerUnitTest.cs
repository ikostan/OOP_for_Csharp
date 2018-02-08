using System;
using ACM.BL;
using ACM.BL.AddressClassess;
using ACM.BL.CustomerClassess;
using ACM.BL.HelperClassess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        /// <summary>
        /// Email validation test - valid value
        /// </summary>
        [TestMethod]
        public void EmailValidTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string email = " mAil@maiL.coM ";
            string expected = "mail@mail.com";
            c.Email = email;

            //Assert
            Assert.AreEqual(expected, c.Email);
        }

        /// <summary>
        /// Email validation test - invalid value
        /// </summary>
        [TestMethod]
        public void EmailInvalidTest()
        {
            //Arrange
            Customer c = new Customer();
            string error = null;

            //Act
            try
            {
                string email1 = " mAil maiL.coM ";
                c.Email = email1;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.IsNull(c.Email);
            Assert.AreEqual(error, ErrorMessages.InvalidEmail);

            //Act
            try
            {
                string email2 = " mAil@maiL coM ";
                c.Email = email2;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.IsNull(c.Email);
            Assert.AreEqual(error, ErrorMessages.InvalidEmail);
        }

        /// <summary>
        /// Test static counter
        /// </summary>
        [TestMethod]
        public void InstanceCountTest()
        {
            //Arrange
            int start = Customer.InstanceCount;
            Customer c1 = new Customer();
            Customer c2 = new Customer();

            //Act

            //Assert
            Assert.AreEqual(start + 2, Customer.InstanceCount);

            //Arrange
            Customer c3 = new Customer();

            //Assert
            Assert.AreEqual(start + 3, Customer.InstanceCount);
        }

        /// <summary>
        /// Test FirstName property
        /// </summary>
        [TestMethod]
        public void FirstNameTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "John";
            string name = "john";
            c.FirstName = name;

            //Assert
            Assert.AreEqual(expected, c.FirstName);

            //Act
            string expected2 = "Michael";
            string name2 = " Michael";
            c.FirstName = name2;

            //Assert
            Assert.AreEqual(expected2, c.FirstName);

            //Act
            string expected3 = "Sean";
            string name3 = " sEaN ";
            c.FirstName = name3;

            //Assert
            Assert.AreEqual(expected3, c.FirstName);
        }

        /// <summary>
        /// Test FirstName empty property
        /// </summary>
        [TestMethod]
        public void FirstNameEmptyTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = ErrorMessages.EmptyFirstName;
            string name = " ";
            string error = null;

            try
            {
                c.FirstName = name;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, error);
        }

        /// <summary>
        /// Test LastName property
        /// </summary>
        [TestMethod]
        public void LastNameTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "Doe";
            string name = " doe";
            c.LastName = name;

            //Assert
            Assert.AreEqual(expected, c.LastName);

            //Act
            string expected2 = "Smith";
            string name2 = "Smith ";
            c.LastName = name2;

            //Assert
            Assert.AreEqual(expected2, c.LastName);

            //Act
            string expected3 = "Conor";
            string name3 = " cOnOr ";
            c.LastName = name3;

            //Assert
            Assert.AreEqual(expected3, c.LastName);
        }

        /// <summary>
        /// Test LastName empty property
        /// </summary>
        [TestMethod]
        public void LastNameEmptyTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = ErrorMessages.EmptyLastName;
            string name = " ";
            string error = null;

            try
            {
                c.LastName = name;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, error);
        }

        /// <summary>
        /// FullName property validation
        /// </summary>
        [TestMethod]
        public void FullNameTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "Doe, John";
            string fName = " joHn ";
            string lName = " DOE ";
            c.FirstName = fName;
            c.LastName = lName;

            //Assert
            Assert.AreEqual(expected, c.FullName);
        }

        /// <summary>
        /// FullName property validation.
        /// FirstName empty.
        /// </summary>
        [TestMethod]
        public void FullNameFirsNameEmptyTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "Doe";
            string fName = "  ";
            string lName = " DOE ";
            string error = null;

            try
            {
                c.LastName = lName;
                c.FirstName = fName;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, c.FullName);
            Assert.AreEqual(ErrorMessages.EmptyFirstName, error);
        }

        /// <summary>
        /// FullName property validation.
        /// LastName empty. 
        /// </summary>
        [TestMethod]
        public void FullNameLastNameEmptyTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "John";
            string fName = " joHn ";
            string lName = "  ";

            string error = null;

            try
            {
                c.FirstName = fName;
                c.LastName = lName;
            }
            catch (FormatException e)
            {
                error = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, c.FullName);
            Assert.AreEqual(ErrorMessages.EmptyLastName, error);
        }

        /// <summary>
        /// Unit test for Validate() method.
        /// Invalid values: first/last name missing.
        /// </summary>
        [TestMethod]
        public void ValidateFistLastNameMissingTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            Customer b = new Customer();
            b.Email = "mail@mail.com";

            //Assert
            Assert.IsFalse(b.Validate());
        }

        /// <summary>
        /// Unit test for Validate() method.
        /// Invalid values: email missing.
        /// </summary>
        [TestMethod]
        public void ValidateEmailMissingTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            c.FirstName = "John";
            c.LastName = "Doe";

            //Assert
            Assert.IsFalse(c.Validate());
        }

        /// <summary>
        /// Unit test for Validate() method.
        /// Valid values.
        /// </summary>
        [TestMethod]
        public void ValidateValidTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            c.FirstName = "John";
            c.LastName = "Doe";
            c.Email = "mail@mail.com";

            //Assert
            Assert.IsTrue(c.Validate());
        }

        /// <summary>
        /// Customer constructor test
        /// </summary>
        [TestMethod]
        public void CustomerConstructorTest()
        {
            //Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "email@mail.com";

            //Address
            int addressId = 1;
            string streetLine1 = "Street 1";
            string streetLine2 = "Street 2";
            string city = "New York";
            string state = "New York";
            string postalCode = "3453434";
            string country = "USA";

            Address homeAddress = new Address(addressId)
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                PostalCode = postalCode,
                Country = country,
                AddressType = AddressType.HOME
            };

            int _addressId = 2;
            string _streetLine1 = "Street 3";
            string _streetLine2 = "Street 4";
            string _city = "Toronto";
            string _state = "Ontario";
            string _postalCode = "qwe23sd";
            string _country = "Canada";

            Address workAddress = new Address(_addressId)
            {
                StreetLine1 = _streetLine1,
                StreetLine2 = _streetLine2,
                City = _city,
                State = _state,
                PostalCode = _postalCode,
                Country = _country,
                AddressType = AddressType.WORK
            };

            //Act
            //c1.HomeAddress = homeAddress;
            //c1.WorkAddress = workAddress;
            Customer c1 = new Customer(firstName, lastName, email, homeAddress, workAddress);

            //Assert
            Assert.IsNotNull(c1);
            Assert.AreEqual(firstName, c1.FirstName);
            Assert.AreEqual(lastName, c1.LastName);
            Assert.AreEqual(email, c1.Email);

            //Address validation - home
            Assert.AreEqual(homeAddress.AddressType, c1.HomeAddress.AddressType);
            Assert.AreEqual(AddressType.HOME, c1.HomeAddress.AddressType);
            Assert.AreEqual(homeAddress.AddressId, c1.HomeAddress.AddressId);
            Assert.AreEqual(homeAddress.City, c1.HomeAddress.City);
            Assert.AreEqual(homeAddress.Country, c1.HomeAddress.Country);
            Assert.AreEqual(homeAddress.PostalCode, c1.HomeAddress.PostalCode);
            Assert.AreEqual(homeAddress.State, c1.HomeAddress.State);
            Assert.AreEqual(homeAddress.StreetLine1, c1.HomeAddress.StreetLine1);
            Assert.AreEqual(homeAddress.StreetLine2, c1.HomeAddress.StreetLine2);

            //Address validation - work
            Assert.AreEqual(workAddress.AddressType, c1.WorkAddress.AddressType);
            Assert.AreEqual(AddressType.WORK, c1.WorkAddress.AddressType);
            Assert.AreEqual(workAddress.AddressId, c1.WorkAddress.AddressId);
            Assert.AreEqual(workAddress.City, c1.WorkAddress.City);
            Assert.AreEqual(workAddress.Country, c1.WorkAddress.Country);
            Assert.AreEqual(workAddress.PostalCode, c1.WorkAddress.PostalCode);
            Assert.AreEqual(workAddress.State, c1.WorkAddress.State);
            Assert.AreEqual(workAddress.StreetLine1, c1.WorkAddress.StreetLine1);
            Assert.AreEqual(workAddress.StreetLine2, c1.WorkAddress.StreetLine2);
        }

        //End of class
    }
}
