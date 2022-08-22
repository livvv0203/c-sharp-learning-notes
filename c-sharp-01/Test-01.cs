using System;

namespace c_sharp_learning
{
    public struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    public class Test_01
    {
        public Test_01()
        {

            byte number = 255;
            int overflow = number + 1;
            int Number = 1;
            // Declare a constant
            const float Pi = 3.14f;

            // Console class is defined in System
            Console.WriteLine("This is Jieqing!");
            Console.WriteLine(number);
            Console.WriteLine(Number);
            Console.WriteLine(overflow);
            Console.WriteLine(Pi);
            Console.WriteLine("--------------");

            byte number_1 = 123; // Need to be initialized first
            char character = 'A';
            string firstName = "Jieqing";
            bool isWorking = true;
            Console.WriteLine(character);
            Console.WriteLine(number_1 + firstName + isWorking);

            try
            {
                var number_2 = "1234"; // string
                int i = Convert.ToInt32(number_2);
                Console.WriteLine(i);
            }
            catch (Exception)
            {
                // To prevent crashing
                Console.WriteLine("Number cannot be converted to Int32");
            }

            /*
             * Multi-line comments
             */

            // Array
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine(numbers.Length);

            var firstName1 = "Jieqing";
            var lastName1 = "Liu";

            var fullName = firstName1 + " " + lastName1;
            // OR - using string literal in c-sharp
            var myFullName = string.Format("My name is {0} {1}", firstName1, lastName1);

            // out
            // string s = "abc";

            //int number;
            //var result = int.TryParse(s, out number);


        }


    }
}






