using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerUnitTest
    {
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
        }

        /// <summary>
        /// Test FirstName property
        /// </summary>
        [TestMethod]
        public void LastNameTest()
        {
            //Arrange
            Customer c = new Customer();

            //Act
            string expected = "Doe";
            string name = "doe";
            c.LastName = name;

            //Assert
            Assert.AreEqual(expected, c.LastName);

            //Act
            string expected2 = "Smith";
            string name2 = "Smith";
            c.LastName = name2;

            //Assert
            Assert.AreEqual(expected2, c.LastName);
        }
    }
}
