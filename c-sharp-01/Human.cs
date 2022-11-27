using System;

namespace c_sharp_learning
{
    class Human
    {
        // member variables
        public string firstName = "Default Name";
        public string lastName = "Default Last Name";
        public int age;

        // Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object is created.");
        } 

        // Parameterized constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is: {0} --- {1} ---- {2} years old. ", firstName, lastName, age);
        }
    }
}








