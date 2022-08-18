using System;
namespace c_sharp_learning
{

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Enum_1
    {
        public int TestFunction()
        {
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var role = 2;

            switch(role)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            return b;
        }
        
	}


}
