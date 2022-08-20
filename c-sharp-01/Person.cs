using System;
using System.Collections.Generic;
namespace c_sharp_learning
{
    public class Person
    {
        private string _name;
        public int Id;
        public List<Order> Orders;

        public string Name { get => _name; set => _name = value; }

        public Person()
        {
            Orders = new List<Order>();
        }
        
        // Constructor Overloading
        public Person(string _name)
            : this()
        {
            this.Name = _name;
        }

        public Person(string _name, int id)
            : this(_name)
        {
            this.Id = id;
        }

        // Getter in old way
        public string SetName()
        {
            return _name;
        }

        public int GetId()
        {
            return Id;
        }

        // Setter in old Way
        public void SetName(string _name)
        {
            if (!String.IsNullOrEmpty(_name))
                this._name = _name;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is: {1}", to, Name);
        }

        /*
         * Why using static members?
         * To represent concepts that are singleton
         */

    }
}
