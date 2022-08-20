using System;

namespace c_sharp_learning
{
    // First Create a obj vehicle
    public class Car : Vehicle
    {
        // Receive argument from Car Object, pass it to the base obj - Vehicle
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }
}






















