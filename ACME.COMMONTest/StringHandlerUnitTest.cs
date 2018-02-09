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

        [TestMethod]
        public void GetInstanceTest()
        {
            //Arrange
            var obj1 = StringHandler.GetInstance();

            //Act
            var obj2 = StringHandler.GetInstance();

            //Assert
            Assert.AreEqual(obj1, obj2);
        }

        //End of Class
    }
}
