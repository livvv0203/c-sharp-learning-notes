using Properties;
using System;

namespace c_sharp_learning
{
    class Program
    {
        /// <summary>
        /// This is the entry point 
        /// </summary>
        public static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(6);
            box.DisplayInfo();
            Console.WriteLine("Box length is: " + box.GetLength());
            
        }

    }
}




























