using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerUnitTest
    {
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
        /// Invalid values.
        /// </summary>
        [TestMethod]
        public void ValidateInvalidTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            //Assert
            Assert.IsFalse(c.Validate());

            //Act
            c.FirstName = "John";

            //Assert
            Assert.IsFalse(c.Validate());

            //Act
            c.LastName = "Doe";

            //Assert
            Assert.IsFalse(c.Validate());

            //Act
            c.LastName = " ";
            c.Email = "mail@mail.com";

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


        //End of class
    }
}
