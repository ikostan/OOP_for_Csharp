using System;
using ACME.COMMON;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.COMMONTest
{
    [TestClass]
    public class StringHandlerUnitTest
    {
        [TestMethod]
        public void CapitaliseFirstLetterTest()
        {
            //Arrange
            string str = " aCmE ";
            string expected = "Acme";

            //Act
            string result = StringHandler.GetInstance().CapitaliseFirstLetter(str);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
