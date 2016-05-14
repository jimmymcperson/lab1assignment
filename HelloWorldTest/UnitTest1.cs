using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

/**
 * Author: Jonathan Hao
 * Date Created: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300869273
 * 
 * Description: This program tests HelloWorldToConsole method from HelloWorldProgram class.
 *
 * @main HelloWorldTest
 * Version: 0.01
 */
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
            actualResult = HelloWorldProgram.HelloWorldToConsole();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
