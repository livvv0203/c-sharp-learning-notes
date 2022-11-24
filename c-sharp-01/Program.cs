using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;

namespace c_sharp_learning
{
    class Program
    {
        /// <summary>
        /// This is the entry point 
        /// </summary>
        public static void Main(string[] args)
        {
            runLoop();



        }

        public static void runLoop()
        {
            string userInput;
            int counter = 0;
            do
            {
                Console.WriteLine("Please input a number: ");
                userInput = Console.ReadLine();
                Console.WriteLine($"User input is: {userInput}, at ----{counter}----");
                counter++;
            } while (counter < 3);
        }
    }
}




























