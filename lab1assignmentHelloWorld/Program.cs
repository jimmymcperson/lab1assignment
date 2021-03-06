﻿using System;
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
 * Description: This program prints "Hello, World!" to the screen using a method call.
 *              It also demonstrates GitHub control and unit testing practices.
 *
 * @module HelloWorld
 * @main HelloWorld
 * Version: 0.05 - Comment block added to HelloWorldTest class for documentation.
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
        * @param {string[]} args No idea what this does -- came with MS Visual Studio template
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
        * @static HelloWorldToConsole
        * @return {string} HelloWorldString
        */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
