using System;
namespace c_sharp_learning
{
    public abstract class ShapeNew
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public abstract void Draw();
        
        public void Copy()
        {
            Console.WriteLine("Copying the content.");
        }

      
    }
}
