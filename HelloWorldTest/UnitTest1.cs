using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;


namespace HelloWorldTest
{
    /**
    * This class is used to test methods.
    * Used for development only.
    *
    * @class HelloWorldTest
    * @constructor HelloWorldTest
    */ 
    [TestClass]
    public class HelloWorldTest
    {
        /**
        * This method is used to test the HelloWorldToConsole method of the HelloWorldProgram class.
        *
        * @method HelloWorldToConsoleTest
        */
        [TestMethod]
        public void HelloWorldToConsoleTest()
        {
            // Arrange
            string actualResult;
            string expectedResult = "Hello, World!";

            // Act
            actualResult = "Boo";

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
