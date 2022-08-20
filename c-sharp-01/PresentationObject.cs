using System;

namespace c_sharp_learning
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object is copied.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object is Duplicate.");
        }
    }
}






















