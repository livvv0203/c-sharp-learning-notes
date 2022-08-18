using System;
using System.Collections.Generic;


namespace c_sharp_01
{
    public class Test_02
    {
        void function_1()
        {
            var list = new List<int>();

            var dateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
        }

        void function_2()
        {
            var fullName = "     Jieqing ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
        }

        public static string ReversedName(string name)
        {
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            return new string(array);
        }
    }
}



