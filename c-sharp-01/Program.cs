using System;
using System.Collections;
using System.Collections.Generic;

namespace c_sharp_learning
{
    class Program
    {
        // Entry point
        public static void Main(string[] args)
        {

            var list = new List<int>();
            list.Add(1);
            list.Add(3456);
            list.Add(23253534);

            int maxNum = SimpleAlgor.findMax(list);
            
            Console.WriteLine($"Max Number of List is: {maxNum}");
            Console.ReadLine();
        }
    }
}






















