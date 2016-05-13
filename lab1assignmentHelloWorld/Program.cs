using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Jonathan Hao
 * Date Created: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300869273
 * 
 * Description: This program demonstrates GitHub control and unit testing practices.
 * @module HelloWorld
 * @main HelloWorld
 * Version: 0.01 - Initial Commit
 */

namespace HelloWorld
{
    /**
    * This is the driver class for our program
    *
    * @class HelloWorldProgram
    * @constructor HelloWorldProgram
    */
    public class HelloWorldProgram
    {
        /**
        * Main Method for class HelloWorldProgram
        *
        * @method Main
        * @static Main
        * @param args {string[]} No idea what this does -- came with MS Visual Studio template
        */
        static void Main(string[] args)
        {
            HelloWorldToConsole();
            Console.ReadLine(); // Pauses program for review
        }

        /**
        * This is my Hello world Method
        *
        * @method HelloWorldToConsole
        * @param
        * @return HelloWorldString {string}
        */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
